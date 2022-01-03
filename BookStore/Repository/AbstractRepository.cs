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
        public SqlDataAdapter Adapter { get { return adapter; } }
        public DataTable DataTable { get { return dataTable; } }
        protected GlobalRepository Global { get; set; }

        public AbstractRepository(GlobalRepository repository)
        {
            Global = repository;
        }

        public abstract object Get(int? id);
        public abstract object Get(string keyword);
        public abstract void Add(object obj);
        public abstract void Delete(int id);
        public abstract object GetAll();

        //Sample of text = query when fullQuery: $"SELECT Id, [Name] FROM Books"
        //Sample of text when !fullQuery: "Books", query = "SELECT * FROM Books"
        protected object Get(int? id, string text, bool fullQuery)
        {
            dataTable = new DataTable();
            string query;

            if (fullQuery) { query = text; }
            else { query = @"SELECT * FROM " + text; }

            if (id != null && !fullQuery) { query += " WHERE Id = @Id"; };

            command = new SqlCommand(query, Global.Connection);
            if (id != null)
            {
                SqlParameter par1 = new SqlParameter("@Id", SqlDbType.Int);
                par1.Value = id;
                command.Parameters.Add(par1);
            }

            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataTable);
            return dataTable;
        }

        protected object GetAll(string text)
        {
            dataTable = new DataTable();
            string query = $@"SELECT * FROM {text}";

            command = new SqlCommand(query, Global.Connection);

            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public Dictionary<string, int> GetValues(string valueType)
        {
            Dictionary<string, int> vs = new Dictionary<string, int>();
            foreach (DataRow item in ((DataTable)GetAll()).Rows)
            {
                vs.Add((string)item[valueType], (int)item["Id"]);
            }
            return vs;
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
