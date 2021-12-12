namespace BookStore.View
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAuthorId = new System.Windows.Forms.Label();
            this.textBoxAuthorId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPublisherId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGenreId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPrevBook = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(66, 6);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(127, 23);
            this.textBoxTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pages";
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(66, 35);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(127, 23);
            this.textBoxPages.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(66, 122);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(127, 23);
            this.textBoxPrice.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(66, 93);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(127, 23);
            this.textBoxCost.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // labelAuthorId
            // 
            this.labelAuthorId.AutoSize = true;
            this.labelAuthorId.Location = new System.Drawing.Point(12, 183);
            this.labelAuthorId.Name = "labelAuthorId";
            this.labelAuthorId.Size = new System.Drawing.Size(66, 15);
            this.labelAuthorId.TabIndex = 15;
            this.labelAuthorId.Text = "Author\'s ID";
            // 
            // textBoxAuthorId
            // 
            this.textBoxAuthorId.Location = new System.Drawing.Point(95, 180);
            this.textBoxAuthorId.Name = "textBoxAuthorId";
            this.textBoxAuthorId.Size = new System.Drawing.Size(98, 23);
            this.textBoxAuthorId.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Publisher\'s ID";
            // 
            // textBoxPublisherId
            // 
            this.textBoxPublisherId.Location = new System.Drawing.Point(95, 209);
            this.textBoxPublisherId.Name = "textBoxPublisherId";
            this.textBoxPublisherId.Size = new System.Drawing.Size(98, 23);
            this.textBoxPublisherId.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Genre ID";
            // 
            // textBoxGenreId
            // 
            this.textBoxGenreId.Location = new System.Drawing.Point(95, 238);
            this.textBoxGenreId.Name = "textBoxGenreId";
            this.textBoxGenreId.Size = new System.Drawing.Size(98, 23);
            this.textBoxGenreId.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Prev. book ID";
            // 
            // textBoxPrevBook
            // 
            this.textBoxPrevBook.Location = new System.Drawing.Point(95, 151);
            this.textBoxPrevBook.Name = "textBoxPrevBook";
            this.textBoxPrevBook.Size = new System.Drawing.Size(98, 23);
            this.textBoxPrevBook.TabIndex = 22;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 291);
            this.Controls.Add(this.textBoxPrevBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGenreId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPublisherId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthorId);
            this.Controls.Add(this.labelAuthorId);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.MaximumSize = new System.Drawing.Size(220, 330);
            this.MinimumSize = new System.Drawing.Size(220, 330);
            this.Name = "AddBook";
            this.Text = "New book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAuthorId;
        private System.Windows.Forms.TextBox textBoxAuthorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPublisherId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGenreId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPrevBook;
    }
}