namespace library.Forms_Retrieve
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
            this.table_serie = new System.Windows.Forms.DataGridView();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_volumes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.text_serieName = new System.Windows.Forms.TextBox();
            this.text_serie_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_serieType = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_retrieveAll = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_detail = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_serieCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_serie)).BeginInit();
            this.SuspendLayout();
            // 
            // table_serie
            // 
            this.table_serie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_serie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_name,
            this.Column_volumes,
            this.Column_type});
            this.table_serie.Location = new System.Drawing.Point(12, 81);
            this.table_serie.Name = "table_serie";
            this.table_serie.Size = new System.Drawing.Size(414, 243);
            this.table_serie.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // text_serieName
            // 
            this.text_serieName.Location = new System.Drawing.Point(68, 25);
            this.text_serieName.Name = "text_serieName";
            this.text_serieName.Size = new System.Drawing.Size(230, 20);
            this.text_serieName.TabIndex = 7;
            // 
            // text_serie_id
            // 
            this.text_serie_id.Location = new System.Drawing.Point(12, 25);
            this.text_serie_id.Name = "text_serie_id";
            this.text_serie_id.Size = new System.Drawing.Size(50, 20);
            this.text_serie_id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // box_serieType
            // 
            this.box_serieType.FormattingEnabled = true;
            this.box_serieType.Items.AddRange(new object[] {
            "Book",
            "Manga",
            "HQ"});
            this.box_serieType.Location = new System.Drawing.Point(304, 25);
            this.box_serieType.Name = "box_serieType";
            this.box_serieType.Size = new System.Drawing.Size(121, 21);
            this.box_serieType.TabIndex = 9;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(304, 52);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(121, 23);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_retrieveAll
            // 
            this.button_retrieveAll.Location = new System.Drawing.Point(228, 52);
            this.button_retrieveAll.Name = "button_retrieveAll";
            this.button_retrieveAll.Size = new System.Drawing.Size(70, 23);
            this.button_retrieveAll.TabIndex = 11;
            this.button_retrieveAll.Text = "Retrieve All";
            this.button_retrieveAll.UseVisualStyleBackColor = true;
            this.button_retrieveAll.Click += new System.EventHandler(this.button_retrieveAll_Click);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(224, 330);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(98, 23);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(116, 330);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(98, 23);
            this.button_clean.TabIndex = 34;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            // 
            // button_detail
            // 
            this.button_detail.Enabled = false;
            this.button_detail.Location = new System.Drawing.Point(328, 330);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(98, 23);
            this.button_detail.TabIndex = 33;
            this.button_detail.Text = "See Detail";
            this.button_detail.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 330);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(98, 23);
            this.button_cancel.TabIndex = 32;
            this.button_cancel.Text = "Cancel";
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
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_retrieveAll);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.box_serieType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_serieName);
            this.Controls.Add(this.text_serie_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_serie);
            this.Name = "Form_SerieRetrieve";
            this.Text = "Form_SerieRetrieve";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SerieRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_SerieRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_serie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_volumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_serieName;
        private System.Windows.Forms.TextBox text_serie_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box_serieType;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_retrieveAll;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_detail;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_serieCount;
    }
}