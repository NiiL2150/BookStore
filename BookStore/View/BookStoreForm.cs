using BookStore.Model;
using BookStore.Repository;
using System;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class BookStoreForm : Form
    {
        GlobalRepository Repository { get; set; }

        string Keyword { get => textBoxKeyword.Text; }
        int? SelectedId
        {
            get
            {
                int id;
                if(Int32.TryParse(textBoxId.Text, out id))
                {
                    if (id <= 0) return null;
                    return id;
                }
                return null;
            }
        }
        int? DeletedId
        {
            get
            {
                int id;
                if (Int32.TryParse(textBoxDeletionId.Text, out id))
                {
                    if (id <= 0) return null;
                    return id;
                }
                return null;
            }
        }
        bool IsKeyword { get => radioButtonKeyword.Checked; }
        object Source { set => dataGridView1.DataSource = value; }
        string NewName { get => textBoxAddName.Text; }
        string PromoKeyword { get => textBoxPromoKeyword.Text; }
        double PromoPercent { get { double tmp; return (100 - (Double.TryParse(textBoxPercent.Text, out tmp) ? tmp : 0)) / 100; } }

        public BookStoreForm(GlobalRepository repository)
        {
            InitializeComponent();
            Repository = repository;
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            if (IsKeyword) Source = Repository.Authors.Get(Keyword);
            else Source = Repository.Authors.Get(SelectedId);
        }

        private void buttonGenres_Click(object sender, EventArgs e)
        {
            if (IsKeyword) Source = Repository.Genres.Get(Keyword);
            else Source = Repository.Genres.Get(SelectedId);
        }

        private void buttonPublishers_Click(object sender, EventArgs e)
        {
            if (IsKeyword) Source = Repository.Publishers.Get(Keyword);
            else Source = Repository.Publishers.Get(SelectedId);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            if (IsKeyword) Source = Repository.Books.Get(Keyword);
            else Source = Repository.Books.Get(SelectedId);
        }

        private void buttonBooks2_Click(object sender, EventArgs e)
        {
            if (IsKeyword) Source = Repository.Books.GetEditReady(Keyword);
            else Source = Repository.Books.GetEditReady(SelectedId);
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre() { Name = NewName };
            Repository.Genres.Add(genre);
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher() { Name = NewName };
            Repository.Publishers.Add(publisher);
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            Author author = new Author() { Name = NewName };
            Repository.Authors.Add(author);
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBook form = new AddBook(this);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Book? book = form.GetBook();
                if (book != null)
                {
                    Repository.Books.Add(book);
                }
            }
            form.Dispose();
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (DeletedId != null) { Repository.Authors.Delete((int)DeletedId); }
        }

        private void buttonDeleteGenre_Click(object sender, EventArgs e)
        {
            if (DeletedId != null) { Repository.Genres.Delete((int)DeletedId); }
        }

        private void buttonDeletePublisher_Click(object sender, EventArgs e)
        {
            if (DeletedId != null) { Repository.Publishers.Delete((int)DeletedId); }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (DeletedId != null) { Repository.Books.Delete((int)DeletedId); }
        }

        private void buttonAddPromo_Click(object sender, EventArgs e)
        {
            Repository.Books.AddPromo(PromoPercent, PromoKeyword);
        }
    }
}
