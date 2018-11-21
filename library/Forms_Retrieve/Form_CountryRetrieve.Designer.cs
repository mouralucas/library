namespace Library.Forms_Retrieve
{
    partial class Form_CountryRetrieve
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
            this.Table_Countries = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_search = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_retrieveAll = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_countriesCount = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Countries)).BeginInit();
            this.SuspendLayout();
            // 
            // table_countries
            // 
            this.Table_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Countries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Country,
            this.Show});
            this.Table_Countries.Location = new System.Drawing.Point(12, 77);
            this.Table_Countries.Name = "table_countries";
            this.Table_Countries.Size = new System.Drawing.Size(331, 254);
            this.Table_Countries.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 35;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Width = 200;
            // 
            // Show
            // 
            this.Show.HeaderText = "Show";
            this.Show.Name = "Show";
            this.Show.Width = 50;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(255, 25);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(88, 20);
            this.button_search.TabIndex = 24;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(179, 339);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(78, 22);
            this.button_edit.TabIndex = 23;
            this.button_edit.Text = "View";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(95, 339);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(78, 22);
            this.button_clean.TabIndex = 22;
            this.button_clean.Text = "Cleam Selection";
            this.button_clean.UseVisualStyleBackColor = true;
            // 
            // button_retrieveAll
            // 
            this.button_retrieveAll.Location = new System.Drawing.Point(255, 51);
            this.button_retrieveAll.Name = "button_retrieveAll";
            this.button_retrieveAll.Size = new System.Drawing.Size(88, 20);
            this.button_retrieveAll.TabIndex = 21;
            this.button_retrieveAll.Text = "Retrieve All";
            this.button_retrieveAll.UseVisualStyleBackColor = true;
            this.button_retrieveAll.Click += new System.EventHandler(this.Button_ListAll_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(12, 339);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(78, 22);
            this.button_cancel.TabIndex = 20;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(99, 25);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(150, 20);
            this.text_name.TabIndex = 19;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(12, 25);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(80, 20);
            this.text_id.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Country Name";
            // 
            // label_countriesCount
            // 
            this.label_countriesCount.AutoSize = true;
            this.label_countriesCount.Location = new System.Drawing.Point(15, 364);
            this.label_countriesCount.Name = "label_countriesCount";
            this.label_countriesCount.Size = new System.Drawing.Size(10, 13);
            this.label_countriesCount.TabIndex = 27;
            this.label_countriesCount.Text = "-";
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(263, 339);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(78, 23);
            this.button_delete.TabIndex = 28;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Form_CountryRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 386);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_countriesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table_Countries);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_retrieveAll);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.Name = "Form_CountryRetrieve";
            this.Text = "Country Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CountryRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_CountryRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Countries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_Countries;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_retrieveAll;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_countriesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Show;
        private System.Windows.Forms.Button button_delete;
    }
}