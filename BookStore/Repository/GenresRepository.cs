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
