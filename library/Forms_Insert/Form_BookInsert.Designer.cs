namespace library.Forms_Insert
{
    partial class Form_BookInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BookInsert));
            this.picture_author = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_sublTitle = new System.Windows.Forms.TextBox();
            this.text_OriginalTitle = new System.Windows.Forms.TextBox();
            this.text_originalSubTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_sameAsTitle = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_isbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_volumes = new System.Windows.Forms.TextBox();
            this.listBox_authors = new System.Windows.Forms.ListBox();
            this.box_authors = new System.Windows.Forms.ComboBox();
            this.text_releaseDate = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_language = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_coverPrice = new System.Windows.Forms.MaskedTextBox();
            this.box_type = new System.Windows.Forms.ComboBox();
            this.box_status = new System.Windows.Forms.ComboBox();
            this.box_readingStatus = new System.Windows.Forms.ComboBox();
            this.box_publisher = new System.Windows.Forms.ComboBox();
            this.box_serie = new System.Windows.Forms.ComboBox();
            this.box_genres = new System.Windows.Forms.ComboBox();
            this.listBox_genres = new System.Windows.Forms.ListBox();
            this.button_removeAuthor = new System.Windows.Forms.Button();
            this.button_removeGenre = new System.Windows.Forms.Button();
            this.text_edition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.text_pages = new System.Windows.Forms.TextBox();
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
            this.picture_author.Size = new System.Drawing.Size(200, 270);
            this.picture_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_author.TabIndex = 2;
            this.picture_author.TabStop = false;
            this.picture_author.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_author_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(217, 28);
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(250, 20);
            this.text_title.TabIndex = 4;
            this.text_title.TextChanged += new System.EventHandler(this.text_title_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original Title";
            // 
            // text_sublTitle
            // 
            this.text_sublTitle.Location = new System.Drawing.Point(473, 28);
            this.text_sublTitle.Name = "text_sublTitle";
            this.text_sublTitle.Size = new System.Drawing.Size(250, 20);
            this.text_sublTitle.TabIndex = 6;
            this.text_sublTitle.TextChanged += new System.EventHandler(this.text_sublTitle_TextChanged);
            // 
            // text_OriginalTitle
            // 
            this.text_OriginalTitle.Location = new System.Drawing.Point(217, 71);
            this.text_OriginalTitle.Name = "text_OriginalTitle";
            this.text_OriginalTitle.Size = new System.Drawing.Size(250, 20);
            this.text_OriginalTitle.TabIndex = 7;
            // 
            // text_originalSubTitle
            // 
            this.text_originalSubTitle.Location = new System.Drawing.Point(473, 71);
            this.text_originalSubTitle.Name = "text_originalSubTitle";
            this.text_originalSubTitle.Size = new System.Drawing.Size(250, 20);
            this.text_originalSubTitle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sub-Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Original Sub-Title";
            // 
            // checkBox_sameAsTitle
            // 
            this.checkBox_sameAsTitle.AutoSize = true;
            this.checkBox_sameAsTitle.Location = new System.Drawing.Point(729, 30);
            this.checkBox_sameAsTitle.Name = "checkBox_sameAsTitle";
            this.checkBox_sameAsTitle.Size = new System.Drawing.Size(117, 17);
            this.checkBox_sameAsTitle.TabIndex = 11;
            this.checkBox_sameAsTitle.Text = "This is Original Title";
            this.checkBox_sameAsTitle.UseVisualStyleBackColor = true;
            this.checkBox_sameAsTitle.CheckedChanged += new System.EventHandler(this.checkBox_sameAsTitle_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ISBN";
            // 
            // text_isbn
            // 
            this.text_isbn.Location = new System.Drawing.Point(733, 70);
            this.text_isbn.Name = "text_isbn";
            this.text_isbn.Size = new System.Drawing.Size(123, 20);
            this.text_isbn.TabIndex = 13;
            this.text_isbn.Text = "978-85-99296-94-3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Volumes";
            // 
            // text_volumes
            // 
            this.text_volumes.Location = new System.Drawing.Point(521, 114);
            this.text_volumes.Name = "text_volumes";
            this.text_volumes.Size = new System.Drawing.Size(47, 20);
            this.text_volumes.TabIndex = 15;
            // 
            // listBox_authors
            // 
            this.listBox_authors.FormattingEnabled = true;
            this.listBox_authors.Location = new System.Drawing.Point(217, 125);
            this.listBox_authors.Name = "listBox_authors";
            this.listBox_authors.Size = new System.Drawing.Size(156, 95);
            this.listBox_authors.TabIndex = 17;
            // 
            // box_authors
            // 
            this.box_authors.FormattingEnabled = true;
            this.box_authors.Location = new System.Drawing.Point(217, 98);
            this.box_authors.Name = "box_authors";
            this.box_authors.Size = new System.Drawing.Size(156, 21);
            this.box_authors.TabIndex = 18;
            this.box_authors.Text = "Author(s)";
            this.box_authors.SelectedIndexChanged += new System.EventHandler(this.box_authors_SelectedIndexChanged);
            // 
            // text_releaseDate
            // 
            this.text_releaseDate.Location = new System.Drawing.Point(673, 158);
            this.text_releaseDate.Mask = "00/00/0000";
            this.text_releaseDate.Name = "text_releaseDate";
            this.text_releaseDate.Size = new System.Drawing.Size(77, 20);
            this.text_releaseDate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Release Date";
            // 
            // box_language
            // 
            this.box_language.FormattingEnabled = true;
            this.box_language.Location = new System.Drawing.Point(574, 158);
            this.box_language.Name = "box_language";
            this.box_language.Size = new System.Drawing.Size(93, 21);
            this.box_language.TabIndex = 21;
            this.box_language.Text = "Language";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cover Price";
            // 
            // text_coverPrice
            // 
            this.text_coverPrice.Location = new System.Drawing.Point(756, 158);
            this.text_coverPrice.Name = "text_coverPrice";
            this.text_coverPrice.Size = new System.Drawing.Size(100, 20);
            this.text_coverPrice.TabIndex = 23;
            // 
            // box_type
            // 
            this.box_type.FormattingEnabled = true;
            this.box_type.Items.AddRange(new object[] {
            "Paperback",
            "Hardcover",
            "e-Book"});
            this.box_type.Location = new System.Drawing.Point(521, 202);
            this.box_type.Name = "box_type";
            this.box_type.Size = new System.Drawing.Size(129, 21);
            this.box_type.TabIndex = 24;
            this.box_type.Text = "Format";
            // 
            // box_status
            // 
            this.box_status.FormattingEnabled = true;
            this.box_status.Items.AddRange(new object[] {
            "in Shelf",
            "Wanted",
            "Waiting Deliver",
            "Borrowed"});
            this.box_status.Location = new System.Drawing.Point(656, 202);
            this.box_status.Name = "box_status";
            this.box_status.Size = new System.Drawing.Size(141, 21);
            this.box_status.TabIndex = 25;
            this.box_status.Text = "Status";
            // 
            // box_readingStatus
            // 
            this.box_readingStatus.FormattingEnabled = true;
            this.box_readingStatus.Items.AddRange(new object[] {
            "Read",
            "Reading",
            "Droped",
            "Eventually"});
            this.box_readingStatus.Location = new System.Drawing.Point(521, 229);
            this.box_readingStatus.Name = "box_readingStatus";
            this.box_readingStatus.Size = new System.Drawing.Size(129, 21);
            this.box_readingStatus.TabIndex = 26;
            this.box_readingStatus.Text = "Reading Status";
            // 
            // box_publisher
            // 
            this.box_publisher.FormattingEnabled = true;
            this.box_publisher.Location = new System.Drawing.Point(656, 229);
            this.box_publisher.Name = "box_publisher";
            this.box_publisher.Size = new System.Drawing.Size(200, 21);
            this.box_publisher.TabIndex = 27;
            this.box_publisher.Text = "Publisher";
            // 
            // box_serie
            // 
            this.box_serie.FormattingEnabled = true;
            this.box_serie.Items.AddRange(new object[] {
            "The Hitchhiker\'s Guide to the Galaxy"});
            this.box_serie.Location = new System.Drawing.Point(574, 113);
            this.box_serie.Name = "box_serie";
            this.box_serie.Size = new System.Drawing.Size(282, 21);
            this.box_serie.TabIndex = 30;
            this.box_serie.Text = "Serie";
            // 
            // box_genres
            // 
            this.box_genres.FormattingEnabled = true;
            this.box_genres.Location = new System.Drawing.Point(379, 98);
            this.box_genres.Name = "box_genres";
            this.box_genres.Size = new System.Drawing.Size(136, 21);
            this.box_genres.TabIndex = 31;
            this.box_genres.Text = "Genre";
            // 
            // listBox_genres
            // 
            this.listBox_genres.FormattingEnabled = true;
            this.listBox_genres.Location = new System.Drawing.Point(379, 125);
            this.listBox_genres.Name = "listBox_genres";
            this.listBox_genres.Size = new System.Drawing.Size(136, 95);
            this.listBox_genres.TabIndex = 32;
            // 
            // button_removeAuthor
            // 
            this.button_removeAuthor.Location = new System.Drawing.Point(217, 229);
            this.button_removeAuthor.Name = "button_removeAuthor";
            this.button_removeAuthor.Size = new System.Drawing.Size(156, 23);
            this.button_removeAuthor.TabIndex = 33;
            this.button_removeAuthor.Text = "Remove Author";
            this.button_removeAuthor.UseVisualStyleBackColor = true;
            this.button_removeAuthor.Click += new System.EventHandler(this.button_removeAuthor_Click);
            // 
            // button_removeGenre
            // 
            this.button_removeGenre.Location = new System.Drawing.Point(379, 229);
            this.button_removeGenre.Name = "button_removeGenre";
            this.button_removeGenre.Size = new System.Drawing.Size(136, 23);
            this.button_removeGenre.TabIndex = 34;
            this.button_removeGenre.Text = "Remove Genre";
            this.button_removeGenre.UseVisualStyleBackColor = true;
            // 
            // text_edition
            // 
            this.text_edition.Location = new System.Drawing.Point(803, 203);
            this.text_edition.Name = "text_edition";
            this.text_edition.Size = new System.Drawing.Size(53, 20);
            this.text_edition.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(800, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Edition";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(217, 271);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(639, 130);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 305);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(199, 96);
            this.richTextBox2.TabIndex = 38;
            this.richTextBox2.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Observations";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Synopsis";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(707, 407);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(149, 23);
            this.button_save.TabIndex = 42;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(552, 407);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(149, 23);
            this.button_cancel.TabIndex = 41;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Pages";
            // 
            // text_pages
            // 
            this.text_pages.Location = new System.Drawing.Point(521, 158);
            this.text_pages.Name = "text_pages";
            this.text_pages.Size = new System.Drawing.Size(47, 20);
            this.text_pages.TabIndex = 44;
            this.text_pages.Text = "9999";
            // 
            // Form_BookInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 440);
            this.Controls.Add(this.text_pages);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_edition);
            this.Controls.Add(this.button_removeGenre);
            this.Controls.Add(this.button_removeAuthor);
            this.Controls.Add(this.listBox_genres);
            this.Controls.Add(this.box_genres);
            this.Controls.Add(this.box_serie);
            this.Controls.Add(this.box_publisher);
            this.Controls.Add(this.box_readingStatus);
            this.Controls.Add(this.box_status);
            this.Controls.Add(this.box_type);
            this.Controls.Add(this.text_coverPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.box_language);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_releaseDate);
            this.Controls.Add(this.box_authors);
            this.Controls.Add(this.listBox_authors);
            this.Controls.Add(this.text_volumes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_isbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_sameAsTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_originalSubTitle);
            this.Controls.Add(this.text_OriginalTitle);
            this.Controls.Add(this.text_sublTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_author);
            this.Name = "Form_BookInsert";
            this.Text = "Form_BookInsert";
            this.Load += new System.EventHandler(this.Form_BookInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_sublTitle;
        private System.Windows.Forms.TextBox text_OriginalTitle;
        private System.Windows.Forms.TextBox text_originalSubTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_sameAsTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_isbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_volumes;
        private System.Windows.Forms.ListBox listBox_authors;
        private System.Windows.Forms.ComboBox box_authors;
        private System.Windows.Forms.MaskedTextBox text_releaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox box_language;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox text_coverPrice;
        private System.Windows.Forms.ComboBox box_type;
        private System.Windows.Forms.ComboBox box_status;
        private System.Windows.Forms.ComboBox box_readingStatus;
        private System.Windows.Forms.ComboBox box_publisher;
        private System.Windows.Forms.ComboBox box_serie;
        private System.Windows.Forms.ComboBox box_genres;
        private System.Windows.Forms.ListBox listBox_genres;
        private System.Windows.Forms.Button button_removeAuthor;
        private System.Windows.Forms.Button button_removeGenre;
        private System.Windows.Forms.TextBox text_edition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_pages;
    }
}