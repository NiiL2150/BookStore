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
    public class SalesRepository : AbstractRepository
    {
        public SalesRepository(GlobalRepository repository) : base(repository) { }

        public override object Get(int? id)
        {
            return Get(id, "Sales", false);
        }

        public override object Get(string keyword)
        {
            if (Int32.TryParse(keyword, out var id))
                return Get(id,
                        "SELECT * FROM Sales WHERE BookId = @Id",
                        true);
            else return GetAll();
        }

        public override object GetAll()
        {
            return GetAll("Sales");
        }

        public override void Add(object obj)
        {
            Sale? sale = obj as Sale;
            if (sale == null) { return; }

            Global.Connection.Open();
            string query = @"IF (SELECT Stock FROM Books WHERE Id = 2) > 0
BEGIN
	INSERT INTO Sales([BookId])
	VALUES (2);
	UPDATE Books SET Stock = Stock - 1
	WHERE Id = 2;
END;";
            SqlCommand command = new SqlCommand(query, Global.Connection);

            SqlParameter par1 = new SqlParameter("@BookId", SqlDbType.Int);
            par1.Value = sale.BookId;

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
            Delete(id, "Sales");
        }
    }
}
