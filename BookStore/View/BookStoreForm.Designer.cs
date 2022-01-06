namespace BookStore.View
{
    partial class BookStoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonGenres = new System.Windows.Forms.Button();
            this.buttonPublishers = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelGet = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonKeyword = new System.Windows.Forms.RadioButton();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteGenre = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonDeletePublisher = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.textBoxDeletionId = new System.Windows.Forms.TextBox();
            this.buttonBooks2 = new System.Windows.Forms.Button();
            this.buttonAddPromo = new System.Windows.Forms.Button();
            this.buttonDeletePromos = new System.Windows.Forms.Button();
            this.textBoxPromoKeyword = new System.Windows.Forms.TextBox();
            this.labelPromoKeyword = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.textBoxPercent = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonAddSale = new System.Windows.Forms.Button();
            this.buttonDeleteSale = new System.Windows.Forms.Button();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTopNumber = new System.Windows.Forms.TextBox();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.buttonTopAuthor = new System.Windows.Forms.Button();
            this.buttonTopGenre = new System.Windows.Forms.Button();
            this.buttonTopPublisher = new System.Windows.Forms.Button();
            this.buttonTopBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 582);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(55, 12);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(57, 23);
            this.buttonAuthors.TabIndex = 1;
            this.buttonAuthors.Text = "Authors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonGenres
            // 
            this.buttonGenres.Location = new System.Drawing.Point(118, 12);
            this.buttonGenres.Name = "buttonGenres";
            this.buttonGenres.Size = new System.Drawing.Size(52, 23);
            this.buttonGenres.TabIndex = 2;
            this.buttonGenres.Text = "Genres";
            this.buttonGenres.UseVisualStyleBackColor = true;
            this.buttonGenres.Click += new System.EventHandler(this.buttonGenres_Click);
            // 
            // buttonPublishers
            // 
            this.buttonPublishers.Location = new System.Drawing.Point(176, 12);
            this.buttonPublishers.Name = "buttonPublishers";
            this.buttonPublishers.Size = new System.Drawing.Size(69, 23);
            this.buttonPublishers.TabIndex = 3;
            this.buttonPublishers.Text = "Publishers";
            this.buttonPublishers.UseVisualStyleBackColor = true;
            this.buttonPublishers.Click += new System.EventHandler(this.buttonPublishers_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(251, 12);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(66, 23);
            this.buttonBooks.TabIndex = 4;
            this.buttonBooks.Text = "Books (1)";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(55, 41);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 23);
            this.textBoxId.TabIndex = 5;
            // 
            // labelGet
            // 
            this.labelGet.AutoSize = true;
            this.labelGet.Location = new System.Drawing.Point(12, 16);
            this.labelGet.Name = "labelGet";
            this.labelGet.Size = new System.Drawing.Size(37, 15);
            this.labelGet.TabIndex = 6;
            this.labelGet.Text = "Get ...";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(241, 41);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(206, 23);
            this.textBoxKeyword.TabIndex = 9;
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Checked = true;
            this.radioButtonId.Location = new System.Drawing.Point(12, 42);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(39, 19);
            this.radioButtonId.TabIndex = 10;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "ID:";
            this.radioButtonId.UseVisualStyleBackColor = true;
            // 
            // radioButtonKeyword
            // 
            this.radioButtonKeyword.AutoSize = true;
            this.radioButtonKeyword.Location = new System.Drawing.Point(161, 42);
            this.radioButtonKeyword.Name = "radioButtonKeyword";
            this.radioButtonKeyword.Size = new System.Drawing.Size(74, 19);
            this.radioButtonKeyword.TabIndex = 11;
            this.radioButtonKeyword.Text = "Keyword:";
            this.radioButtonKeyword.UseVisualStyleBackColor = true;
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(577, 12);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(48, 23);
            this.buttonAddGenre.TabIndex = 12;
            this.buttonAddGenre.Text = "Genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Location = new System.Drawing.Point(631, 12);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(67, 23);
            this.buttonAddPublisher.TabIndex = 13;
            this.buttonAddPublisher.Text = "Publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(516, 12);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(55, 23);
            this.buttonAddAuthor.TabIndex = 14;
            this.buttonAddAuthor.Text = "Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(472, 41);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(226, 23);
            this.textBoxAddName.TabIndex = 15;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(704, 13);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(48, 23);
            this.buttonAddBook.TabIndex = 16;
            this.buttonAddBook.Text = "Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Delete: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1169, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.Location = new System.Drawing.Point(920, 12);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
            this.buttonDeleteGenre.Size = new System.Drawing.Size(58, 23);
            this.buttonDeleteGenre.TabIndex = 19;
            this.buttonDeleteGenre.Text = "Genre";
            this.buttonDeleteGenre.UseVisualStyleBackColor = true;
            this.buttonDeleteGenre.Click += new System.EventHandler(this.buttonDeleteGenre_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(856, 12);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(58, 23);
            this.buttonDeleteAuthor.TabIndex = 20;
            this.buttonDeleteAuthor.Text = "Author";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonDeletePublisher
            // 
            this.buttonDeletePublisher.Location = new System.Drawing.Point(984, 12);
            this.buttonDeletePublisher.Name = "buttonDeletePublisher";
            this.buttonDeletePublisher.Size = new System.Drawing.Size(70, 23);
            this.buttonDeletePublisher.TabIndex = 21;
            this.buttonDeletePublisher.Text = "Publisher";
            this.buttonDeletePublisher.UseVisualStyleBackColor = true;
            this.buttonDeletePublisher.Click += new System.EventHandler(this.buttonDeletePublisher_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(1060, 12);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(55, 23);
            this.buttonDeleteBook.TabIndex = 22;
            this.buttonDeleteBook.Text = "Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // textBoxDeletionId
            // 
            this.textBoxDeletionId.Location = new System.Drawing.Point(1196, 13);
            this.textBoxDeletionId.Name = "textBoxDeletionId";
            this.textBoxDeletionId.Size = new System.Drawing.Size(56, 23);
            this.textBoxDeletionId.TabIndex = 23;
            // 
            // buttonBooks2
            // 
            this.buttonBooks2.Location = new System.Drawing.Point(323, 12);
            this.buttonBooks2.Name = "buttonBooks2";
            this.buttonBooks2.Size = new System.Drawing.Size(66, 23);
            this.buttonBooks2.TabIndex = 24;
            this.buttonBooks2.Text = "Books (2)";
            this.buttonBooks2.UseVisualStyleBackColor = true;
            this.buttonBooks2.Click += new System.EventHandler(this.buttonBooks2_Click);
            // 
            // buttonAddPromo
            // 
            this.buttonAddPromo.Location = new System.Drawing.Point(1060, 41);
            this.buttonAddPromo.Name = "buttonAddPromo";
            this.buttonAddPromo.Size = new System.Drawing.Size(82, 23);
            this.buttonAddPromo.TabIndex = 25;
            this.buttonAddPromo.Text = "Add promo";
            this.buttonAddPromo.UseVisualStyleBackColor = true;
            this.buttonAddPromo.Click += new System.EventHandler(this.buttonAddPromo_Click);
            // 
            // buttonDeletePromos
            // 
            this.buttonDeletePromos.Location = new System.Drawing.Point(1148, 40);
            this.buttonDeletePromos.Name = "buttonDeletePromos";
            this.buttonDeletePromos.Size = new System.Drawing.Size(104, 23);
            this.buttonDeletePromos.TabIndex = 26;
            this.buttonDeletePromos.Text = "Delete promos";
            this.buttonDeletePromos.UseVisualStyleBackColor = true;
            this.buttonDeletePromos.Click += new System.EventHandler(this.buttonDeletePromos_Click);
            // 
            // textBoxPromoKeyword
            // 
            this.textBoxPromoKeyword.Location = new System.Drawing.Point(804, 41);
            this.textBoxPromoKeyword.Name = "textBoxPromoKeyword";
            this.textBoxPromoKeyword.Size = new System.Drawing.Size(174, 23);
            this.textBoxPromoKeyword.TabIndex = 27;
            // 
            // labelPromoKeyword
            // 
            this.labelPromoKeyword.AutoSize = true;
            this.labelPromoKeyword.Location = new System.Drawing.Point(704, 44);
            this.labelPromoKeyword.Name = "labelPromoKeyword";
            this.labelPromoKeyword.Size = new System.Drawing.Size(94, 15);
            this.labelPromoKeyword.TabIndex = 28;
            this.labelPromoKeyword.Text = "Promo keyword:";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(1037, 44);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(17, 15);
            this.labelPercent.TabIndex = 29;
            this.labelPercent.Text = "%";
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(984, 41);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(47, 23);
            this.textBoxPercent.TabIndex = 30;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 70);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(71, 23);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Location = new System.Drawing.Point(395, 12);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(52, 23);
            this.buttonSales.TabIndex = 32;
            this.buttonSales.Text = "Sales";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonAddSale
            // 
            this.buttonAddSale.Location = new System.Drawing.Point(757, 12);
            this.buttonAddSale.Name = "buttonAddSale";
            this.buttonAddSale.Size = new System.Drawing.Size(41, 23);
            this.buttonAddSale.TabIndex = 33;
            this.buttonAddSale.Text = "Sale";
            this.buttonAddSale.UseVisualStyleBackColor = true;
            this.buttonAddSale.Click += new System.EventHandler(this.buttonAddSale_Click);
            // 
            // buttonDeleteSale
            // 
            this.buttonDeleteSale.Location = new System.Drawing.Point(1118, 12);
            this.buttonDeleteSale.Name = "buttonDeleteSale";
            this.buttonDeleteSale.Size = new System.Drawing.Size(45, 23);
            this.buttonDeleteSale.TabIndex = 34;
            this.buttonDeleteSale.Text = "Sale";
            this.buttonDeleteSale.UseVisualStyleBackColor = true;
            this.buttonDeleteSale.Click += new System.EventHandler(this.buttonDeleteSale_Click);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(276, 70);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(126, 23);
            this.dateTimeFrom.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Add...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Top...";
            // 
            // textBoxTopNumber
            // 
            this.textBoxTopNumber.Location = new System.Drawing.Point(217, 70);
            this.textBoxTopNumber.Name = "textBoxTopNumber";
            this.textBoxTopNumber.Size = new System.Drawing.Size(53, 23);
            this.textBoxTopNumber.TabIndex = 38;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(408, 70);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(126, 23);
            this.dateTimeTo.TabIndex = 39;
            // 
            // buttonTopAuthor
            // 
            this.buttonTopAuthor.Location = new System.Drawing.Point(540, 70);
            this.buttonTopAuthor.Name = "buttonTopAuthor";
            this.buttonTopAuthor.Size = new System.Drawing.Size(58, 23);
            this.buttonTopAuthor.TabIndex = 40;
            this.buttonTopAuthor.Text = "Author";
            this.buttonTopAuthor.UseVisualStyleBackColor = true;
            this.buttonTopAuthor.Click += new System.EventHandler(this.buttonTopAuthor_Click);
            // 
            // buttonTopGenre
            // 
            this.buttonTopGenre.Location = new System.Drawing.Point(604, 70);
            this.buttonTopGenre.Name = "buttonTopGenre";
            this.buttonTopGenre.Size = new System.Drawing.Size(54, 23);
            this.buttonTopGenre.TabIndex = 41;
            this.buttonTopGenre.Text = "Genre";
            this.buttonTopGenre.UseVisualStyleBackColor = true;
            this.buttonTopGenre.Click += new System.EventHandler(this.buttonTopGenre_Click);
            // 
            // buttonTopPublisher
            // 
            this.buttonTopPublisher.Location = new System.Drawing.Point(664, 70);
            this.buttonTopPublisher.Name = "buttonTopPublisher";
            this.buttonTopPublisher.Size = new System.Drawing.Size(69, 23);
            this.buttonTopPublisher.TabIndex = 42;
            this.buttonTopPublisher.Text = "Publisher";
            this.buttonTopPublisher.UseVisualStyleBackColor = true;
            this.buttonTopPublisher.Click += new System.EventHandler(this.buttonTopPublisher_Click);
            // 
            // buttonTopBook
            // 
            this.buttonTopBook.Location = new System.Drawing.Point(739, 70);
            this.buttonTopBook.Name = "buttonTopBook";
            this.buttonTopBook.Size = new System.Drawing.Size(59, 23);
            this.buttonTopBook.TabIndex = 43;
            this.buttonTopBook.Text = "Book";
            this.buttonTopBook.UseVisualStyleBackColor = true;
            this.buttonTopBook.Click += new System.EventHandler(this.buttonTopBook_Click);
            // 
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonTopBook);
            this.Controls.Add(this.buttonTopPublisher);
            this.Controls.Add(this.buttonTopGenre);
            this.Controls.Add(this.buttonTopAuthor);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.textBoxTopNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.buttonDeleteSale);
            this.Controls.Add(this.buttonAddSale);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxPercent);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelPromoKeyword);
            this.Controls.Add(this.textBoxPromoKeyword);
            this.Controls.Add(this.buttonDeletePromos);
            this.Controls.Add(this.buttonAddPromo);
            this.Controls.Add(this.buttonBooks2);
            this.Controls.Add(this.textBoxDeletionId);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonDeletePublisher);
            this.Controls.Add(this.buttonDeleteAuthor);
            this.Controls.Add(this.buttonDeleteGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBoxAddName);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.buttonAddPublisher);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.radioButtonKeyword);
            this.Controls.Add(this.radioButtonId);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.labelGet);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonPublishers);
            this.Controls.Add(this.buttonGenres);
            this.Controls.Add(this.buttonAuthors);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "BookStoreForm";
            this.Text = "Book Store";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAuthors;
        private System.Windows.Forms.Button buttonGenres;
        private System.Windows.Forms.Button buttonPublishers;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelGet;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonKeyword;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.Button buttonDeletePublisher;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.TextBox textBoxDeletionId;
        private System.Windows.Forms.Button buttonBooks2;
        private System.Windows.Forms.Button buttonAddPromo;
        private System.Windows.Forms.Button buttonDeletePromos;
        private System.Windows.Forms.TextBox textBoxPromoKeyword;
        private System.Windows.Forms.Label labelPromoKeyword;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.TextBox textBoxPercent;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonAddSale;
        private System.Windows.Forms.Button buttonDeleteSale;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTopNumber;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Button buttonTopAuthor;
        private System.Windows.Forms.Button buttonTopGenre;
        private System.Windows.Forms.Button buttonTopPublisher;
        private System.Windows.Forms.Button buttonTopBook;
    }
}
