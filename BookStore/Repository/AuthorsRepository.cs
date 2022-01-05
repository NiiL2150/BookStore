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
    public class AuthorsRepository : AbstractRepository
    {
        public AuthorsRepository(GlobalRepository repository) : base(repository, "Authors") { }

        public override object Get(int? id)
        {
            return Get(id, "Authors", false);
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query = @"SELECT * FROM Authors WHERE [Name] LIKE CONCAT('%', @Keyword, '%')";

            command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Keyword", SqlDbType.NVarChar, keyword));

            return RefreshedDataTable();
        }

        public override object GetAll()
        {
            return GetAll("Authors");
        }

        public override void Add(object obj)
        {
            Author? author = obj as Author;
            if (author == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Authors([Name])
VALUES (@Name);";
            SqlCommand command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@Name", SqlDbType.NVarChar, author.Name));

            ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            Delete(id, "Authors");
        }
    }
}
