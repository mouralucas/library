namespace library.Forms_Insert
{
    partial class Form_AuthorInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AuthorInsert));
            this.picture_author = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_authorName = new System.Windows.Forms.TextBox();
            this.box_language = new System.Windows.Forms.ComboBox();
            this.box_country = new System.Windows.Forms.ComboBox();
            this.text_authorAbout = new System.Windows.Forms.RichTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_author)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_author
            // 
            this.picture_author.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_author.Image = ((System.Drawing.Image)(resources.GetObject("picture_author.Image")));
            this.picture_author.InitialImage = null;
            this.picture_author.Location = new System.Drawing.Point(12, 12);
            this.picture_author.Name = "picture_author";
            this.picture_author.Size = new System.Drawing.Size(170, 230);
            this.picture_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_author.TabIndex = 1;
            this.picture_author.TabStop = false;
            this.picture_author.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_author_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // text_authorName
            // 
            this.text_authorName.Location = new System.Drawing.Point(192, 29);
            this.text_authorName.Name = "text_authorName";
            this.text_authorName.Size = new System.Drawing.Size(300, 20);
            this.text_authorName.TabIndex = 4;
            // 
            // box_language
            // 
            this.box_language.FormattingEnabled = true;
            this.box_language.Location = new System.Drawing.Point(343, 55);
            this.box_language.Name = "box_language";
            this.box_language.Size = new System.Drawing.Size(149, 21);
            this.box_language.TabIndex = 6;
            this.box_language.Text = "Language";
            // 
            // box_country
            // 
            this.box_country.FormattingEnabled = true;
            this.box_country.Location = new System.Drawing.Point(192, 55);
            this.box_country.Name = "box_country";
            this.box_country.Size = new System.Drawing.Size(149, 21);
            this.box_country.TabIndex = 5;
            this.box_country.Text = "Country";
            // 
            // text_authorAbout
            // 
            this.text_authorAbout.Location = new System.Drawing.Point(192, 82);
            this.text_authorAbout.Name = "text_authorAbout";
            this.text_authorAbout.Size = new System.Drawing.Size(301, 131);
            this.text_authorAbout.TabIndex = 8;
            this.text_authorAbout.Text = "";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(347, 219);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(149, 23);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(192, 219);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(149, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_AuthorInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 251);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.text_authorAbout);
            this.Controls.Add(this.box_language);
            this.Controls.Add(this.box_country);
            this.Controls.Add(this.text_authorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_author);
            this.Name = "Form_AuthorInsert";
            this.Text = "Insert Author";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AuthorIns_FormClosing);
            this.Load += new System.EventHandler(this.Form_AuthorIns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_authorName;
        private System.Windows.Forms.ComboBox box_language;
        private System.Windows.Forms.ComboBox box_country;
        private System.Windows.Forms.RichTextBox text_authorAbout;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}