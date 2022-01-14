using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Sale
    {
        public int BookId { get; set; }
        public DateOnly SaleDate { get; set; }
        public DateTime SaleDateTime { get => SaleDate.ToDateTime(); }
        public int Quantity { get; set; }
        public Sale()
        {
            SaleDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
