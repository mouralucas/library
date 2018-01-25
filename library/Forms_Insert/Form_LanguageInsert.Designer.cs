namespace library.Forms_Insert
{
    partial class Form_LanguageInsert
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
            this.label2 = new System.Windows.Forms.Label();
            this.text_languageName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_showLanguage = new System.Windows.Forms.ComboBox();
            this.button_saveLanguage = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language Name";
            // 
            // text_languageName
            // 
            this.text_languageName.Location = new System.Drawing.Point(16, 69);
            this.text_languageName.Name = "text_languageName";
            this.text_languageName.Size = new System.Drawing.Size(250, 20);
            this.text_languageName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Show Language on Insertions";
            // 
            // box_showLanguage
            // 
            this.box_showLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_showLanguage.FormattingEnabled = true;
            this.box_showLanguage.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.box_showLanguage.Location = new System.Drawing.Point(16, 113);
            this.box_showLanguage.Name = "box_showLanguage";
            this.box_showLanguage.Size = new System.Drawing.Size(121, 21);
            this.box_showLanguage.TabIndex = 4;
            // 
            // button_saveLanguage
            // 
            this.button_saveLanguage.Location = new System.Drawing.Point(143, 112);
            this.button_saveLanguage.Name = "button_saveLanguage";
            this.button_saveLanguage.Size = new System.Drawing.Size(123, 21);
            this.button_saveLanguage.TabIndex = 5;
            this.button_saveLanguage.Text = "Save";
            this.button_saveLanguage.UseVisualStyleBackColor = true;
            this.button_saveLanguage.Click += new System.EventHandler(this.button_saveLanguage_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(16, 140);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(250, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Form_LanguageInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 178);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_saveLanguage);
            this.Controls.Add(this.box_showLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_languageName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_LanguageInsert";
            this.Text = "Insert Language";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_LanguageInsert_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_languageName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box_showLanguage;
        private System.Windows.Forms.Button button_saveLanguage;
        private System.Windows.Forms.Button button_cancel;
    }
}