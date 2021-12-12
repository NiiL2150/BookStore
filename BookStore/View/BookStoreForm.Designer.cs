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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 611);
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
            this.textBoxKeyword.Size = new System.Drawing.Size(148, 23);
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
            this.buttonAddGenre.Location = new System.Drawing.Point(516, 12);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGenre.TabIndex = 12;
            this.buttonAddGenre.Text = "Add genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Location = new System.Drawing.Point(597, 12);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(101, 23);
            this.buttonAddPublisher.TabIndex = 13;
            this.buttonAddPublisher.Text = "Add publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(428, 12);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(82, 23);
            this.buttonAddAuthor.TabIndex = 14;
            this.buttonAddAuthor.Text = "Add author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(428, 41);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(270, 23);
            this.textBoxAddName.TabIndex = 15;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(704, 12);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(84, 23);
            this.buttonAddBook.TabIndex = 16;
            this.buttonAddBook.Text = "Add book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Delete: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1155, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID:";
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.Location = new System.Drawing.Point(954, 12);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
            this.buttonDeleteGenre.Size = new System.Drawing.Size(58, 23);
            this.buttonDeleteGenre.TabIndex = 19;
            this.buttonDeleteGenre.Text = "Genre";
            this.buttonDeleteGenre.UseVisualStyleBackColor = true;
            this.buttonDeleteGenre.Click += new System.EventHandler(this.buttonDeleteGenre_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(890, 12);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(58, 23);
            this.buttonDeleteAuthor.TabIndex = 20;
            this.buttonDeleteAuthor.Text = "Author";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonDeletePublisher
            // 
            this.buttonDeletePublisher.Location = new System.Drawing.Point(1018, 12);
            this.buttonDeletePublisher.Name = "buttonDeletePublisher";
            this.buttonDeletePublisher.Size = new System.Drawing.Size(70, 23);
            this.buttonDeletePublisher.TabIndex = 21;
            this.buttonDeletePublisher.Text = "Publisher";
            this.buttonDeletePublisher.UseVisualStyleBackColor = true;
            this.buttonDeletePublisher.Click += new System.EventHandler(this.buttonDeletePublisher_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(1094, 12);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(55, 23);
            this.buttonDeleteBook.TabIndex = 22;
            this.buttonDeleteBook.Text = "Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // textBoxDeletionId
            // 
            this.textBoxDeletionId.Location = new System.Drawing.Point(1182, 13);
            this.textBoxDeletionId.Name = "textBoxDeletionId";
            this.textBoxDeletionId.Size = new System.Drawing.Size(70, 23);
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
            this.buttonAddPromo.Location = new System.Drawing.Point(1094, 40);
            this.buttonAddPromo.Name = "buttonAddPromo";
            this.buttonAddPromo.Size = new System.Drawing.Size(84, 23);
            this.buttonAddPromo.TabIndex = 25;
            this.buttonAddPromo.Text = "Add promo";
            this.buttonAddPromo.UseVisualStyleBackColor = true;
            this.buttonAddPromo.Click += new System.EventHandler(this.buttonAddPromo_Click);
            // 
            // buttonDeletePromos
            // 
            this.buttonDeletePromos.Location = new System.Drawing.Point(1182, 40);
            this.buttonDeletePromos.Name = "buttonDeletePromos";
            this.buttonDeletePromos.Size = new System.Drawing.Size(70, 23);
            this.buttonDeletePromos.TabIndex = 26;
            this.buttonDeletePromos.Text = "Promos";
            this.buttonDeletePromos.UseVisualStyleBackColor = true;
            // 
            // textBoxPromoKeyword
            // 
            this.textBoxPromoKeyword.Location = new System.Drawing.Point(838, 41);
            this.textBoxPromoKeyword.Name = "textBoxPromoKeyword";
            this.textBoxPromoKeyword.Size = new System.Drawing.Size(174, 23);
            this.textBoxPromoKeyword.TabIndex = 27;
            // 
            // labelPromoKeyword
            // 
            this.labelPromoKeyword.AutoSize = true;
            this.labelPromoKeyword.Location = new System.Drawing.Point(738, 44);
            this.labelPromoKeyword.Name = "labelPromoKeyword";
            this.labelPromoKeyword.Size = new System.Drawing.Size(94, 15);
            this.labelPromoKeyword.TabIndex = 28;
            this.labelPromoKeyword.Text = "Promo keyword:";
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(1071, 44);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(17, 15);
            this.labelPercent.TabIndex = 29;
            this.labelPercent.Text = "%";
            // 
            // textBoxPercent
            // 
            this.textBoxPercent.Location = new System.Drawing.Point(1018, 41);
            this.textBoxPercent.Name = "textBoxPercent";
            this.textBoxPercent.Size = new System.Drawing.Size(47, 23);
            this.textBoxPercent.TabIndex = 30;
            // 
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}
