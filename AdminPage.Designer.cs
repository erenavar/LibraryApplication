namespace LibraryApplication
{
    partial class AdminPage
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_authority = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_authority = new System.Windows.Forms.TextBox();
            this.masked_creation_time = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_delete_book = new System.Windows.Forms.Button();
            this.btn_book_clear = new System.Windows.Forms.Button();
            this.btn_update_book = new System.Windows.Forms.Button();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.lbl_lang = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.lbl_writer = new System.Windows.Forms.Label();
            this.txt_writer = new System.Windows.Forms.TextBox();
            this.txt_book_id = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_book_id = new System.Windows.Forms.Label();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_lang = new System.Windows.Forms.TextBox();
            this.btn_user_page_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(20, 316);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 30);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(158, 313);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(325, 37);
            this.txt_id.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(20, 371);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 30);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(158, 368);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(325, 37);
            this.txt_name.TabIndex = 1;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.Location = new System.Drawing.Point(158, 417);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(325, 37);
            this.txt_surname.TabIndex = 2;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(19, 423);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(124, 30);
            this.lbl_surname.TabIndex = 0;
            this.lbl_surname.Text = "Surname:";
            // 
            // lbl_creation_date
            // 
            this.lbl_creation_date.AutoSize = true;
            this.lbl_creation_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creation_date.Location = new System.Drawing.Point(509, 316);
            this.lbl_creation_date.Name = "lbl_creation_date";
            this.lbl_creation_date.Size = new System.Drawing.Size(178, 30);
            this.lbl_creation_date.TabIndex = 0;
            this.lbl_creation_date.Text = "Creation Date:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(19, 479);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(133, 30);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(158, 472);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(325, 37);
            this.txt_password.TabIndex = 5;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(509, 371);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(139, 30);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_authority
            // 
            this.lbl_authority.AutoSize = true;
            this.lbl_authority.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_authority.Location = new System.Drawing.Point(509, 423);
            this.lbl_authority.Name = "lbl_authority";
            this.lbl_authority.Size = new System.Drawing.Size(121, 30);
            this.lbl_authority.TabIndex = 0;
            this.lbl_authority.Text = "Authority:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(693, 371);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(325, 37);
            this.txt_username.TabIndex = 4;
            // 
            // txt_authority
            // 
            this.txt_authority.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_authority.Location = new System.Drawing.Point(693, 420);
            this.txt_authority.Name = "txt_authority";
            this.txt_authority.Size = new System.Drawing.Size(325, 37);
            this.txt_authority.TabIndex = 6;
            // 
            // masked_creation_time
            // 
            this.masked_creation_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_creation_time.Location = new System.Drawing.Point(693, 316);
            this.masked_creation_time.Mask = "00/00/0000 90:00:00";
            this.masked_creation_time.Name = "masked_creation_time";
            this.masked_creation_time.Size = new System.Drawing.Size(325, 37);
            this.masked_creation_time.TabIndex = 3;
            this.masked_creation_time.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.masked_creation_time);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.txt_authority);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_surname);
            this.groupBox1.Controls.Add(this.lbl_surname);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.lbl_authority);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.lbl_creation_date);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 838);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Operaitons";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(0, 743);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(1018, 52);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(0, 670);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(1018, 52);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.creation_time,
            this.username,
            this.password,
            this.authority});
            this.dataGridView1.Location = new System.Drawing.Point(24, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 266);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 8;
            this.surname.Name = "surname";
            this.surname.Width = 150;
            // 
            // creation_time
            // 
            this.creation_time.HeaderText = "Creation Time";
            this.creation_time.MinimumWidth = 8;
            this.creation_time.Name = "creation_time";
            this.creation_time.Width = 150;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.Width = 150;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.Width = 150;
            // 
            // authority
            // 
            this.authority.HeaderText = "Writer";
            this.authority.MinimumWidth = 8;
            this.authority.Name = "authority";
            this.authority.Width = 150;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(0, 597);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(1018, 52);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(0, 528);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(1018, 52);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "People";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.author,
            this.lang,
            this.publisher,
            this.genre,
            this.amount});
            this.dataGridView2.Location = new System.Drawing.Point(1060, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1000, 266);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // bookId
            // 
            this.bookId.HeaderText = "Id";
            this.bookId.MinimumWidth = 8;
            this.bookId.Name = "bookId";
            this.bookId.Width = 50;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Book Name";
            this.bookName.MinimumWidth = 8;
            this.bookName.Name = "bookName";
            this.bookName.Width = 150;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.Width = 150;
            // 
            // lang
            // 
            this.lang.HeaderText = "Language";
            this.lang.MinimumWidth = 8;
            this.lang.Name = "lang";
            this.lang.Width = 150;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Publisher";
            this.publisher.MinimumWidth = 8;
            this.publisher.Name = "publisher";
            this.publisher.Width = 150;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 8;
            this.genre.Name = "genre";
            this.genre.Width = 150;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 8;
            this.amount.Name = "amount";
            this.amount.Width = 150;
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(1060, 575);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(994, 52);
            this.btn_add_book.TabIndex = 7;
            this.btn_add_book.Text = "Add";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_delete_book
            // 
            this.btn_delete_book.Location = new System.Drawing.Point(1060, 644);
            this.btn_delete_book.Name = "btn_delete_book";
            this.btn_delete_book.Size = new System.Drawing.Size(994, 52);
            this.btn_delete_book.TabIndex = 8;
            this.btn_delete_book.Text = "Delete";
            this.btn_delete_book.UseVisualStyleBackColor = true;
            this.btn_delete_book.Click += new System.EventHandler(this.btn_delete_book_Click);
            // 
            // btn_book_clear
            // 
            this.btn_book_clear.Location = new System.Drawing.Point(1060, 717);
            this.btn_book_clear.Name = "btn_book_clear";
            this.btn_book_clear.Size = new System.Drawing.Size(994, 52);
            this.btn_book_clear.TabIndex = 9;
            this.btn_book_clear.Text = "Clear";
            this.btn_book_clear.UseVisualStyleBackColor = true;
            this.btn_book_clear.Click += new System.EventHandler(this.btn_book_clear_Click);
            // 
            // btn_update_book
            // 
            this.btn_update_book.Location = new System.Drawing.Point(1061, 790);
            this.btn_update_book.Name = "btn_update_book";
            this.btn_update_book.Size = new System.Drawing.Size(994, 52);
            this.btn_update_book.TabIndex = 10;
            this.btn_update_book.Text = "Update";
            this.btn_update_book.UseVisualStyleBackColor = true;
            this.btn_update_book.Click += new System.EventHandler(this.btn_update_book_Click);
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publisher.Location = new System.Drawing.Point(1055, 526);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(120, 30);
            this.lbl_publisher.TabIndex = 0;
            this.lbl_publisher.Text = "Publisher";
            // 
            // lbl_lang
            // 
            this.lbl_lang.AutoSize = true;
            this.lbl_lang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lang.Location = new System.Drawing.Point(1577, 421);
            this.lbl_lang.Name = "lbl_lang";
            this.lbl_lang.Size = new System.Drawing.Size(132, 30);
            this.lbl_lang.TabIndex = 0;
            this.lbl_lang.Text = "Language:";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.Location = new System.Drawing.Point(1055, 418);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(154, 30);
            this.lbl_book_name.TabIndex = 0;
            this.lbl_book_name.Text = "Book Name:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(1577, 471);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(101, 30);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            // 
            // txt_genre
            // 
            this.txt_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genre.Location = new System.Drawing.Point(1735, 363);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(325, 37);
            this.txt_genre.TabIndex = 5;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre.Location = new System.Drawing.Point(1577, 366);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(91, 30);
            this.lbl_genre.TabIndex = 0;
            this.lbl_genre.Text = "Genre:";
            // 
            // txt_publisher
            // 
            this.txt_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_publisher.Location = new System.Drawing.Point(1230, 519);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(325, 37);
            this.txt_publisher.TabIndex = 4;
            // 
            // lbl_writer
            // 
            this.lbl_writer.AutoSize = true;
            this.lbl_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_writer.Location = new System.Drawing.Point(1055, 471);
            this.lbl_writer.Name = "lbl_writer";
            this.lbl_writer.Size = new System.Drawing.Size(90, 30);
            this.lbl_writer.TabIndex = 0;
            this.lbl_writer.Text = "Writer:";
            // 
            // txt_writer
            // 
            this.txt_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_writer.Location = new System.Drawing.Point(1230, 467);
            this.txt_writer.Name = "txt_writer";
            this.txt_writer.Size = new System.Drawing.Size(325, 37);
            this.txt_writer.TabIndex = 2;
            // 
            // txt_book_id
            // 
            this.txt_book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book_id.Location = new System.Drawing.Point(1230, 360);
            this.txt_book_id.Name = "txt_book_id";
            this.txt_book_id.Size = new System.Drawing.Size(325, 37);
            this.txt_book_id.TabIndex = 0;
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(1735, 468);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(325, 37);
            this.txt_amount.TabIndex = 6;
            // 
            // lbl_book_id
            // 
            this.lbl_book_id.AutoSize = true;
            this.lbl_book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id.Location = new System.Drawing.Point(1055, 363);
            this.lbl_book_id.Name = "lbl_book_id";
            this.lbl_book_id.Size = new System.Drawing.Size(40, 30);
            this.lbl_book_id.TabIndex = 0;
            this.lbl_book_id.Text = "Id:";
            // 
            // txt_book_name
            // 
            this.txt_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book_name.Location = new System.Drawing.Point(1230, 415);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(325, 37);
            this.txt_book_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1510, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 35);
            this.label9.TabIndex = 5;
            this.label9.Text = "Books";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_lang
            // 
            this.txt_lang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lang.Location = new System.Drawing.Point(1735, 418);
            this.txt_lang.Name = "txt_lang";
            this.txt_lang.Size = new System.Drawing.Size(325, 37);
            this.txt_lang.TabIndex = 6;
            // 
            // btn_user_page_exit
            // 
            this.btn_user_page_exit.Location = new System.Drawing.Point(1898, 881);
            this.btn_user_page_exit.Name = "btn_user_page_exit";
            this.btn_user_page_exit.Size = new System.Drawing.Size(157, 63);
            this.btn_user_page_exit.TabIndex = 11;
            this.btn_user_page_exit.Text = "EXIT";
            this.btn_user_page_exit.UseVisualStyleBackColor = true;
            this.btn_user_page_exit.Click += new System.EventHandler(this.btn_user_page_exit_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2152, 956);
            this.Controls.Add(this.btn_user_page_exit);
            this.Controls.Add(this.btn_update_book);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_book_clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_book_name);
            this.Controls.Add(this.btn_delete_book);
            this.Controls.Add(this.txt_lang);
            this.Controls.Add(this.lbl_book_id);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_publisher);
            this.Controls.Add(this.txt_book_id);
            this.Controls.Add(this.lbl_lang);
            this.Controls.Add(this.txt_writer);
            this.Controls.Add(this.lbl_book_name);
            this.Controls.Add(this.lbl_writer);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.lbl_genre);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_creation_date;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_authority;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_authority;
        private System.Windows.Forms.MaskedTextBox masked_creation_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_delete_book;
        private System.Windows.Forms.Button btn_book_clear;
        private System.Windows.Forms.Button btn_update_book;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.Label lbl_lang;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.Label lbl_writer;
        private System.Windows.Forms.TextBox txt_writer;
        private System.Windows.Forms.TextBox txt_book_id;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_book_id;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority;
        private System.Windows.Forms.TextBox txt_lang;
        private System.Windows.Forms.Button btn_user_page_exit;
    }
}