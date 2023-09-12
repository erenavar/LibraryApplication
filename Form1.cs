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
                    AdminPage adminPage = new AdminPage(People);
                    adminPage.Show();
                    this.Hide();
                    control = true;

                } else if (username == item.getName() && password == item.getPassword() && item.getAuthority() == "user")
                {
                    UserPage userPage = new UserPage();
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
