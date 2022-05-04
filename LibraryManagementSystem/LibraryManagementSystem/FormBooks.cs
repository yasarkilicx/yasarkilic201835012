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
    public partial class FormBooks : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5IEA6I3;Initial Catalog=yk201835012;Integrated Security=True");

        public FormBooks()
        {
            InitializeComponent();
        }


        private void showData()
        {
            try
            {

                string q = "SELECT * FROM TableBooks";



                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewBooks.DataSource = dt;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);

            }

        }


        private void FormBooks_Load(object sender, EventArgs e)
        {
            showData();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                connection.Open();
                SqlCommand sqlKomut = new SqlCommand("UPDATE TableBooks SET BookName = @P1, AuthorName=@P2, AuthorSurname=@P3, ISBN=@P4, BookTypeCode=@P5 WHERE ID = @P6", connection);

                sqlKomut.Parameters.AddWithValue("@P1", textBoxBookName.Text);
                sqlKomut.Parameters.AddWithValue("@P2", textBoxAuthorName.Text);
                sqlKomut.Parameters.AddWithValue("@P3", textBoxAuthorSurname.Text);
                sqlKomut.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlKomut.Parameters.AddWithValue("@P5", textBoxBookTypeCode.Text);
                sqlKomut.Parameters.AddWithValue("@P6", labelID.Text);

                sqlKomut.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while updating book !" + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            showData();

        }

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                SqlCommand sqlKomut = new SqlCommand("INSERT INTO TableBooks " +
                    "(BookName, AuthorName, AuthorSurname, ISBN, Status, BookTypeCode) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", connection);

                sqlKomut.Parameters.AddWithValue("@P1", textBoxBookName.Text);
                sqlKomut.Parameters.AddWithValue("@P2", textBoxAuthorName.Text);
                sqlKomut.Parameters.AddWithValue("@P3", textBoxAuthorSurname.Text);
                sqlKomut.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlKomut.Parameters.AddWithValue("@P5", "True");
                sqlKomut.Parameters.AddWithValue("@P6", textBoxBookTypeCode.Text);

                sqlKomut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding book !" + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            showData();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            labelReturnFee.Text = "0";
            int selectedLine = dataGridViewBooks.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewBooks.Rows[selectedLine].Cells[0].Value.ToString();
            textBoxBookName.Text = dataGridViewBooks.Rows[selectedLine].Cells[1].Value.ToString();
            textBoxAuthorName.Text = dataGridViewBooks.Rows[selectedLine].Cells[2].Value.ToString();
            textBoxAuthorSurname.Text = dataGridViewBooks.Rows[selectedLine].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewBooks.Rows[selectedLine].Cells[4].Value.ToString();
            textBoxBookTypeCode.Text = dataGridViewBooks.Rows[selectedLine].Cells[8].Value.ToString();



            textBoxBorrower.Text = dataGridViewBooks.Rows[selectedLine].Cells[6].Value.ToString();
            if (dataGridViewBooks.Rows[selectedLine].Cells[7].Value != DBNull.Value) 
            dateTimePickerBorrowDate.Value = (DateTime) dataGridViewBooks.Rows[selectedLine].Cells[7].Value;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBookBorrowtheBook_Click(object sender, EventArgs e)
        {
            if(labelID.Text != "-")
            {
                try
                {


                    connection.Open();
                    SqlCommand sqlKomut = new SqlCommand("UPDATE TableBooks SET Borrower = @P1, BorrowingDate=@P2, Status=@P3 WHERE ID = @P4", connection);
                    sqlKomut.Parameters.AddWithValue("@P1", textBoxBorrower.Text);
                    sqlKomut.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerBorrowDate.Value.Date;
                    sqlKomut.Parameters.AddWithValue("@P3", "False");
                    sqlKomut.Parameters.AddWithValue("@P4", labelID.Text);


                    sqlKomut.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while borrowing book !" + ex.Message);

                }
                finally
                {
                    connection.Close();
                }

                showData();

            }
            else
            {
                MessageBox.Show("please choose a book !");
            }
        }

        private void buttonButtonDelayFeeCalculate_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime todayDate = DateTime.Now;
                int dayDifference = (int) (todayDate - dateTimePickerBorrowDate.Value.Date).TotalDays;
                if (dayDifference > 10)
                {
                    int delayPrice = (dayDifference - 10) * 1;
                    labelReturnFee.Text = delayPrice.ToString();
                }
                
            }

        }

        private void buttonReturnTheBook_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {


                    connection.Open();
                    SqlCommand sqlKomut = new SqlCommand("UPDATE TableBooks SET Borrower = @P1, BorrowingDate=@P2, Status=@P3 WHERE ID = @P4", connection);
                    
                    
                    sqlKomut.Parameters.AddWithValue("@P1", "");
                    sqlKomut.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlKomut.Parameters.AddWithValue("@P3", "False");
                    sqlKomut.Parameters.AddWithValue("@P4", labelID.Text);


                    sqlKomut.ExecuteNonQuery();
                    textBoxBorrower.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while returning book !" + ex.Message);

                }
                finally
                {
                    connection.Close();
                }

                showData();
            }

        }

        private void textBoxBorrower_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelID.Text = "-";
            textBoxBookName.Text = "";
            textBoxAuthorName.Text = "";
            textBoxAuthorSurname.Text = "";
            textBoxISBN.Text = "";
            textBoxBookTypeCode.Text = "";
            textBoxBorrower.Text = ""; 
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchResultShow();

        }

        private void searchResultShow()
        {
            try
            {






                

                string q = "Select * FROM TableBooks WHERE BookName LIKE '" + textBoxBookName.Text
                                                                  + "%' AND AuthorName LIKE '" + textBoxAuthorName.Text + "%' "
                                                                  + " AND AuthorSurname LIKE '" + textBoxAuthorSurname.Text + "%' "
                                                                  + " AND ISBN LIKE '" + textBoxISBN.Text + "%' "
                                                                  + " AND BookTypeCode LIKE '" + textBoxBookTypeCode.Text + "%' "
                                                                  + " AND Borrower LIKE '" + textBoxBorrower.Text + "%' ";


                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewBooks.DataSource = dt;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);

            }

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void buttonBookDelete_Click(object sender, EventArgs e)
        {

            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("please select the book to be deleted from the list !");
            }
            else
            {

            

            try
            {
                connection.Open();

                SqlCommand sqlKomut = new SqlCommand("DELETE FROM TableBooks WHERE ID = @P1", connection);


                sqlKomut.Parameters.AddWithValue("@P1", labelID.Text);

                sqlKomut.ExecuteNonQuery();

                    labelID.Text = "-";
                    textBoxBookName.Text = "";
                    textBoxAuthorName.Text = "";
                    textBoxAuthorSurname.Text = "";
                    textBoxISBN.Text = "";
                    textBoxBookTypeCode.Text = "";
                    textBoxBorrower.Text = "";
                }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the book. !" + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            showData();
            
          }



        }

        private void FormBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
