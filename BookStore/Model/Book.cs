using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public DateTime Year { get; set; }
        public int Stock { get; set; }
        public int Sold { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public float PriceMultiplier { get; set; }
        public int? PreviousBookId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int GenreId { get; set; }
    }
}
