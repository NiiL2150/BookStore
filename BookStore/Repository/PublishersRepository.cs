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
    public class PublishersRepository : AbstractRepository
    {
        public PublishersRepository(GlobalRepository repository) : base(repository, "Publishers") { }

        public override string TopQuery
        {
            get
            {
                return @"
SELECT TOP(@Number) WITH TIES P.Id, P.[Name], SUM(subq.SoldBooks) [Sold Books] FROM Publishers AS P
JOIN 
(SELECT S.BookId, B.Title, COUNT(S.BookId) [SoldBooks], B.PublisherId FROM Books AS B
JOIN Sales AS S ON B.Id = S.BookId
WHERE S.SaleDate BETWEEN @FromDate AND @ToDate
GROUP BY S.BookId, B.Title, B.PublisherId)
subq ON subq.PublisherId = P.Id
GROUP BY P.Id, P.[Name]
ORDER BY SUM(subq.SoldBooks) DESC";
            }
        }

        public override object Get(int? id)
        {
            return Get(id, "Publishers", false);
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query = @"SELECT * FROM Publishers WHERE [Name] LIKE CONCAT('%', @Keyword, '%')";

            command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Keyword", SqlDbType.NVarChar, keyword));

            return RefreshedDataTable();
        }

        public override object GetAll()
        {
            return GetAll("Publishers");
        }

        public override void Add(object obj)
        {
            Publisher? publisher = obj as Publisher;
            if (publisher == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Publishers([Name])
VALUES (@Name);";
            SqlCommand command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Name", SqlDbType.NVarChar, publisher.Name));

            ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            Delete(id, "Publishers");
        }
    }
}
