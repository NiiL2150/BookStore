using BookStore.Model;
using BookStore.Repository;
using System;
using System.Windows.Forms;

namespace BookStore.View
{
    internal partial class BookStoreForm : Form
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
        bool IsKeyword { get => radioButtonKeyword.Checked; }
        object Source { set => dataGridView1.DataSource = value; }
        string NewName { get => textBoxAddName.Text; }

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
    }
}
