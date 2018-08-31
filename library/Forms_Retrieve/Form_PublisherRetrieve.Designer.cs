namespace Library.Forms_Retrieve
{
    partial class Form_PublisherRetrieve
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.table_publishers = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            this.button_retrieveAll = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_detail = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_publishersCount = new System.Windows.Forms.Label();
            this.box_country = new System.Windows.Forms.ComboBox();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table_publishers)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 2;
            // 
            // table_publishers
            // 
            this.table_publishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_publishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_name,
            this.column_country});
            this.table_publishers.Location = new System.Drawing.Point(16, 85);
            this.table_publishers.Name = "table_publishers";
            this.table_publishers.Size = new System.Drawing.Size(409, 292);
            this.table_publishers.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(272, 30);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(153, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_retrieveAll
            // 
            this.button_retrieveAll.Location = new System.Drawing.Point(272, 56);
            this.button_retrieveAll.Name = "button_retrieveAll";
            this.button_retrieveAll.Size = new System.Drawing.Size(153, 23);
            this.button_retrieveAll.TabIndex = 5;
            this.button_retrieveAll.Text = "Retrieve All";
            this.button_retrieveAll.UseVisualStyleBackColor = true;
            this.button_retrieveAll.Click += new System.EventHandler(this.Button_RetrieveAll_Click);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(327, 384);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(98, 23);
            this.button_delete.TabIndex = 32;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_detail
            // 
            this.button_detail.Enabled = false;
            this.button_detail.Location = new System.Drawing.Point(223, 384);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(98, 22);
            this.button_detail.TabIndex = 31;
            this.button_detail.Text = "See Detail";
            this.button_detail.UseVisualStyleBackColor = true;
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(119, 384);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(98, 22);
            this.button_clean.TabIndex = 30;
            this.button_clean.Text = "Cleam Selection";
            this.button_clean.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(15, 383);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(98, 22);
            this.button_cancel.TabIndex = 29;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name";
            // 
            // label_publishersCount
            // 
            this.label_publishersCount.AutoSize = true;
            this.label_publishersCount.Location = new System.Drawing.Point(18, 408);
            this.label_publishersCount.Name = "label_publishersCount";
            this.label_publishersCount.Size = new System.Drawing.Size(10, 13);
            this.label_publishersCount.TabIndex = 34;
            this.label_publishersCount.Text = "-";
            // 
            // box_country
            // 
            this.box_country.FormattingEnabled = true;
            this.box_country.Location = new System.Drawing.Point(16, 58);
            this.box_country.Name = "box_country";
            this.box_country.Size = new System.Drawing.Size(156, 21);
            this.box_country.TabIndex = 35;
            this.box_country.Text = "Country";
            // 
            // column_id
            // 
            this.column_id.HeaderText = "Id";
            this.column_id.Name = "column_id";
            this.column_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column_id.Width = 35;
            // 
            // column_name
            // 
            this.column_name.HeaderText = "Name";
            this.column_name.Name = "column_name";
            this.column_name.Width = 165;
            // 
            // column_country
            // 
            this.column_country.HeaderText = "Country";
            this.column_country.Name = "column_country";
            this.column_country.Width = 165;
            // 
            // Form_PublisherRetrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 432);
            this.Controls.Add(this.box_country);
            this.Controls.Add(this.label_publishersCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_detail);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_retrieveAll);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.table_publishers);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_PublisherRetrieve";
            this.Text = "Search Publisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PublisherRetrieve_FormClosing);
            this.Load += new System.EventHandler(this.Form_PublisherRetrieve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_publishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView table_publishers;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_retrieveAll;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_detail;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_publishersCount;
        private System.Windows.Forms.ComboBox box_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_country;
    }
}