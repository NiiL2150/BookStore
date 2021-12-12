using BookStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class AddBook : Form
    {
        public BookStoreForm ParentedForm { get; set; }
        public AddBook(BookStoreForm form)
        {
            InitializeComponent();

            ParentedForm = form;
        }
        public Book? GetBook()
        {
            try
            {
                int tmp = 0;
                Int32.TryParse(textBoxPrevBook.Text, out tmp);
                Book book = new Book()
                {
                    Title = textBoxTitle.Text,
                    Pages = Int32.Parse(textBoxPages.Text),
                    Year = dateTimePicker1.Value,
                    Cost = Int32.Parse(textBoxCost.Text),
                    Price = Int32.Parse(textBoxPrice.Text),
                    AuthorId = Int32.Parse(textBoxAuthorId.Text),
                    PublisherId = Int32.Parse(textBoxPublisherId.Text),
                    GenreId = Int32.Parse(textBoxGenreId.Text),
                    PreviousBookId = tmp > 0 ? tmp : null 
                };

                return book;
            }
            catch(Exception)
            {
                return null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
