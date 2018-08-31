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
            this.label1 = new System.Windows.Forms.Label();
            this.text_serieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_serieSynopsis = new System.Windows.Forms.RichTextBox();
            this.box_serieType = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.box_volumes = new System.Windows.Forms.ComboBox();
            this.text_id = new System.Windows.Forms.TextBox();
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
            // text_serieName
            // 
            this.text_serieName.Location = new System.Drawing.Point(69, 30);
            this.text_serieName.Name = "text_serieName";
            this.text_serieName.Size = new System.Drawing.Size(273, 20);
            this.text_serieName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // text_serieSynopsis
            // 
            this.text_serieSynopsis.Location = new System.Drawing.Point(13, 83);
            this.text_serieSynopsis.Name = "text_serieSynopsis";
            this.text_serieSynopsis.Size = new System.Drawing.Size(330, 182);
            this.text_serieSynopsis.TabIndex = 6;
            this.text_serieSynopsis.Text = "";
            // 
            // box_serieType
            // 
            this.box_serieType.FormattingEnabled = true;
            this.box_serieType.Items.AddRange(new object[] {
            "Book",
            "Manga",
            "HQ"});
            this.box_serieType.Location = new System.Drawing.Point(84, 56);
            this.box_serieType.Name = "box_serieType";
            this.box_serieType.Size = new System.Drawing.Size(178, 21);
            this.box_serieType.TabIndex = 7;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 271);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(78, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(96, 271);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(78, 23);
            this.button_edit.TabIndex = 10;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(180, 271);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(78, 23);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(265, 271);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(78, 23);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // box_volumes
            // 
            this.box_volumes.FormattingEnabled = true;
            this.box_volumes.Location = new System.Drawing.Point(13, 56);
            this.box_volumes.Name = "box_volumes";
            this.box_volumes.Size = new System.Drawing.Size(65, 21);
            this.box_volumes.TabIndex = 13;
            this.box_volumes.Text = "Volumes";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(13, 30);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(50, 20);
            this.text_id.TabIndex = 1;
            // 
            // Form_SerieInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 307);
            this.Controls.Add(this.box_volumes);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.box_serieType);
            this.Controls.Add(this.text_serieSynopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_serieName);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.Name = "Form_SerieInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Series";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SerieInsert_FormClosing);
            this.Load += new System.EventHandler(this.Form_SerieInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_serieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox text_serieSynopsis;
        private System.Windows.Forms.ComboBox box_serieType;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox box_volumes;
        private System.Windows.Forms.TextBox text_id;
    }
}