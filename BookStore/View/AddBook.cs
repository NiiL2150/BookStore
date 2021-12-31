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

            comboBoxAuthor.Items.AddRange(ParentedForm.Repository.Authors.GetValues("Name").Keys.ToArray());
            comboBoxGenre.Items.AddRange(ParentedForm.Repository.Genres.GetValues("Name").Keys.ToArray());
            comboBoxPublisher.Items.AddRange(ParentedForm.Repository.Publishers.GetValues("Name").Keys.ToArray());
            comboBoxPreviousBook.Items.AddRange(ParentedForm.Repository.Books.GetValues("Title").Keys.ToArray());
        }
        public Book? GetBook()
        {
            try
            {
                int? tmp = comboBoxPreviousBook.SelectedIndex == -1 ? null : ParentedForm.Repository.Books.GetValues("Title")[(string)comboBoxPreviousBook.SelectedItem];
                Book book = new Book()
                {
                    Title = textBoxTitle.Text,
                    Pages = (int)numericPages.Value,
                    Year = dateTimePicker1.Value,
                    Cost = numericCost.Value,
                    Price = numericPrice.Value,
                    AuthorId = ParentedForm.Repository.Authors.GetValues("Name")[(string)comboBoxAuthor.SelectedItem],
                    PublisherId = ParentedForm.Repository.Publishers.GetValues("Name")[(string)comboBoxPublisher.SelectedItem],
                    GenreId = ParentedForm.Repository.Genres.GetValues("Name")[(string)comboBoxGenre.SelectedItem],
                    PreviousBookId = tmp
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
