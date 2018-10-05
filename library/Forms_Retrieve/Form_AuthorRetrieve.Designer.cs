namespace Library.Forms_Retrieve
{
    partial class Form_AuthorRetrieve
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
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Autor_id = new System.Windows.Forms.TextBox();
            this.Text_AuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Country = new System.Windows.Forms.ComboBox();
            this.Box_Language = new System.Windows.Forms.ComboBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Button_RetrieveAll = new System.Windows.Forms.Button();
            this.Table_Authors = new System.Windows.Forms.DataGridView();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Detail = new System.Windows.Forms.Button();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.Label_AuthorCount = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // text_autor_id
            // 
            this.Text_Autor_id.Location = new System.Drawing.Point(16, 30);
            this.Text_Autor_id.Name = "text_autor_id";
            this.Text_Autor_id.Size = new System.Drawing.Size(50, 20);
            this.Text_Autor_id.TabIndex = 2;
            // 
            // text_authorName
            // 
            this.Text_AuthorName.Location = new System.Drawing.Point(72, 30);
            this.Text_AuthorName.Name = "text_authorName";
            this.Text_AuthorName.Size = new System.Drawing.Size(230, 20);
            this.Text_AuthorName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // box_country
            // 
            this.Box_Country.FormattingEnabled = true;
            this.Box_Country.Location = new System.Drawing.Point(16, 57);
            this.Box_Country.Name = "box_country";
            this.Box_Country.Size = new System.Drawing.Size(139, 21);
            this.Box_Country.TabIndex = 5;
            this.Box_Country.Text = "Países";
            // 
            // box_language
            // 
            this.Box_Language.FormattingEnabled = true;
            this.Box_Language.Location = new System.Drawing.Point(163, 57);
            this.Box_Language.Name = "box_language";
            this.Box_Language.Size = new System.Drawing.Size(139, 21);
            this.Box_Language.TabIndex = 6;
            this.Box_Language.Text = "Idiomas";
            // 
            // button_search
            // 
            this.Button_Search.Location = new System.Drawing.Point(416, 30);
            this.Button_Search.Name = "button_search";
            this.Button_Search.Size = new System.Drawing.Size(129, 23);
            this.Button_Search.TabIndex = 7;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // button_retrieveAll
            // 
            this.Button_RetrieveAll.Location = new System.Drawing.Point(314, 55);
            this.Button_RetrieveAll.Name = "button_retrieveAll";
            this.Button_RetrieveAll.Size = new System.Drawing.Size(231, 23);
            this.Button_RetrieveAll.TabIndex = 8;
            this.Button_RetrieveAll.Text = "Retrieve All";
            this.Button_RetrieveAll.UseVisualStyleBackColor = true;
            this.Button_RetrieveAll.Click += new System.EventHandler(this.Button_ListAllAuthorsClick);
            // 
            // table_authors
            // 
            this.Table_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name,
            this.Column_Country,
            this.Column_Language});
            this.Table_Authors.Location = new System.Drawing.Point(16, 84);
            this.Table_Authors.Name = "table_authors";
            this.Table_Authors.Size = new System.Drawing.Size(529, 307);
            this.Table_Authors.TabIndex = 9;
            // 
            // column_id
            // 
            this.Column_Id.HeaderText = "Id";
            this.Column_Id.Name = "column_id";
            this.Column_Id.Width = 35;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.Width = 150;
            // 
            // Column_Country
            // 
            this.Column_Country.HeaderText = "Country";
            this.Column_Country.Name = "Column_Country";
            this.Column_Country.Width = 150;
            // 
            // Column_Language
            // 
            this.Column_Language.HeaderText = "Language";
            this.Column_Language.Name = "Column_Language";
            this.Column_Language.Width = 150;
            // 
            // button_cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(16, 397);
            this.Button_Cancel.Name = "button_cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(121, 23);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // button_detail
            // 
            this.Button_Detail.Enabled = false;
            this.Button_Detail.Location = new System.Drawing.Point(279, 398);
            this.Button_Detail.Name = "button_detail";
            this.Button_Detail.Size = new System.Drawing.Size(130, 23);
            this.Button_Detail.TabIndex = 11;
            this.Button_Detail.Text = "See Detail";
            this.Button_Detail.UseVisualStyleBackColor = true;
            this.Button_Detail.Click += new System.EventHandler(this.Button_detail_Click);
            // 
            // button_clean
            // 
            this.Button_Clean.Location = new System.Drawing.Point(143, 397);
            this.Button_Clean.Name = "button_clean";
            this.Button_Clean.Size = new System.Drawing.Size(130, 23);
            this.Button_Clean.TabIndex = 12;
            this.Button_Clean.Text = "Clean";
            this.Button_Clean.UseVisualStyleBackColor = true;
            this.Button_Clean.Click += new System.EventHandler(this.Button_clean_Click);
            // 
            // label_authorCount
            // 
            this.Label_AuthorCount.AutoSize = true;
            this.Label_AuthorCount.Location = new System.Drawing.Point(19, 424);
            this.Label_AuthorCount.Name = "label_authorCount";
            this.Label_AuthorCount.Size = new System.Drawing.Size(10, 13);
            this.Label_AuthorCount.TabIndex = 28;
            this.Label_AuthorCount.Text = "-";
            // 
            // button_delete
            // 
            this.Button_Delete.Enabled = false;
            this.Button_Delete.Location = new System.Drawing.Point(415, 398);
            this.Button_Delete.Name = "button_delete";
            this.Button_Delete.Size = new System.Drawing.Size(130, 23);
            this.Button_Delete.TabIndex = 30;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            // 
            // Form_AuthorRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 444);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Label_AuthorCount);
            this.Controls.Add(this.Button_Clean);
            this.Controls.Add(this.Button_Detail);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Table_Authors);
            this.Controls.Add(this.Button_RetrieveAll);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.Box_Language);
            this.Controls.Add(this.Box_Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_AuthorName);
            this.Controls.Add(this.Text_Autor_id);
            this.Controls.Add(this.label1);
            this.Name = "Form_AuthorRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Author";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AuthorRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_AuthorRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Autor_id;
        private System.Windows.Forms.TextBox Text_AuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Box_Country;
        private System.Windows.Forms.ComboBox Box_Language;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Button_RetrieveAll;
        private System.Windows.Forms.DataGridView Table_Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Language;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Detail;
        private System.Windows.Forms.Button Button_Clean;
        private System.Windows.Forms.Label Label_AuthorCount;
        private System.Windows.Forms.Button Button_Delete;
    }
}