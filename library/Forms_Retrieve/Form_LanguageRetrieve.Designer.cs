namespace Library.Forms_Retrieve
{
    partial class Form_LanguageRetrieve
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
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_retrieveAll = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.table_languages = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_languageCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_languages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(16, 30);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(80, 20);
            this.text_id.TabIndex = 1;
            // 
            // text_authorName
            // 
            this.text_name.Location = new System.Drawing.Point(103, 30);
            this.text_name.Name = "text_authorName";
            this.text_name.Size = new System.Drawing.Size(150, 20);
            this.text_name.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(16, 56);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 20);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(176, 56);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(77, 20);
            this.button_edit.TabIndex = 14;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(103, 56);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(67, 20);
            this.button_clean.TabIndex = 13;
            this.button_clean.Text = "Cleam Selection";
            this.button_clean.UseVisualStyleBackColor = true;
            // 
            // button_retrieveAll
            // 
            this.button_retrieveAll.Location = new System.Drawing.Point(259, 56);
            this.button_retrieveAll.Name = "button_retrieveAll";
            this.button_retrieveAll.Size = new System.Drawing.Size(88, 20);
            this.button_retrieveAll.TabIndex = 12;
            this.button_retrieveAll.Text = "Retrieve All";
            this.button_retrieveAll.UseVisualStyleBackColor = true;
            this.button_retrieveAll.Click += new System.EventHandler(this.button_retrieveAll_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(259, 30);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(88, 20);
            this.button_search.TabIndex = 15;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // table_languages
            // 
            this.table_languages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_languages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Language,
            this.Show});
            this.table_languages.Location = new System.Drawing.Point(16, 82);
            this.table_languages.Name = "table_languages";
            this.table_languages.Size = new System.Drawing.Size(331, 254);
            this.table_languages.TabIndex = 16;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 35;
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            this.Language.Width = 200;
            // 
            // Show
            // 
            this.Show.HeaderText = "Show";
            this.Show.Name = "Show";
            this.Show.Width = 50;
            // 
            // label_languageCount
            // 
            this.label_languageCount.AutoSize = true;
            this.label_languageCount.Location = new System.Drawing.Point(19, 339);
            this.label_languageCount.Name = "label_languageCount";
            this.label_languageCount.Size = new System.Drawing.Size(10, 13);
            this.label_languageCount.TabIndex = 17;
            this.label_languageCount.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Language Name";
            // 
            // Form_LanguageRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(359, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_languageCount);
            this.Controls.Add(this.table_languages);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_retrieveAll);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_LanguageRetrieve";
            this.Text = "Language Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_LanguageRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_LanguageRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_languages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_retrieveAll;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView table_languages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Show;
        private System.Windows.Forms.Label label_languageCount;
        private System.Windows.Forms.Label label2;
    }
}