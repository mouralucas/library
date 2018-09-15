namespace Library.Forms_Insert
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
            this.Book_Cover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_SublTitle = new System.Windows.Forms.TextBox();
            this.Text_OriginalTitle = new System.Windows.Forms.TextBox();
            this.Text_OriginalSubTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBox_SameAsTitle = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ListBox_Authors = new System.Windows.Forms.ListBox();
            this.Box_Author = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Box_Language = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Box_Format = new System.Windows.Forms.ComboBox();
            this.Box_Status = new System.Windows.Forms.ComboBox();
            this.Box_ReadingStatus = new System.Windows.Forms.ComboBox();
            this.Box_Publisher = new System.Windows.Forms.ComboBox();
            this.Box_Serie = new System.Windows.Forms.ComboBox();
            this.Box_Genre = new System.Windows.Forms.ComboBox();
            this.ListBox_Genres = new System.Windows.Forms.ListBox();
            this.Button_RemoveAuthor = new System.Windows.Forms.Button();
            this.Button_RemoveGenre = new System.Windows.Forms.Button();
            this.Text_Edition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Text_Synopsis = new System.Windows.Forms.RichTextBox();
            this.Text_Observation = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Text_Pages = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Date_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.Box_Volume = new System.Windows.Forms.ComboBox();
            this.Text_CoverPrice = new System.Windows.Forms.MaskedTextBox();
            this.Text_Isbn = new System.Windows.Forms.MaskedTextBox();
            this.Box_Currency = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Box_Category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_Cover
            // 
            this.Book_Cover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book_Cover.Image = ((System.Drawing.Image)(resources.GetObject("Book_Cover.Image")));
            this.Book_Cover.InitialImage = null;
            this.Book_Cover.Location = new System.Drawing.Point(11, 55);
            this.Book_Cover.Name = "Book_Cover";
            this.Book_Cover.Size = new System.Drawing.Size(200, 270);
            this.Book_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Book_Cover.TabIndex = 2;
            this.Book_Cover.TabStop = false;
            this.Book_Cover.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Book_Cover_MouseClick);
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
            // Text_Title
            // 
            this.Text_Title.Location = new System.Drawing.Point(217, 28);
            this.Text_Title.Name = "Text_Title";
            this.Text_Title.Size = new System.Drawing.Size(250, 20);
            this.Text_Title.TabIndex = 1;
            this.Text_Title.TextChanged += new System.EventHandler(this.Text_Title_TextChanged);
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
            // Text_SublTitle
            // 
            this.Text_SublTitle.Location = new System.Drawing.Point(473, 28);
            this.Text_SublTitle.Name = "Text_SublTitle";
            this.Text_SublTitle.Size = new System.Drawing.Size(250, 20);
            this.Text_SublTitle.TabIndex = 2;
            this.Text_SublTitle.TextChanged += new System.EventHandler(this.Text_SublTitle_TextChanged);
            // 
            // Text_OriginalTitle
            // 
            this.Text_OriginalTitle.Location = new System.Drawing.Point(217, 71);
            this.Text_OriginalTitle.Name = "Text_OriginalTitle";
            this.Text_OriginalTitle.Size = new System.Drawing.Size(250, 20);
            this.Text_OriginalTitle.TabIndex = 4;
            // 
            // Text_OriginalSubTitle
            // 
            this.Text_OriginalSubTitle.Location = new System.Drawing.Point(473, 71);
            this.Text_OriginalSubTitle.Name = "Text_OriginalSubTitle";
            this.Text_OriginalSubTitle.Size = new System.Drawing.Size(250, 20);
            this.Text_OriginalSubTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
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
            // CheckBox_SameAsTitle
            // 
            this.CheckBox_SameAsTitle.AutoSize = true;
            this.CheckBox_SameAsTitle.Location = new System.Drawing.Point(733, 28);
            this.CheckBox_SameAsTitle.Name = "CheckBox_SameAsTitle";
            this.CheckBox_SameAsTitle.Size = new System.Drawing.Size(84, 17);
            this.CheckBox_SameAsTitle.TabIndex = 3;
            this.CheckBox_SameAsTitle.Text = "Original Title";
            this.CheckBox_SameAsTitle.UseVisualStyleBackColor = true;
            this.CheckBox_SameAsTitle.CheckedChanged += new System.EventHandler(this.CheckBox_SameAsTitle_CheckedChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Volume";
            // 
            // ListBox_Authors
            // 
            this.ListBox_Authors.FormattingEnabled = true;
            this.ListBox_Authors.Location = new System.Drawing.Point(217, 142);
            this.ListBox_Authors.Name = "ListBox_Authors";
            this.ListBox_Authors.Size = new System.Drawing.Size(156, 95);
            this.ListBox_Authors.TabIndex = 35;
            // 
            // Box_Author
            // 
            this.Box_Author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Author.FormattingEnabled = true;
            this.Box_Author.Location = new System.Drawing.Point(217, 113);
            this.Box_Author.Name = "Box_Author";
            this.Box_Author.Size = new System.Drawing.Size(156, 21);
            this.Box_Author.TabIndex = 7;
            this.Box_Author.SelectionChangeCommitted += new System.EventHandler(this.Box_Author_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Release Date";
            // 
            // Box_Language
            // 
            this.Box_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Language.FormattingEnabled = true;
            this.Box_Language.Location = new System.Drawing.Point(564, 157);
            this.Box_Language.Name = "Box_Language";
            this.Box_Language.Size = new System.Drawing.Size(109, 21);
            this.Box_Language.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cover Price";
            // 
            // Box_Format
            // 
            this.Box_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Format.FormattingEnabled = true;
            this.Box_Format.Items.AddRange(new object[] {
            "Paperback",
            "Hardcover",
            "e-Book"});
            this.Box_Format.Location = new System.Drawing.Point(521, 202);
            this.Box_Format.Name = "Box_Format";
            this.Box_Format.Size = new System.Drawing.Size(129, 21);
            this.Box_Format.TabIndex = 16;
            // 
            // Box_Status
            // 
            this.Box_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Status.FormattingEnabled = true;
            this.Box_Status.Items.AddRange(new object[] {
            "in Shelf",
            "Wanted",
            "Waiting Deliver",
            "Borrowed"});
            this.Box_Status.Location = new System.Drawing.Point(656, 202);
            this.Box_Status.Name = "Box_Status";
            this.Box_Status.Size = new System.Drawing.Size(167, 21);
            this.Box_Status.TabIndex = 17;
            // 
            // Box_ReadingStatus
            // 
            this.Box_ReadingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_ReadingStatus.FormattingEnabled = true;
            this.Box_ReadingStatus.Items.AddRange(new object[] {
            "Read",
            "Reading",
            "Droped",
            "Eventually"});
            this.Box_ReadingStatus.Location = new System.Drawing.Point(521, 245);
            this.Box_ReadingStatus.Name = "Box_ReadingStatus";
            this.Box_ReadingStatus.Size = new System.Drawing.Size(155, 21);
            this.Box_ReadingStatus.TabIndex = 19;
            // 
            // Box_Publisher
            // 
            this.Box_Publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Publisher.FormattingEnabled = true;
            this.Box_Publisher.Location = new System.Drawing.Point(682, 245);
            this.Box_Publisher.Name = "Box_Publisher";
            this.Box_Publisher.Size = new System.Drawing.Size(200, 21);
            this.Box_Publisher.TabIndex = 20;
            // 
            // Box_Serie
            // 
            this.Box_Serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Serie.FormattingEnabled = true;
            this.Box_Serie.Location = new System.Drawing.Point(521, 113);
            this.Box_Serie.Name = "Box_Serie";
            this.Box_Serie.Size = new System.Drawing.Size(308, 21);
            this.Box_Serie.TabIndex = 9;
            this.Box_Serie.SelectionChangeCommitted += new System.EventHandler(this.Box_Serie_SelectionChangeCommitted);
            // 
            // Box_Genre
            // 
            this.Box_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Genre.FormattingEnabled = true;
            this.Box_Genre.Location = new System.Drawing.Point(379, 113);
            this.Box_Genre.Name = "Box_Genre";
            this.Box_Genre.Size = new System.Drawing.Size(136, 21);
            this.Box_Genre.TabIndex = 8;
            this.Box_Genre.SelectionChangeCommitted += new System.EventHandler(this.Box_Genre_SelectionChangeCommitted);
            // 
            // ListBox_Genres
            // 
            this.ListBox_Genres.FormattingEnabled = true;
            this.ListBox_Genres.Location = new System.Drawing.Point(379, 142);
            this.ListBox_Genres.Name = "ListBox_Genres";
            this.ListBox_Genres.Size = new System.Drawing.Size(136, 95);
            this.ListBox_Genres.TabIndex = 32;
            // 
            // Button_RemoveAuthor
            // 
            this.Button_RemoveAuthor.Location = new System.Drawing.Point(217, 243);
            this.Button_RemoveAuthor.Name = "Button_RemoveAuthor";
            this.Button_RemoveAuthor.Size = new System.Drawing.Size(156, 23);
            this.Button_RemoveAuthor.TabIndex = 33;
            this.Button_RemoveAuthor.Text = "Remove Author";
            this.Button_RemoveAuthor.UseVisualStyleBackColor = true;
            this.Button_RemoveAuthor.Click += new System.EventHandler(this.Button_RemoveAuthor_Click);
            // 
            // Button_RemoveGenre
            // 
            this.Button_RemoveGenre.Location = new System.Drawing.Point(379, 243);
            this.Button_RemoveGenre.Name = "Button_RemoveGenre";
            this.Button_RemoveGenre.Size = new System.Drawing.Size(136, 23);
            this.Button_RemoveGenre.TabIndex = 34;
            this.Button_RemoveGenre.Text = "Remove Genre";
            this.Button_RemoveGenre.UseVisualStyleBackColor = true;
            this.Button_RemoveGenre.Click += new System.EventHandler(this.Button_RemoveGenre_Click);
            // 
            // Text_Edition
            // 
            this.Text_Edition.Location = new System.Drawing.Point(829, 203);
            this.Text_Edition.Name = "Text_Edition";
            this.Text_Edition.Size = new System.Drawing.Size(53, 20);
            this.Text_Edition.TabIndex = 18;
            this.Text_Edition.Text = "1";
            this.Text_Edition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_edition_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(826, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Edition";
            // 
            // Text_Synopsis
            // 
            this.Text_Synopsis.Location = new System.Drawing.Point(217, 289);
            this.Text_Synopsis.Name = "Text_Synopsis";
            this.Text_Synopsis.Size = new System.Drawing.Size(665, 183);
            this.Text_Synopsis.TabIndex = 21;
            this.Text_Synopsis.Text = "";
            // 
            // Text_Observation
            // 
            this.Text_Observation.Location = new System.Drawing.Point(11, 344);
            this.Text_Observation.Name = "Text_Observation";
            this.Text_Observation.Size = new System.Drawing.Size(199, 128);
            this.Text_Observation.TabIndex = 22;
            this.Text_Observation.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Observations";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Synopsis";
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(733, 478);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(149, 23);
            this.Button_Save.TabIndex = 23;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Transaction_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(578, 478);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(149, 23);
            this.Button_Cancel.TabIndex = 41;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
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
            // Text_Pages
            // 
            this.Text_Pages.Location = new System.Drawing.Point(521, 158);
            this.Text_Pages.Name = "Text_Pages";
            this.Text_Pages.Size = new System.Drawing.Size(37, 20);
            this.Text_Pages.TabIndex = 11;
            this.Text_Pages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_pages_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(564, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Language";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(518, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Format";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(653, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(522, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Reading Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(679, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Publisher";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(219, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "Author(s)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(379, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Genres";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(522, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Serie";
            // 
            // Date_ReleaseDate
            // 
            this.Date_ReleaseDate.CustomFormat = "yyyy/MM/dd";
            this.Date_ReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_ReleaseDate.Location = new System.Drawing.Point(679, 157);
            this.Date_ReleaseDate.Name = "Date_ReleaseDate";
            this.Date_ReleaseDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_ReleaseDate.Size = new System.Drawing.Size(83, 20);
            this.Date_ReleaseDate.TabIndex = 13;
            this.Date_ReleaseDate.Value = new System.DateTime(2018, 9, 3, 0, 0, 0, 0);
            // 
            // Box_Volume
            // 
            this.Box_Volume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Volume.FormattingEnabled = true;
            this.Box_Volume.Location = new System.Drawing.Point(835, 113);
            this.Box_Volume.Name = "Box_Volume";
            this.Box_Volume.Size = new System.Drawing.Size(47, 21);
            this.Box_Volume.TabIndex = 10;
            // 
            // Text_CoverPrice
            // 
            this.Text_CoverPrice.Location = new System.Drawing.Point(819, 156);
            this.Text_CoverPrice.Name = "Text_CoverPrice";
            this.Text_CoverPrice.Size = new System.Drawing.Size(63, 20);
            this.Text_CoverPrice.TabIndex = 15;
            // 
            // Text_Isbn
            // 
            this.Text_Isbn.Location = new System.Drawing.Point(733, 71);
            this.Text_Isbn.Mask = "#############";
            this.Text_Isbn.Name = "Text_Isbn";
            this.Text_Isbn.Size = new System.Drawing.Size(149, 20);
            this.Text_Isbn.TabIndex = 6;
            this.Text_Isbn.Enter += new System.EventHandler(this.Text_Isbn_Enter);
            this.Text_Isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_isbn_KeyPress);
            // 
            // Box_Currency
            // 
            this.Box_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Currency.FormattingEnabled = true;
            this.Box_Currency.Items.AddRange(new object[] {
            "R$",
            "$",
            "₤",
            "€",
            "¥"});
            this.Box_Currency.Location = new System.Drawing.Point(768, 156);
            this.Box_Currency.Name = "Box_Currency";
            this.Box_Currency.Size = new System.Drawing.Size(45, 21);
            this.Box_Currency.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 57;
            this.label21.Text = "Category";
            // 
            // Box_Category
            // 
            this.Box_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box_Category.FormattingEnabled = true;
            this.Box_Category.Items.AddRange(new object[] {
            "Book",
            "Manga",
            "Light Novel",
            "HQ"});
            this.Box_Category.Location = new System.Drawing.Point(11, 28);
            this.Box_Category.Name = "Box_Category";
            this.Box_Category.Size = new System.Drawing.Size(200, 21);
            this.Box_Category.TabIndex = 0;
            this.Box_Category.SelectionChangeCommitted += new System.EventHandler(this.Box_Category_SelectionChangeCommitted);
            // 
            // Form_BookInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 507);
            this.Controls.Add(this.Box_Category);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Text_Isbn);
            this.Controls.Add(this.Box_Volume);
            this.Controls.Add(this.Date_ReleaseDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Box_Currency);
            this.Controls.Add(this.Text_Pages);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Text_Observation);
            this.Controls.Add(this.Text_Synopsis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Text_Edition);
            this.Controls.Add(this.Button_RemoveGenre);
            this.Controls.Add(this.Button_RemoveAuthor);
            this.Controls.Add(this.ListBox_Genres);
            this.Controls.Add(this.Box_Genre);
            this.Controls.Add(this.Box_Serie);
            this.Controls.Add(this.Box_Publisher);
            this.Controls.Add(this.Box_ReadingStatus);
            this.Controls.Add(this.Box_Status);
            this.Controls.Add(this.Box_Format);
            this.Controls.Add(this.Text_CoverPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Box_Language);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Box_Author);
            this.Controls.Add(this.ListBox_Authors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckBox_SameAsTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_OriginalSubTitle);
            this.Controls.Add(this.Text_OriginalTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Book_Cover);
            this.Controls.Add(this.Text_SublTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_BookInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BookInsert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_BookInsert_FormClosing);
            this.Load += new System.EventHandler(this.Form_BookInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_Cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Book_Cover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_SublTitle;
        private System.Windows.Forms.TextBox Text_OriginalTitle;
        private System.Windows.Forms.TextBox Text_OriginalSubTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBox_SameAsTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListBox_Authors;
        private System.Windows.Forms.ComboBox Box_Author;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Box_Language;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Box_Format;
        private System.Windows.Forms.ComboBox Box_Status;
        private System.Windows.Forms.ComboBox Box_ReadingStatus;
        private System.Windows.Forms.ComboBox Box_Publisher;
        private System.Windows.Forms.ComboBox Box_Serie;
        private System.Windows.Forms.ComboBox Box_Genre;
        private System.Windows.Forms.ListBox ListBox_Genres;
        private System.Windows.Forms.Button Button_RemoveAuthor;
        private System.Windows.Forms.Button Button_RemoveGenre;
        private System.Windows.Forms.TextBox Text_Edition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Text_Synopsis;
        private System.Windows.Forms.RichTextBox Text_Observation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Text_Pages;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker Date_ReleaseDate;
        private System.Windows.Forms.ComboBox Box_Volume;
        private System.Windows.Forms.MaskedTextBox Text_CoverPrice;
        private System.Windows.Forms.MaskedTextBox Text_Isbn;
        public System.Windows.Forms.ComboBox Box_Currency;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox Box_Category;
    }
}