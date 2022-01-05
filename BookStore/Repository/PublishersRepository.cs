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
