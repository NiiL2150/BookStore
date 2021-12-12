using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BooksRepository : AbstractRepository
    {
        public BooksRepository(GlobalRepository repository) : base(repository) { }

        public override object Get(int? id)
        {
            dataTable = new DataTable();
            string query =
@"SELECT B.Id, B.Title, A.[Name] AS Author, G.[Name] AS Genre, P.[Name] as Publisher, Pages,
Stock, Cost, Price AS RegularPrice, PriceMultiplier as Mult,
Price * PriceMultiplier AS CurrentPrice, [Year], PreviousBookId FROM Books AS B
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id";

            if (id != null) { query += " WHERE B.Id = @Id"; };

            command = new SqlCommand(query, Global.Connection);
            if (id != null)
            {
                SqlParameter par1 = new SqlParameter("@Id", SqlDbType.Int);
                par1.Value = id;
                command.Parameters.Add(par1);
            }

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query =
@"SELECT B.Id, B.Title, A.[Name] AS Author, G.[Name] AS Genre, P.[Name] as Publisher, Pages,
Stock, Cost, Price AS RegularPrice, PriceMultiplier as Mult,
Price * PriceMultiplier AS CurrentPrice, [Year], PreviousBookId FROM Books AS B
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id
WHERE B.Title LIKE CONCAT('%', @Keyword, '%') OR
A.[Name] LIKE CONCAT('%', @Keyword, '%') OR
G.[Name] LIKE CONCAT('%', @Keyword, '%') OR
P.[Name] LIKE CONCAT('%', @Keyword, '%');";

            command = new SqlCommand(query, Global.Connection);
            SqlParameter par1 = new SqlParameter("@Keyword", SqlDbType.NVarChar);
            par1.Value = keyword;
            command.Parameters.Add(par1);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public object GetEditReady(int? id)
        {
            dataTable = new DataTable();
            string query =
@"SELECT * FROM Books AS B
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id";

            if (id != null) { query += " WHERE B.Id = @Id"; };

            command = new SqlCommand(query, Global.Connection);
            if (id != null)
            {
                SqlParameter par1 = new SqlParameter("@Id", SqlDbType.Int);
                par1.Value = id;
                command.Parameters.Add(par1);
            }

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public object GetEditReady(string keyword)
        {
            dataTable = new DataTable();
            string query =
@"SELECT * FROM Books AS B
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id
WHERE B.Title LIKE CONCAT('%', @Keyword, '%') OR
A.[Name] LIKE CONCAT('%', @Keyword, '%') OR
G.[Name] LIKE CONCAT('%', @Keyword, '%') OR
P.[Name] LIKE CONCAT('%', @Keyword, '%');";

            command = new SqlCommand(query, Global.Connection);
            SqlParameter par1 = new SqlParameter("@Keyword", SqlDbType.NVarChar);
            par1.Value = keyword;
            command.Parameters.Add(par1);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public override void Add(object obj)
        {
            Book? book = obj as Book;
            if(book == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Books([Title], [AuthorId], [GenreId], [PublisherId], [Pages], [Cost], [Price], [Year], [PreviousBookId])
VALUES (@Title, @AuthorID, @GenreID, @PublisherID, @Pages, @Cost, @Price, @Date";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Title", SqlDbType.NVarChar) { Value = book.Title },
                new SqlParameter("@AuthorID", SqlDbType.Int) { Value = book.AuthorId },
                new SqlParameter("@GenreID", SqlDbType.Int) { Value = book.GenreId },
                new SqlParameter("@PublisherID", SqlDbType.Int) { Value = book.PublisherId },
                new SqlParameter("@Pages", SqlDbType.Int) { Value = book.Pages },
                new SqlParameter("@Cost", SqlDbType.Decimal) { Value = book.Cost },
                new SqlParameter("@Price", SqlDbType.Decimal) { Value = book.Price },
                new SqlParameter("@Date", SqlDbType.DateTime) { Value = book.Year }
            };

            if(book.PreviousBookId != null)
            {
                query += ", @PreviousBookId";
                parameters.Append(new SqlParameter("@PreviousBookId", SqlDbType.Int) { Value = book.PreviousBookId });
            }
            else { query += ", null"; }

            query += ");";

            SqlCommand command = new SqlCommand(query, Global.Connection);

            foreach (var item in parameters)
            {
                command.Parameters.Add(item);
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Global.Connection.Close();
            }
        }

        public override void Delete(int id)
        {
            Delete(id, "Books");
        }

        public void AddPromo(double percentage, string text)
        {
            Global.Connection.Open();
            string query = @"UPDATE Books SET PriceMultiplier = @Percentage 
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id
WHERE B.Title LIKE CONCAT('%', @Keyword, '%') OR
A.[Name] LIKE CONCAT('%', @Keyword, '%') OR
G.[Name] LIKE CONCAT('%', @Keyword, '%') OR
P.[Name] LIKE CONCAT('%', @Keyword, '%');";

            command = new SqlCommand(query, Global.Connection);
            SqlParameter par1 = new SqlParameter("@Percentage", SqlDbType.Float);
            par1.Value = percentage;
            command.Parameters.Add(par1);
            SqlParameter par2 = new SqlParameter("@Keyword", SqlDbType.NVarChar);
            par2.Value = text;
            command.Parameters.Add(par2);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Global.Connection.Close();
            }
        }

        public void DeletePromos()
        {
            Global.Connection.Open();
            string query = "UPDATE Books SET PriceMultiplier = 1;";

            command = new SqlCommand(query, Global.Connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Global.Connection.Close();
            }
        }
    }
}
