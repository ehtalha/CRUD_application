using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace assignment
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=EMDADULHAQUETAL;Initial Catalog=sampleDb;Persist Security Info=True;User ID=sa;Password=admin123");

        private void singup_Click(object sender, EventArgs e)
        {
            try
            {

                if (singup_email.Text != "" && singup_username.Text != "" && singup_password.Text != "" &&
                    singup_conpassword.Text != "")
                {


                    if (singup_password.Text == singup_conpassword.Text)
                    {
                        int v = check(singup_email.Text);
                        if (v != 1)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO registration VALUES(@UserName,@Password," +
                                                            "@Email)", con);
                            cmd.Parameters.AddWithValue("@UserName", singup_username.Text);
                            cmd.Parameters.AddWithValue("@Password", singup_password.Text);
                            cmd.Parameters.AddWithValue("@Email", singup_email.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Register successfully!");

                            singup_email.Text = "";
                            singup_username.Text = "";
                            singup_password.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("you are already registerd!");

                        }


                    }
                    else
                    {

                        MessageBox.Show("Password does not match");

                    }

                }

                else
                {
                    MessageBox.Show("Name,email should not be blank");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string email)
        {
            con.Open();
            string query = "SELECT COUNT(*) FROM registration WHERE email = '" + email + " ' ";
            SqlCommand cmd = new SqlCommand(query, con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();
            return v;


        }

        private void singup_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (singup_checkBox.Checked)
            {
                singup_password.UseSystemPasswordChar = false;
                singup_conpassword.UseSystemPasswordChar = false;
            }
            else
            {
                singup_password.UseSystemPasswordChar = true;
                singup_conpassword.UseSystemPasswordChar = true;

            }
        }

        private void singup_login_Click(object sender, EventArgs e)
        {
            Form1 lform = new Form1();
            lform.Show();//it will show the Log in form
            this.Hide();
        }
    }
}
