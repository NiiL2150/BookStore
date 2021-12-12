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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(55, 12);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(62, 23);
            this.buttonAuthors.TabIndex = 1;
            this.buttonAuthors.Text = "Authors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonGenres
            // 
            this.buttonGenres.Location = new System.Drawing.Point(123, 12);
            this.buttonGenres.Name = "buttonGenres";
            this.buttonGenres.Size = new System.Drawing.Size(57, 23);
            this.buttonGenres.TabIndex = 2;
            this.buttonGenres.Text = "Genres";
            this.buttonGenres.UseVisualStyleBackColor = true;
            this.buttonGenres.Click += new System.EventHandler(this.buttonGenres_Click);
            // 
            // buttonPublishers
            // 
            this.buttonPublishers.Location = new System.Drawing.Point(186, 12);
            this.buttonPublishers.Name = "buttonPublishers";
            this.buttonPublishers.Size = new System.Drawing.Size(88, 23);
            this.buttonPublishers.TabIndex = 3;
            this.buttonPublishers.Text = "Publishers";
            this.buttonPublishers.UseVisualStyleBackColor = true;
            this.buttonPublishers.Click += new System.EventHandler(this.buttonPublishers_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(280, 12);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(66, 23);
            this.buttonBooks.TabIndex = 4;
            this.buttonBooks.Text = "Books";
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
            this.textBoxKeyword.Size = new System.Drawing.Size(105, 23);
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
            this.buttonAddGenre.Location = new System.Drawing.Point(428, 12);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGenre.TabIndex = 12;
            this.buttonAddGenre.Text = "Add genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Location = new System.Drawing.Point(509, 12);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(101, 23);
            this.buttonAddPublisher.TabIndex = 13;
            this.buttonAddPublisher.Text = "Add publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(616, 12);
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
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}
