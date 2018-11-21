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
            this.Text_AuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Country = new System.Windows.Forms.ComboBox();
            this.Table_Authors = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Detail = new System.Windows.Forms.Button();
            this.Label_AuthorCount = new System.Windows.Forms.Label();
            this.Box_Category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_AuthorName
            // 
            this.Text_AuthorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Text_AuthorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Text_AuthorName.Location = new System.Drawing.Point(16, 31);
            this.Text_AuthorName.Name = "Text_AuthorName";
            this.Text_AuthorName.Size = new System.Drawing.Size(201, 20);
            this.Text_AuthorName.TabIndex = 3;
            this.Text_AuthorName.TextChanged += new System.EventHandler(this.Text_AuthorName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // Box_Country
            // 
            this.Box_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Country.FormattingEnabled = true;
            this.Box_Country.Location = new System.Drawing.Point(223, 31);
            this.Box_Country.Name = "Box_Country";
            this.Box_Country.Size = new System.Drawing.Size(109, 21);
            this.Box_Country.TabIndex = 5;
            this.Box_Country.SelectionChangeCommitted += new System.EventHandler(this.Box_Country_SelectionChangeCommitted);
            // 
            // Table_Authors
            // 
            this.Table_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Country,
            this.Column_Category});
            this.Table_Authors.Location = new System.Drawing.Point(16, 57);
            this.Table_Authors.Name = "Table_Authors";
            this.Table_Authors.Size = new System.Drawing.Size(500, 334);
            this.Table_Authors.TabIndex = 9;
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
            // Column_Category
            // 
            this.Column_Category.HeaderText = "Category";
            this.Column_Category.Name = "Column_Category";
            this.Column_Category.Width = 150;
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(16, 397);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(121, 23);
            this.Button_Back.TabIndex = 10;
            this.Button_Back.Text = "Voltar";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Detail
            // 
            this.Button_Detail.Enabled = false;
            this.Button_Detail.Location = new System.Drawing.Point(386, 397);
            this.Button_Detail.Name = "Button_Detail";
            this.Button_Detail.Size = new System.Drawing.Size(130, 23);
            this.Button_Detail.TabIndex = 11;
            this.Button_Detail.Text = "Visualizar";
            this.Button_Detail.UseVisualStyleBackColor = true;
            this.Button_Detail.Click += new System.EventHandler(this.Button_Detail_Click);
            // 
            // Label_AuthorCount
            // 
            this.Label_AuthorCount.AutoSize = true;
            this.Label_AuthorCount.Location = new System.Drawing.Point(19, 424);
            this.Label_AuthorCount.Name = "Label_AuthorCount";
            this.Label_AuthorCount.Size = new System.Drawing.Size(10, 13);
            this.Label_AuthorCount.TabIndex = 28;
            this.Label_AuthorCount.Text = "-";
            // 
            // Box_Category
            // 
            this.Box_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Category.FormattingEnabled = true;
            this.Box_Category.Location = new System.Drawing.Point(338, 31);
            this.Box_Category.Name = "Box_Category";
            this.Box_Category.Size = new System.Drawing.Size(109, 21);
            this.Box_Category.TabIndex = 29;
            this.Box_Category.SelectionChangeCommitted += new System.EventHandler(this.Box_Category_SelectionChangeCommitted);
            // 
            // Form_AuthorRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 444);
            this.Controls.Add(this.Box_Category);
            this.Controls.Add(this.Label_AuthorCount);
            this.Controls.Add(this.Button_Detail);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Table_Authors);
            this.Controls.Add(this.Box_Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_AuthorName);
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
        private System.Windows.Forms.TextBox Text_AuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Box_Country;
        private System.Windows.Forms.DataGridView Table_Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Id;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Detail;
        private System.Windows.Forms.Label Label_AuthorCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Category;
        private System.Windows.Forms.ComboBox Box_Category;
    }
}