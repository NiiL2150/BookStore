using BookStore.Model;
using BookStore.Repository;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookStore.View
{
    public partial class BookStoreForm : Form
    {
        public GlobalRepository Repository { get; set; }
        public SqlDataAdapter RecentAdapter { get; set; }
        public DataTable RecentTable { get; set; }

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

        private void buttonGet_Click(AbstractRepository repository)
        {
            if (IsKeyword) { Source = repository.Get(Keyword); }
            else { Source = repository.Get(SelectedId); }
            RecentAdapter = repository.Adapter;
            RecentTable = repository.DataTable;
            buttonUpdate.Enabled = true;
        }

        private void buttonTop_Click(AbstractRepository repository)
        {
            if(!Int32.TryParse(textBoxTopNumber.Text, out int topNumber))
            {
                topNumber = 1;
            }
            if (topNumber < 1)
            {
                topNumber = 1;
            }
            if(dateTimeFrom.Value > dateTimeTo.Value)
            {
                Source = repository.Top(topNumber);
            }
            else
            {
                Source = repository.Top(topNumber, dateTimeFrom.Value.ToDateOnly(), dateTimeTo.Value.ToDateOnly());
            }
            buttonUpdate.Enabled = false;
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            buttonGet_Click(Repository.Authors);
        }

        private void buttonGenres_Click(object sender, EventArgs e)
        {
            buttonGet_Click(Repository.Genres);
        }

        private void buttonPublishers_Click(object sender, EventArgs e)
        {
            buttonGet_Click(Repository.Publishers);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            buttonGet_Click(Repository.Books);
            buttonUpdate.Enabled = false;
        }

        private void buttonBooks2_Click(object sender, EventArgs e)
        {
            Source = Repository.Books.GetEditReady(SelectedId);
            RecentAdapter = Repository.Books.Adapter;
            RecentTable = Repository.Books.DataTable;
            buttonUpdate.Enabled = true;
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

        private void buttonDeletePromos_Click(object sender, EventArgs e)
        {
            Repository.Books.DeletePromos();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataTable? table = RecentTable.GetChanges();
            if(table != null)
            {
                RecentAdapter.Update(table);
            }
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            buttonGet_Click(Repository.Sales);
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            AddSale form = new AddSale(this);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                Sale? sale = form.GetSale();
                if (sale != null)
                {
                    Repository.Sales.Add(sale);
                }
            }
            form.Dispose();
        }

        private void buttonDeleteSale_Click(object sender, EventArgs e)
        {
            if (DeletedId != null) { Repository.Sales.Delete((int)DeletedId); }
        }

        private void buttonTopAuthor_Click(object sender, EventArgs e)
        {
            buttonTop_Click(Repository.Authors);
        }

        private void buttonTopGenre_Click(object sender, EventArgs e)
        {
            buttonTop_Click(Repository.Genres);
        }

        private void buttonTopPublisher_Click(object sender, EventArgs e)
        {
            buttonTop_Click(Repository.Publishers);
        }

        private void buttonTopBook_Click(object sender, EventArgs e)
        {
            buttonTop_Click(Repository.Books);
        }
    }
}
