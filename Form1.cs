using LibraryApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class Form1 : Form
    {
        List<Person> People = new List<Person>();
        List<Book> Books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            People.Add(new Person(1, "Eren", "AVAR", DateTime.Now, "eren", "1", "admin"));
            People.Add(new Person(2, "Phoebe", "BUFFAY", DateTime.Now, "phoebe", "1", "user"));
            People.Add(new Person(3, "Joey", "TRIBBIANI", DateTime.Now, "joey", "1", "user"));
            People.Add(new Person(4, "Robin", "SCHERBATSKY", DateTime.Now, "robin", "1", "user"));
            People.Add(new Person(5, "Chandler", "BING", DateTime.Now, "chandler", "1", "admin"));

            Books.Add(new Book(1, "İçimizdeki Şeytan", "Sabahattin Ali", "Turkish", "YKY", "Novel",100));
            Books.Add(new Book(2, "Tutunamayanlar", "Oğuz Atay", "Turkish", "Iletisim", "Novel", 200));
            Books.Add(new Book(3, "Uçurtma Avcısı", "Khaled Hosseini", "Turkish", "Everest", "Nove", 240));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            bool control = false;
            foreach (Person item in People)
            {
               
                if (username.ToLower() == item.getName().ToLower() && password == item.getPassword() && item.getAuthority() == "admin")
                {
                    AdminPage adminPage = new AdminPage(People,Books);
                    adminPage.Show();
                    this.Hide();
                    control = true;

                } else if (username.ToLower() == item.getName().ToLower() && password == item.getPassword() && item.getAuthority() == "user")
                {
                    UserPage userPage = new UserPage(Books);
                    userPage.Show();
                    this.Hide();
                    control = true;
                }

              
            }
            if (!control)
            {
                MessageBox.Show("There is something error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control = true;
            }
        }
    }
}
