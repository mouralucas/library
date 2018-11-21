namespace Library.Forms_Insert
{
    partial class Form_SerieInsert
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
            this.Text_SerieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_SerieSynopsis = new System.Windows.Forms.RichTextBox();
            this.Box_Category = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.Button_Transaction = new System.Windows.Forms.Button();
            this.Text_Volumes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_serieName
            // 
            this.Text_SerieName.Location = new System.Drawing.Point(15, 30);
            this.Text_SerieName.Name = "text_serieName";
            this.Text_SerieName.Size = new System.Drawing.Size(229, 20);
            this.Text_SerieName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // Text_SerieSynopsis
            // 
            this.Text_SerieSynopsis.Location = new System.Drawing.Point(15, 57);
            this.Text_SerieSynopsis.Name = "Text_SerieSynopsis";
            this.Text_SerieSynopsis.Size = new System.Drawing.Size(419, 182);
            this.Text_SerieSynopsis.TabIndex = 6;
            this.Text_SerieSynopsis.Text = "";
            // 
            // Box_Category
            // 
            this.Box_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Category.FormattingEnabled = true;
            this.Box_Category.Location = new System.Drawing.Point(318, 30);
            this.Box_Category.Name = "Box_Category";
            this.Box_Category.Size = new System.Drawing.Size(114, 21);
            this.Box_Category.TabIndex = 7;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(15, 245);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(102, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Voltar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Transaction
            // 
            this.Button_Transaction.Location = new System.Drawing.Point(318, 245);
            this.Button_Transaction.Name = "Button_Transaction";
            this.Button_Transaction.Size = new System.Drawing.Size(114, 23);
            this.Button_Transaction.TabIndex = 12;
            this.Button_Transaction.Text = "Salvar";
            this.Button_Transaction.UseVisualStyleBackColor = true;
            this.Button_Transaction.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Text_Volumes
            // 
            this.Text_Volumes.Location = new System.Drawing.Point(250, 30);
            this.Text_Volumes.Name = "Text_Volumes";
            this.Text_Volumes.Size = new System.Drawing.Size(62, 20);
            this.Text_Volumes.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Volumes";
            // 
            // Form_SerieInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_Volumes);
            this.Controls.Add(this.Button_Transaction);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.Box_Category);
            this.Controls.Add(this.Text_SerieSynopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_SerieName);
            this.Name = "Form_SerieInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Series";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SerieInsert_FormClosing);
            this.Load += new System.EventHandler(this.Form_SerieInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Text_SerieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Text_SerieSynopsis;
        private System.Windows.Forms.ComboBox Box_Category;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button Button_Transaction;
        private System.Windows.Forms.TextBox Text_Volumes;
        private System.Windows.Forms.Label label3;
    }
}