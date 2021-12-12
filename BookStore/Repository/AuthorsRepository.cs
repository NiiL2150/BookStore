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
        public AuthorsRepository(GlobalRepository repository) : base(repository) { }

        public override object Get(int? id)
        {
            return Get(id, "Authors", false);
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query = @"SELECT * FROM Authors WHERE [Name] LIKE CONCAT('%', @Keyword, '%')";

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
            Author? author = obj as Author;
            if (author == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Authors([Name])
VALUES (@Name);";
            SqlCommand command = new SqlCommand(query, Global.Connection);

            SqlParameter par1 = new SqlParameter("@Name", SqlDbType.NVarChar);
            par1.Value = author.Name;
            command.Parameters.Add(par1);

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
            Delete(id, "Authors");
        }
    }
}
