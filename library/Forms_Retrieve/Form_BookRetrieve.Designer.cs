namespace Library.Forms_Retrieve
{
    partial class Form_BookRetrieve
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
            this.table_books = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SubTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CoverPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table_books)).BeginInit();
            this.SuspendLayout();
            // 
            // table_books
            // 
            this.table_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Author,
            this.Column_Title,
            this.Column_SubTitle,
            this.Column_Serie,
            this.Column_Volume,
            this.Column_Pages,
            this.Column_ISBN,
            this.Column_Publisher,
            this.Column_Format,
            this.Column_CoverPrice});
            this.table_books.Location = new System.Drawing.Point(12, 64);
            this.table_books.Name = "table_books";
            this.table_books.Size = new System.Drawing.Size(1222, 491);
            this.table_books.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1159, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column_Author
            // 
            this.Column_Author.HeaderText = "Author";
            this.Column_Author.Name = "Column_Author";
            this.Column_Author.Width = 150;
            // 
            // Column_Title
            // 
            this.Column_Title.HeaderText = "Title";
            this.Column_Title.Name = "Column_Title";
            this.Column_Title.Width = 200;
            // 
            // Column_SubTitle
            // 
            this.Column_SubTitle.HeaderText = "Sub Title";
            this.Column_SubTitle.Name = "Column_SubTitle";
            this.Column_SubTitle.Width = 200;
            // 
            // Column_Serie
            // 
            this.Column_Serie.HeaderText = "Serie";
            this.Column_Serie.Name = "Column_Serie";
            this.Column_Serie.Width = 200;
            // 
            // Column_Volume
            // 
            this.Column_Volume.HeaderText = "Vol";
            this.Column_Volume.Name = "Column_Volume";
            this.Column_Volume.Width = 40;
            // 
            // Column_Pages
            // 
            this.Column_Pages.HeaderText = "Pages";
            this.Column_Pages.Name = "Column_Pages";
            this.Column_Pages.Width = 40;
            // 
            // Column_ISBN
            // 
            this.Column_ISBN.HeaderText = "ISBN";
            this.Column_ISBN.Name = "Column_ISBN";
            // 
            // Column_Publisher
            // 
            this.Column_Publisher.HeaderText = "Publisher";
            this.Column_Publisher.Name = "Column_Publisher";
            this.Column_Publisher.Width = 150;
            // 
            // Column_Format
            // 
            this.Column_Format.HeaderText = "Format";
            this.Column_Format.Name = "Column_Format";
            this.Column_Format.Width = 50;
            // 
            // Column_CoverPrice
            // 
            this.Column_CoverPrice.HeaderText = "Cover Price";
            this.Column_CoverPrice.Name = "Column_CoverPrice";
            this.Column_CoverPrice.Width = 40;
            // 
            // Form_BookRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table_books);
            this.Name = "Form_BookRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BookRetrieve";
            ((System.ComponentModel.ISupportInitialize)(this.table_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_books;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SubTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CoverPrice;
    }
}