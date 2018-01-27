namespace library.Forms_Retrieve
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
            this.text_autor_id = new System.Windows.Forms.TextBox();
            this.text_authorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_country = new System.Windows.Forms.ComboBox();
            this.box_language = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_retrieveAll = new System.Windows.Forms.Button();
            this.table_authors = new System.Windows.Forms.DataGridView();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_detail = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label_authorCount = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_authors)).BeginInit();
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
            this.text_autor_id.Location = new System.Drawing.Point(16, 30);
            this.text_autor_id.Name = "text_autor_id";
            this.text_autor_id.Size = new System.Drawing.Size(50, 20);
            this.text_autor_id.TabIndex = 2;
            // 
            // text_authorName
            // 
            this.text_authorName.Location = new System.Drawing.Point(72, 30);
            this.text_authorName.Name = "text_authorName";
            this.text_authorName.Size = new System.Drawing.Size(230, 20);
            this.text_authorName.TabIndex = 3;
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
            this.box_country.FormattingEnabled = true;
            this.box_country.Location = new System.Drawing.Point(16, 57);
            this.box_country.Name = "box_country";
            this.box_country.Size = new System.Drawing.Size(139, 21);
            this.box_country.TabIndex = 5;
            this.box_country.Text = "Países";
            // 
            // box_language
            // 
            this.box_language.FormattingEnabled = true;
            this.box_language.Location = new System.Drawing.Point(163, 57);
            this.box_language.Name = "box_language";
            this.box_language.Size = new System.Drawing.Size(139, 21);
            this.box_language.TabIndex = 6;
            this.box_language.Text = "Idiomas";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(416, 30);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(129, 23);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_retrieveAll
            // 
            this.button_retrieveAll.Location = new System.Drawing.Point(314, 55);
            this.button_retrieveAll.Name = "button_retrieveAll";
            this.button_retrieveAll.Size = new System.Drawing.Size(231, 23);
            this.button_retrieveAll.TabIndex = 8;
            this.button_retrieveAll.Text = "Retrieve All";
            this.button_retrieveAll.UseVisualStyleBackColor = true;
            this.button_retrieveAll.Click += new System.EventHandler(this.button_retrieveAll_Click);
            // 
            // table_authors
            // 
            this.table_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.Column_Name,
            this.Column_Country,
            this.Column_Language});
            this.table_authors.Location = new System.Drawing.Point(16, 84);
            this.table_authors.Name = "table_authors";
            this.table_authors.Size = new System.Drawing.Size(529, 307);
            this.table_authors.TabIndex = 9;
            // 
            // column_id
            // 
            this.column_id.HeaderText = "Id";
            this.column_id.Name = "column_id";
            this.column_id.Width = 35;
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
            this.button_cancel.Location = new System.Drawing.Point(16, 397);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(121, 23);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_detail
            // 
            this.button_detail.Enabled = false;
            this.button_detail.Location = new System.Drawing.Point(279, 398);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(130, 23);
            this.button_detail.TabIndex = 11;
            this.button_detail.Text = "See Detail";
            this.button_detail.UseVisualStyleBackColor = true;
            this.button_detail.Click += new System.EventHandler(this.button_detail_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(143, 397);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(130, 23);
            this.button_clean.TabIndex = 12;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label_authorCount
            // 
            this.label_authorCount.AutoSize = true;
            this.label_authorCount.Location = new System.Drawing.Point(19, 424);
            this.label_authorCount.Name = "label_authorCount";
            this.label_authorCount.Size = new System.Drawing.Size(10, 13);
            this.label_authorCount.TabIndex = 28;
            this.label_authorCount.Text = "-";
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(415, 398);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(130, 23);
            this.button_delete.TabIndex = 30;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Form_AuthorRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 444);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_authorCount);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.table_authors);
            this.Controls.Add(this.button_retrieveAll);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.box_language);
            this.Controls.Add(this.box_country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_authorName);
            this.Controls.Add(this.text_autor_id);
            this.Controls.Add(this.label1);
            this.Name = "Form_AuthorRetrieve";
            this.Text = "Search Author";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AuthorRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_AuthorRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_autor_id;
        private System.Windows.Forms.TextBox text_authorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_country;
        private System.Windows.Forms.ComboBox box_language;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_retrieveAll;
        private System.Windows.Forms.DataGridView table_authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Language;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_detail;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label_authorCount;
        private System.Windows.Forms.Button button_delete;
    }
}