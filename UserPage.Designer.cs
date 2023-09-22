namespace LibraryApplication
{
    partial class UserPage
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(28, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 31);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(275, 31);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(106, 31);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(122, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(134, 30);
            this.txt_search.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.author,
            this.lang,
            this.publisher,
            this.genre,
            this.amount});
            this.dataGridView1.Location = new System.Drawing.Point(24, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 232);
            this.dataGridView1.TabIndex = 2;
            // 
            // bookId
            // 
            this.bookId.HeaderText = "ID";
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
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(28, 363);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 35);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 455);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}