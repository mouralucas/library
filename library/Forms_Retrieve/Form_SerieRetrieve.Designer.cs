namespace Library.Forms_Retrieve
{
    partial class Form_SerieRetrieve
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
            this.Table_Serie = new System.Windows.Forms.DataGridView();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_volumes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Text_SerieName = new System.Windows.Forms.TextBox();
            this.Box_Category = new System.Windows.Forms.ComboBox();
            this.Button_Detail = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_serieCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Serie)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_Serie
            // 
            this.Table_Serie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Serie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_name,
            this.Column_volumes,
            this.Column_type});
            this.Table_Serie.Location = new System.Drawing.Point(12, 52);
            this.Table_Serie.Name = "Table_Serie";
            this.Table_Serie.Size = new System.Drawing.Size(414, 272);
            this.Table_Serie.TabIndex = 0;
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "Id";
            this.Column_id.Name = "Column_id";
            this.Column_id.Width = 30;
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Serie Name";
            this.Column_name.Name = "Column_name";
            this.Column_name.Width = 180;
            // 
            // Column_volumes
            // 
            this.Column_volumes.HeaderText = "Volumes";
            this.Column_volumes.Name = "Column_volumes";
            this.Column_volumes.Width = 60;
            // 
            // Column_type
            // 
            this.Column_type.HeaderText = "Type";
            this.Column_type.Name = "Column_type";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(9, 9);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(35, 13);
            this.Label_Name.TabIndex = 8;
            this.Label_Name.Text = "Nome";
            // 
            // Text_SerieName
            // 
            this.Text_SerieName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Text_SerieName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Text_SerieName.Location = new System.Drawing.Point(12, 25);
            this.Text_SerieName.Name = "Text_SerieName";
            this.Text_SerieName.Size = new System.Drawing.Size(287, 20);
            this.Text_SerieName.TabIndex = 7;
            this.Text_SerieName.TextChanged += new System.EventHandler(this.Text_SerieName_TextChanged);
            // 
            // Box_Category
            // 
            this.Box_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Category.FormattingEnabled = true;
            this.Box_Category.Items.AddRange(new object[] {
            "Book",
            "Manga",
            "HQ"});
            this.Box_Category.Location = new System.Drawing.Point(305, 24);
            this.Box_Category.Name = "Box_Category";
            this.Box_Category.Size = new System.Drawing.Size(121, 21);
            this.Box_Category.TabIndex = 9;
            // 
            // Button_Detail
            // 
            this.Button_Detail.Enabled = false;
            this.Button_Detail.Location = new System.Drawing.Point(328, 330);
            this.Button_Detail.Name = "Button_Detail";
            this.Button_Detail.Size = new System.Drawing.Size(98, 23);
            this.Button_Detail.TabIndex = 33;
            this.Button_Detail.Text = "Visualizar";
            this.Button_Detail.UseVisualStyleBackColor = true;
            this.Button_Detail.Click += new System.EventHandler(this.Button_Detail_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 330);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(98, 23);
            this.button_cancel.TabIndex = 32;
            this.button_cancel.Text = "Voltar";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_serieCount
            // 
            this.label_serieCount.AutoSize = true;
            this.label_serieCount.Location = new System.Drawing.Point(12, 356);
            this.label_serieCount.Name = "label_serieCount";
            this.label_serieCount.Size = new System.Drawing.Size(10, 13);
            this.label_serieCount.TabIndex = 35;
            this.label_serieCount.Text = "-";
            // 
            // Form_SerieRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 379);
            this.Controls.Add(this.label_serieCount);
            this.Controls.Add(this.Button_Detail);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.Box_Category);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Text_SerieName);
            this.Controls.Add(this.Table_Serie);
            this.Name = "Form_SerieRetrieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SerieRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_SerieRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Serie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_volumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_type;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox Text_SerieName;
        private System.Windows.Forms.ComboBox Box_Category;
        private System.Windows.Forms.Button Button_Detail;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_serieCount;
    }
}