using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FormLogin : Form
    {
        FormBooks formBooks;

        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5IEA6I3;Initial Catalog=yk201835012;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string password ="";
            try
            {
                connection.Open();
                SqlCommand sqlcommand = new SqlCommand("SELECT Password FROM TableLibraryAdmins WHERE UserName = @p1", connection);
                sqlcommand.Parameters.AddWithValue("@p1", textBoxUserName.Text);
                SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    password = sqlDataReader[0].ToString();

                }
                //label3.Text = password;

                if (password == textBoxPassword.Text)
                {
                    
                    formBooks = new FormBooks();
                    this.Hide();
                    formBooks.Show();

                }
                else
                {
                    MessageBox.Show("Username or Password wrong !");
                    textBoxUserName.Text = "";
                    textBoxPassword.Text = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Error! " + ex.Message);
            }

            finally
            {
                connection.Close();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
