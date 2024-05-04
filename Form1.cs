using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=EMDADULHAQUETAL;Initial Catalog=sampleDb;Persist Security Info=True;User ID=sa;Password=admin123");

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_username.Text != "" && text_password.Text != "")
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM registration WHERE UserName = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", text_username.Text);
                    cmd.Parameters.AddWithValue("@Password", text_password.Text);
                    int count = (int)cmd.ExecuteScalar(); // Executes the query and returns the first column of the first row in the result set
                    if (count > 0) // If count is greater than 0, it means a matching username and password was found
                    {
                        MessageBox.Show("Login Successful!");
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error!"); // Show error message for invalid credentials
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close(); // Close connection after using it
                }
            }
            else
            {
                MessageBox.Show("User Name or password Should not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        // if (text_username.Text != "" && text_password.Text != "")
        //{
        /* string query = "SELECT COUNT(*) FROM registration WHERE UserName = '" + text_username.Text + "' and " +
                         "Password='" + text_password.Text + "'";
         con.Open();
         SqlCommand cmd = new SqlCommand(query, con);
         int v = (int)cmd.ExecuteNonQuery();
         if (v != 1)
         {
             MessageBox.Show("Invalid Username or Password", "Error!");

         }

         else
         {
             Dashboard dashboard = new Dashboard();
             dashboard.Show();
             text_password.Text = "";
             text_username.Text = "";
             this.Hide();

         } */

        /*   if(con.State != ConnectionState.Open)
           {
               try
               {
                   con.Open();
                   string query = "SELECT COUNT(*) FROM registration WHERE Username = @Username AND Password = @Password";

               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }

               finally
               {
                   con.Close();
               }
           }
       }
       else
       {
           MessageBox.Show("User Name or password Should not empty"+ MessageBoxButtons.OK+MessageBoxIcon.Error);
       }
   }*/

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (login_checkBox.Checked)
            {
                text_password.UseSystemPasswordChar = false;
            }

            else
            {
                text_password.UseSystemPasswordChar = true;
            }
        }

        private void login_singup_Click(object sender, EventArgs e)
        {
            Registration rfrom = new Registration();
            rfrom.Show();
            this.Hide();
        }
    }
}
