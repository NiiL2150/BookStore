using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public abstract class AbstractRepository
    {
        protected DataTable dataTable;
        protected SqlCommand command;
        protected SqlDataAdapter adapter;
        protected GlobalRepository Global { get; set; }

        public AbstractRepository(GlobalRepository repository)
        {
            Global = repository;
        }

        public abstract object Get(int? id);
        public abstract object Get(string keyword);
        public abstract void Add(object obj);
        public abstract void Delete(int id);

        //Sample of text = query when fullQuery: $"SELECT Id, [Name] FROM Books"
        //Sample of text when !fullQuery: "Books", query = "SELECT * FROM Books"
        protected object Get(int? id, string text, bool fullQuery)
        {
            dataTable = new DataTable();
            string query;

            if (fullQuery) { query = text; }
            else { query = @"SELECT * FROM " + text; }

            if (id != null) { query += " WHERE Id = @Id"; };

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

        protected void Delete(int id, string tableName)
        {
            Global.Connection.Open();
            string query = $"DELETE FROM {tableName} WHERE Id = @Id";

            command = new SqlCommand(query, Global.Connection);
            SqlParameter par1 = new SqlParameter("@Id", SqlDbType.Int);
            par1.Value = id;
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
    }
}
