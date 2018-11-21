namespace Library.Forms_Insert
{
    partial class Form_CountryInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CountryInsert));
            this.text_countryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_showCountry = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.picture_flag = new System.Windows.Forms.PictureBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // text_countryName
            // 
            this.text_countryName.Location = new System.Drawing.Point(71, 74);
            this.text_countryName.Name = "text_countryName";
            this.text_countryName.Size = new System.Drawing.Size(191, 20);
            this.text_countryName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show Country on Insertions";
            // 
            // box_showCountry
            // 
            this.box_showCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_showCountry.FormattingEnabled = true;
            this.box_showCountry.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.box_showCountry.Location = new System.Drawing.Point(12, 114);
            this.box_showCountry.Name = "box_showCountry";
            this.box_showCountry.Size = new System.Drawing.Size(136, 21);
            this.box_showCountry.TabIndex = 6;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(97, 275);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(80, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(11, 275);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(26, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(221, 35);
            this.label_title.TabIndex = 9;
            this.label_title.Text = "Insert Country";
            // 
            // picture_flag
            // 
            this.picture_flag.Image = ((System.Drawing.Image)(resources.GetObject("picture_flag.Image")));
            this.picture_flag.Location = new System.Drawing.Point(12, 142);
            this.picture_flag.Name = "picture_flag";
            this.picture_flag.Size = new System.Drawing.Size(250, 127);
            this.picture_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_flag.TabIndex = 10;
            this.picture_flag.TabStop = false;
            this.picture_flag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_flag_MouseClick);
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(15, 74);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(50, 20);
            this.text_id.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(97, 275);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(80, 23);
            this.button_edit.TabIndex = 14;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(183, 275);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(80, 23);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Form_CountryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 310);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.picture_flag);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.box_showCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_countryName);
            this.Name = "Form_CountryInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Country";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CountryInsert_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture_flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_countryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_showCountry;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox picture_flag;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
    }
}