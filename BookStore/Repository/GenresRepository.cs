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
    public class GenresRepository : AbstractRepository
    {
        public GenresRepository(GlobalRepository repository) : base(repository, "Genres") { }

        public override string TopQuery
        {
            get
            {
                return @"
SELECT TOP(@Number) WITH TIES G.Id, G.[Name], SUM(subq.SoldBooks) [Sold Books] FROM Genres AS G
JOIN 
(SELECT S.BookId, B.Title, COUNT(S.BookId) [SoldBooks], B.GenreId FROM Books AS B
JOIN Sales AS S ON B.Id = S.BookId
WHERE S.SaleDate BETWEEN @FromDate AND @ToDate
GROUP BY S.BookId, B.Title, B.GenreId)
subq ON subq.GenreId = G.Id
GROUP BY G.Id, G.[Name]
ORDER BY SUM(subq.SoldBooks) DESC";
            }
        }

        public override object Get(int? id)
        {
            return Get(id, "Genres", false);
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query = @"SELECT * FROM Genres WHERE [Name] LIKE CONCAT('%', @Keyword, '%')";

            command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Keyword", SqlDbType.NVarChar, keyword));

            return RefreshedDataTable();
        }

        public override object GetAll()
        {
            return GetAll("Genres");
        }

        public override void Add(object obj)
        {
            Genre? genre = obj as Genre;
            if (genre == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Genres([Name])
VALUES (@Name);";
            SqlCommand command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Name", SqlDbType.NVarChar, genre.Name));

            ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            Delete(id, "Genres");
        }
    }
}
