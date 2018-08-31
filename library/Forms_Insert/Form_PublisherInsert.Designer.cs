namespace Library.Forms_Insert
{
    partial class Form_PublisherInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PublisherInsert));
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_publisherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_country = new System.Windows.Forms.ComboBox();
            this.text_publisherAbout = new System.Windows.Forms.RichTextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_logo
            // 
            this.picture_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture_logo.InitialImage")));
            this.picture_logo.Location = new System.Drawing.Point(377, 29);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(260, 150);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            this.picture_logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_logo_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(12, 28);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(50, 20);
            this.text_id.TabIndex = 2;
            // 
            // text_publisherName
            // 
            this.text_publisherName.Location = new System.Drawing.Point(68, 28);
            this.text_publisherName.Name = "text_publisherName";
            this.text_publisherName.Size = new System.Drawing.Size(300, 20);
            this.text_publisherName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // box_country
            // 
            this.box_country.FormattingEnabled = true;
            this.box_country.Location = new System.Drawing.Point(12, 55);
            this.box_country.Name = "box_country";
            this.box_country.Size = new System.Drawing.Size(159, 21);
            this.box_country.TabIndex = 5;
            this.box_country.Text = "Country";
            this.box_country.SelectionChangeCommitted += new System.EventHandler(this.Box_country_SelectionChangeCommitted);
            // 
            // text_publisherAbout
            // 
            this.text_publisherAbout.Location = new System.Drawing.Point(11, 82);
            this.text_publisherAbout.Name = "text_publisherAbout";
            this.text_publisherAbout.Size = new System.Drawing.Size(357, 155);
            this.text_publisherAbout.TabIndex = 6;
            this.text_publisherAbout.Text = "";
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(377, 185);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(129, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(508, 185);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(129, 23);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(377, 214);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(129, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(508, 214);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(129, 23);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // Form_PublisherInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 250);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.text_publisherAbout);
            this.Controls.Add(this.box_country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_publisherName);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_logo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form_PublisherInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Publisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PublisherInsert_FormClosing);
            this.Load += new System.EventHandler(this.Form_PublisherInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_publisherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_country;
        private System.Windows.Forms.RichTextBox text_publisherAbout;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
    }
}