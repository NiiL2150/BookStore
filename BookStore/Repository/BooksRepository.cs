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
        public BooksRepository(GlobalRepository repository) : base(repository, "Books") { }

        public override string TopQuery
        {
            get
            {
                return @"
SELECT TOP(@Number) WITH TIES S.BookId, B.Title, COUNT(S.BookId) [Sold books] FROM Books AS B
JOIN Sales AS S ON B.Id = S.BookId
WHERE S.SaleDate BETWEEN @FromDate AND @ToDate
GROUP BY S.BookId, B.Title
ORDER BY COUNT(S.BookId) DESC";
            }
        }

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

            return RefreshedDataTable();
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

            command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Keyword", SqlDbType.NVarChar, keyword));

            return RefreshedDataTable();
        }

        public override object GetAll()
        {
            return GetAll("Books");
        }

        public object GetEditReady(int? id)
        {
            dataTable = new DataTable();
            string query =
@"SELECT B.* FROM Books AS B";

            if (id != null) { query += " WHERE B.Id = @Id"; };

            command = new SqlCommand(query, Global.Connection);
            if (id != null)
            {
                SqlParameter par1 = SqlHelper.SqlParameter("@Id", SqlDbType.Int, id);
                command.Parameters.Add(par1);
            }

            return RefreshedDataTable();
        }

        public override void Add(object obj)
        {
            Book? book = obj as Book;
            if(book == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Books([Title], [AuthorId], [GenreId], [PublisherId], [Pages], [Cost], [Price], [Year], [PreviousBookId])
VALUES (@Title, @AuthorID, @GenreID, @PublisherID, @Pages, @Cost, @Price, @Date";

            SqlParameter[] parameters = new SqlParameter[] {
                SqlHelper.SqlParameter("@Title", SqlDbType.NVarChar, book.Title),
                SqlHelper.SqlParameter("@AuthorID", SqlDbType.Int, book.AuthorId),
                SqlHelper.SqlParameter("@GenreID", SqlDbType.Int, book.GenreId),
                SqlHelper.SqlParameter("@PublisherID", SqlDbType.Int, book.PublisherId),
                SqlHelper.SqlParameter("@Pages", SqlDbType.Int, book.Pages),
                SqlHelper.SqlParameter("@Cost", SqlDbType.Decimal, book.Cost),
                SqlHelper.SqlParameter("@Price", SqlDbType.Decimal, book.Price),
                SqlHelper.SqlParameter("@Date", SqlDbType.DateTime, book.Year)
            };

            if(book.PreviousBookId != null)
            {
                query += ", @PreviousBookId";
                parameters = parameters
                    .Append(SqlHelper.SqlParameter("@PreviousBookId", SqlDbType.Int,
                    book.PreviousBookId)).ToArray();
            }
            else { query += ", null"; }

            query += ");";

            SqlCommand command = SqlHelper.SqlCommand(query, Global.Connection, parameters);

            ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            Delete(id, "Books");
        }

        public void AddPromo(double percentage, string text)
        {
            Global.Connection.Open();
            string query = @"UPDATE Books SET PriceMultiplier = @Percentage 
FROM Books B
JOIN Authors AS A ON B.AuthorId = A.Id
JOIN Genres AS G ON B.GenreId = G.Id
JOIN Publishers AS P ON B.PublisherId = P.Id
WHERE B.Title LIKE CONCAT('%', @Keyword, '%') OR
A.[Name] LIKE CONCAT('%', @Keyword, '%') OR
G.[Name] LIKE CONCAT('%', @Keyword, '%') OR
P.[Name] LIKE CONCAT('%', @Keyword, '%');";

            command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Percentage", SqlDbType.Float, percentage),
                SqlHelper.SqlParameter("@Keyword", SqlDbType.NVarChar, text));

            ExecuteNonQuery();
        }

        public void DeletePromos()
        {
            Global.Connection.Open();
            string query = "UPDATE Books SET PriceMultiplier = 1;";

            command = new SqlCommand(query, Global.Connection);

            ExecuteNonQuery();
        }
    }
}
