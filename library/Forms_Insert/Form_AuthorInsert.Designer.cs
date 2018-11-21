namespace Library.Forms_Insert
{
    partial class Form_AuthorInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AuthorInsert));
            this.Picture_Author = new System.Windows.Forms.PictureBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Text_AuthorName = new System.Windows.Forms.TextBox();
            this.Box_Country = new System.Windows.Forms.ComboBox();
            this.Text_AuthorAbout = new System.Windows.Forms.RichTextBox();
            this.Button_Transaction = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Box_Category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Author)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Author
            // 
            this.Picture_Author.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture_Author.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Author.Image")));
            this.Picture_Author.InitialImage = null;
            this.Picture_Author.Location = new System.Drawing.Point(12, 12);
            this.Picture_Author.Name = "Picture_Author";
            this.Picture_Author.Size = new System.Drawing.Size(170, 230);
            this.Picture_Author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Author.TabIndex = 1;
            this.Picture_Author.TabStop = false;
            this.Picture_Author.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picture_author_MouseClick);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(189, 13);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(35, 13);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Nome";
            // 
            // Text_AuthorName
            // 
            this.Text_AuthorName.Location = new System.Drawing.Point(192, 29);
            this.Text_AuthorName.Name = "Text_AuthorName";
            this.Text_AuthorName.Size = new System.Drawing.Size(300, 20);
            this.Text_AuthorName.TabIndex = 4;
            // 
            // Box_Country
            // 
            this.Box_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Country.FormattingEnabled = true;
            this.Box_Country.Location = new System.Drawing.Point(192, 55);
            this.Box_Country.Name = "Box_Country";
            this.Box_Country.Size = new System.Drawing.Size(132, 21);
            this.Box_Country.TabIndex = 5;
            this.Box_Country.SelectionChangeCommitted += new System.EventHandler(this.Box_Country_SelectionChangeCommitted);
            // 
            // Text_AuthorAbout
            // 
            this.Text_AuthorAbout.Location = new System.Drawing.Point(192, 82);
            this.Text_AuthorAbout.Name = "Text_AuthorAbout";
            this.Text_AuthorAbout.Size = new System.Drawing.Size(301, 131);
            this.Text_AuthorAbout.TabIndex = 8;
            this.Text_AuthorAbout.Text = "";
            // 
            // Button_Transaction
            // 
            this.Button_Transaction.Location = new System.Drawing.Point(347, 219);
            this.Button_Transaction.Name = "Button_Transaction";
            this.Button_Transaction.Size = new System.Drawing.Size(149, 23);
            this.Button_Transaction.TabIndex = 10;
            this.Button_Transaction.Text = "Salvar";
            this.Button_Transaction.UseVisualStyleBackColor = true;
            this.Button_Transaction.Click += new System.EventHandler(this.Button_Transaction_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(192, 219);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(149, 23);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "Voltar";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Box_Category
            // 
            this.Box_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Category.FormattingEnabled = true;
            this.Box_Category.Location = new System.Drawing.Point(330, 55);
            this.Box_Category.Name = "Box_Category";
            this.Box_Category.Size = new System.Drawing.Size(110, 21);
            this.Box_Category.TabIndex = 11;
            // 
            // Form_AuthorInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 251);
            this.Controls.Add(this.Box_Category);
            this.Controls.Add(this.Button_Transaction);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Text_AuthorAbout);
            this.Controls.Add(this.Box_Country);
            this.Controls.Add(this.Text_AuthorName);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Picture_Author);
            this.Name = "Form_AuthorInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Autor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AuthorIns_FormClosing);
            this.Load += new System.EventHandler(this.Form_AuthorInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture_Author;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox Text_AuthorName;
        private System.Windows.Forms.ComboBox Box_Country;
        private System.Windows.Forms.RichTextBox Text_AuthorAbout;
        private System.Windows.Forms.Button Button_Transaction;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.ComboBox Box_Category;
    }
}