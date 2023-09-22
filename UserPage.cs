using LibraryApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class UserPage : Form
    {
        List<Book> Books = new List<Book>();
        public UserPage(List<Book> book)
        {
            InitializeComponent();
            this.Books = book;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            foreach (Book item in Books)
            {
                dataGridView1.Rows.Add(item.getBookId(), item.getBookName(), item.getWriter(), item.getLang(), item.getPublisher()
                                       , item.getGenre(), item.getAmonut());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(txt_search.Text);
            Book targetBook = null;

            foreach (Book item in Books)
            {
                if(item.getBookId() == bookId)
                {
                    targetBook = item;

                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(targetBook.getBookId(), targetBook.getBookName(), targetBook.getWriter(), targetBook.getLang(), targetBook.getPublisher()
                       , targetBook.getGenre(), targetBook.getAmonut());



        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Book item in Books)
            {
                dataGridView1.Rows.Add(item.getBookId(), item.getBookName(), item.getWriter(), item.getLang(), item.getPublisher()
                                       , item.getGenre(), item.getAmonut());
            }

        }
    }
}
