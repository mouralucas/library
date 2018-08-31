namespace Library.Forms_Insert
{
    partial class Form_GenreInsert
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
            this.Button_Save = new System.Windows.Forms.Button();
            this.text_genreName = new System.Windows.Forms.TextBox();
            this.label_genreName = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(141, 94);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(124, 23);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // text_genreName
            // 
            this.text_genreName.Location = new System.Drawing.Point(15, 65);
            this.text_genreName.Name = "text_genreName";
            this.text_genreName.Size = new System.Drawing.Size(250, 20);
            this.text_genreName.TabIndex = 2;
            // 
            // label_genreName
            // 
            this.label_genreName.AutoSize = true;
            this.label_genreName.Location = new System.Drawing.Point(12, 49);
            this.label_genreName.Name = "label_genreName";
            this.label_genreName.Size = new System.Drawing.Size(35, 13);
            this.label_genreName.TabIndex = 3;
            this.label_genreName.Text = "Name";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 94);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert Genre";
            // 
            // Form_GenreInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_genreName);
            this.Controls.Add(this.text_genreName);
            this.Controls.Add(this.Button_Save);
            this.Name = "Form_GenreInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Genres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GenreInsert_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox text_genreName;
        private System.Windows.Forms.Label label_genreName;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
    }
}

