namespace library.Forms_Retrieve
{
    partial class Form_GenreRetrieve
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
            this.button_retrieveAll = new System.Windows.Forms.Button();
            this.table_genres = new System.Windows.Forms.DataGridView();
            this.Column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_genresCount = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_genres)).BeginInit();
            this.SuspendLayout();
            // 
            // button_retrieveAll
            // 
            this.button_retrieveAll.Location = new System.Drawing.Point(258, 60);
            this.button_retrieveAll.Name = "button_retrieveAll";
            this.button_retrieveAll.Size = new System.Drawing.Size(82, 20);
            this.button_retrieveAll.TabIndex = 1;
            this.button_retrieveAll.Text = "Retrieve All";
            this.button_retrieveAll.UseVisualStyleBackColor = true;
            this.button_retrieveAll.Click += new System.EventHandler(this.button_retrieveAll_Click);
            // 
            // table_genres
            // 
            this.table_genres.AllowUserToResizeColumns = false;
            this.table_genres.AllowUserToResizeRows = false;
            this.table_genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_genres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Id,
            this.Column_Name});
            this.table_genres.Location = new System.Drawing.Point(12, 86);
            this.table_genres.Name = "table_genres";
            this.table_genres.Size = new System.Drawing.Size(328, 219);
            this.table_genres.TabIndex = 2;
            this.table_genres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_languages_CellContentClick);
            // 
            // Column_Id
            // 
            this.Column_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_Id.HeaderText = "Id";
            this.Column_Id.Name = "Column_Id";
            this.Column_Id.ReadOnly = true;
            this.Column_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column_Id.Width = 35;
            // 
            // Column_Name
            // 
            this.Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_Name.HeaderText = "Genre Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // text_Id
            // 
            this.text_Id.Location = new System.Drawing.Point(15, 29);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(80, 20);
            this.text_Id.TabIndex = 4;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(102, 29);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(150, 20);
            this.text_Name.TabIndex = 5;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(258, 29);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(82, 20);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(102, 60);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(67, 20);
            this.button_clean.TabIndex = 7;
            this.button_clean.Text = "Cleam Selection";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(15, 60);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 20);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language Name";
            // 
            // label_genresCount
            // 
            this.label_genresCount.AutoSize = true;
            this.label_genresCount.Location = new System.Drawing.Point(12, 313);
            this.label_genresCount.Name = "label_genresCount";
            this.label_genresCount.Size = new System.Drawing.Size(10, 13);
            this.label_genresCount.TabIndex = 10;
            this.label_genresCount.Text = "-";
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(175, 60);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(77, 20);
            this.button_edit.TabIndex = 11;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // Form_GenreRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 335);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_genresCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_genres);
            this.Controls.Add(this.button_retrieveAll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GenreRetrieve";
            this.Text = "Search Genres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GenreRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_GenreRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_genres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_retrieveAll;
        private System.Windows.Forms.DataGridView table_genres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_genresCount;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
    }
}