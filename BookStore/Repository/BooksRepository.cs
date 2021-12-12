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

        public override void Add(object obj)
        {
            Book? book = obj as Book;
            if(book == null) { return; }
        }
    }
}
