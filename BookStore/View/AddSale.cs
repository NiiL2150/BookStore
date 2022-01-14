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
    public partial class AddSale : Form
    {
        public BookStoreForm ParentedForm { get; set; }
        public AddSale(BookStoreForm parentedForm)
        {
            InitializeComponent();

            ParentedForm = parentedForm;

            comboBoxBook.Items.AddRange(ParentedForm.Repository.Books.GetValues("Title").Keys.ToArray());
        }

        public Sale? GetSale()
        {
            try
            {
                Sale sale = new Sale()
                {
                    Quantity = (int)numericQuantity.Value,
                    BookId = ParentedForm.Repository.Books.GetValues("Title")[(string)comboBoxBook.SelectedItem]
                };

                return sale;
            }
            catch (Exception)
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
