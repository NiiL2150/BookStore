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
        public int Stock { get; set; } = 0;
        public int Sold { get; set; } = 0;
        public decimal Cost { get; set; } = 0;
        public decimal Price { get; set; } = 0;
        public float PriceMultiplier { get; set; } = 1;
        public int? PreviousBookId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int GenreId { get; set; }
    }
}
