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
        public GenresRepository(GlobalRepository repository) : base(repository) { }

        public override object Get(int? id)
        {
            return Get(id, "Genres", false);
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query = @"SELECT * FROM Genres WHERE [Name] LIKE CONCAT('%', @Keyword, '%')";

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
            Genre? genre = obj as Genre;
            if (genre == null) { return; }
        }
    }
}
