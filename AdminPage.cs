using LibraryApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class AdminPage : Form
    {
        List<Person> People;
        List<Book> Books;
        public AdminPage(List<Person> people,List<Book> books)
        {
            InitializeComponent();
            this.People = people;
            this.Books = books;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_surname.Text = string.Empty;
            masked_creation_time.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_authority.Text = string.Empty;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            foreach (Person item in People)
            {
                dataGridView1.Rows.Add(item.getId(), item.getName(), item.getSurname(), item.getCreationTime()
                    , item.getUsername(), item.getPassword(), item.getAuthority());
            }

            foreach (Book item in Books)
            {
                dataGridView2.Rows.Add(item.getBookId(), item.getBookName(), item.getWriter(), item.getLang(), item.getPublisher()
                                       , item.getGenre(), item.getAmonut());
                
            }


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_surname.Text, masked_creation_time.Text
                                   , txt_username.Text, txt_password.Text, txt_authority.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void FillText()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            masked_creation_time.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_username.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_password.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_authority.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillText();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string id = txt_id.Text;
            string surname = txt_surname.Text;
            string creation_time = masked_creation_time.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string authority = txt_authority.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, name, surname, creation_time, username, password, authority);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_book_id.Text, txt_book_name.Text, txt_writer.Text, txt_lang.Text, txt_publisher.Text
                                   ,txt_genre.Text,txt_amount.Text);
        }

        private void btn_update_book_Click(object sender, EventArgs e)
        {
            string bookId = txt_book_id.Text;
            string bookName = txt_book_name.Text;
            string writer = txt_writer.Text;
            string language = txt_lang.Text;
            string publisher = txt_publisher.Text;
            string genre = txt_genre.Text;
            string amount = txt_amount.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(bookId,bookName,writer,language,publisher,genre,amount);


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_delete_book_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_book_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_book_name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_writer.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_lang.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_publisher.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_genre.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_amount.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_book_clear_Click(object sender, EventArgs e)
        {
            txt_book_id.Text = string.Empty;
            txt_book_name.Text = string.Empty;
            txt_writer.Text = string.Empty;
            txt_lang.Text = string.Empty;
            txt_publisher.Text = string.Empty;
            txt_genre.Text = string.Empty;
            txt_amount.Text = string.Empty;
        }

        private void btn_user_page_exit_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
        }
    }
}
