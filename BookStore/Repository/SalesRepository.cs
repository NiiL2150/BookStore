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
        public SalesRepository(GlobalRepository repository) : base(repository, "Sales") { }

        public override string TopQuery
        {
            get
            {
                return @"";
            }
        }

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
            else if (DateOnly.TryParse(keyword, out var date))
            {
                dataTable = new DataTable();
                string query = @"SELECT * FROM Sales WHERE SaleDate = @SaleDate";

                
                command = SqlHelper.SqlCommand(query, Global.Connection,
                    SqlHelper.SqlParameter("@SaleDate", SqlDbType.Date, date.ToDateTime()));

                return RefreshedDataTable();
            }
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
            string query = @"IF (SELECT Stock FROM Books WHERE Id = @BookId) >= @Quantity
BEGIN
	INSERT INTO Sales([BookId], [SaleDate], [Quantity])
	VALUES (@BookId, @SaleDate, @Quantity);
	UPDATE Books SET Stock = Stock - @Quantity
	WHERE Id = @BookId;
END;";
            command = SqlHelper.SqlCommand(query, Global.Connection,
                SqlHelper.SqlParameter("@BookId", SqlDbType.Int, sale.BookId),
                SqlHelper.SqlParameter("@SaleDate", SqlDbType.Date, sale.SaleDateTime),
                SqlHelper.SqlParameter("@Quantity", SqlDbType.Int, sale.Quantity));

            ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            Delete(id, "Sales");
        }
    }
}
