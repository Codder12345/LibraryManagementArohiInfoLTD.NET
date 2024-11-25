namespace WindowsLibraryMnagementproject
{
    partial class AddBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBook = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.txtPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublication = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.BookQuantity = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.PublicationDate = new System.Windows.Forms.Label();
            this.BookPublication = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.AddBook);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 77);
            this.panel1.TabIndex = 2;
            // 
            // AddBook
            // 
            this.AddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBook.AutoSize = true;
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook.Location = new System.Drawing.Point(384, 30);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(69, 18);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "AddBook";
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::WindowsLibraryMnagementproject.Properties.Resources.newbook1;
            this.pictureBox2.Location = new System.Drawing.Point(256, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.txtPublicationDate);
            this.panel2.Controls.Add(this.txtBookQuantity);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.txtPublication);
            this.panel2.Controls.Add(this.txtBookPrice);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.BookQuantity);
            this.panel2.Controls.Add(this.BookPrice);
            this.panel2.Controls.Add(this.PublicationDate);
            this.panel2.Controls.Add(this.BookPublication);
            this.panel2.Controls.Add(this.AuthorName);
            this.panel2.Controls.Add(this.BookName);
            this.panel2.Location = new System.Drawing.Point(257, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 348);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.LightSalmon;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(293, 275);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(83, 37);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightSalmon;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(170, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 37);
            this.save.TabIndex = 12;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // txtPublicationDate
            // 
            this.txtPublicationDate.Location = new System.Drawing.Point(170, 140);
            this.txtPublicationDate.Name = "txtPublicationDate";
            this.txtPublicationDate.Size = new System.Drawing.Size(228, 20);
            this.txtPublicationDate.TabIndex = 11;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(170, 224);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(228, 20);
            this.txtBookQuantity.TabIndex = 10;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(170, 67);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(228, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtPublication
            // 
            this.txtPublication.Location = new System.Drawing.Point(170, 103);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.Size = new System.Drawing.Size(228, 20);
            this.txtPublication.TabIndex = 8;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(170, 181);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(228, 20);
            this.txtBookPrice.TabIndex = 7;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(170, 34);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(228, 20);
            this.txtBookName.TabIndex = 6;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // BookQuantity
            // 
            this.BookQuantity.AutoSize = true;
            this.BookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookQuantity.Location = new System.Drawing.Point(28, 227);
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.Size = new System.Drawing.Size(83, 13);
            this.BookQuantity.TabIndex = 5;
            this.BookQuantity.Text = "BookQuantity";
            this.BookQuantity.Click += new System.EventHandler(this.BookQuantity_Click);
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPrice.Location = new System.Drawing.Point(28, 188);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(65, 13);
            this.BookPrice.TabIndex = 4;
            this.BookPrice.Text = "BookPrice";
            // 
            // PublicationDate
            // 
            this.PublicationDate.AutoSize = true;
            this.PublicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicationDate.Location = new System.Drawing.Point(25, 146);
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.Size = new System.Drawing.Size(126, 13);
            this.PublicationDate.TabIndex = 3;
            this.PublicationDate.Text = "BookPublicationDate";
            // 
            // BookPublication
            // 
            this.BookPublication.AutoSize = true;
            this.BookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookPublication.Location = new System.Drawing.Point(25, 110);
            this.BookPublication.Name = "BookPublication";
            this.BookPublication.Size = new System.Drawing.Size(99, 13);
            this.BookPublication.TabIndex = 2;
            this.BookPublication.Text = "BookPublication";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.Location = new System.Drawing.Point(25, 70);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(113, 13);
            this.AuthorName.TabIndex = 1;
            this.AuthorName.Text = "Book Author Name";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(28, 37);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(68, 13);
            this.BookName.TabIndex = 0;
            this.BookName.Text = "BookName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::WindowsLibraryMnagementproject.Properties.Resources.motivat;
            this.pictureBox1.Location = new System.Drawing.Point(1, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooks";
            this.Load += new System.EventHandler(this.AddBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label AddBook;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label BookQuantity;
        private System.Windows.Forms.Label BookPrice;
        private System.Windows.Forms.Label PublicationDate;
        private System.Windows.Forms.Label BookPublication;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.DateTimePicker txtPublicationDate;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublication;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Cancel;
    }
}