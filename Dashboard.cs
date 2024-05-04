using System.Data.SqlClient;
using System.Data;

namespace assignment
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=EMDADULHAQUETAL;Initial Catalog=sampleDb;User ID=sa;Password=admin123");
        public int id;
        // SqlConection con = new SqlConection("");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // GetRecord();
            try
            {
                GetRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetRecord()
        {


            /* SqlCommand cmd = new SqlCommand("SELECT * FROM Dashboard", con);
             DataTable dataTable = new DataTable();

             con.Open();

             SqlDataReader dr = cmd.ExecuteReader();
             dataTable.Load(dr);
             con.Close();
             dataGridView.DataSource = dataTable; */

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dashboard", con);
                DataTable dataTable = new DataTable();

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dataTable.Load(dr);
                con.Close();

                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void dashboard_insert_Click(object sender, EventArgs e)
        {
            /* if (Isvalid())
             {
                 try {
                     SqlCommand cmd = new SqlCommand("INSERT INTO Dashboard VALUES(@ID,@Name,@Email,@address,@phoneNummber)");
                     cmd.CommandType = CommandType.Text;
                     cmd.Parameters.AddWithValue("@ID", dashboard_id.Text);
                     cmd.Parameters.AddWithValue("@Name", dashboard_name.Text);
                     cmd.Parameters.AddWithValue("@Email", dashboard_email.Text);
                     cmd.Parameters.AddWithValue("@address", dashboard_address.Text);
                     cmd.Parameters.AddWithValue("@phoneNumber", dashboard_number.Text);

                     con.Open();
                     cmd.BeginExecuteNonQuery();
                     //cmd.ExecuteNonQuery();
                     con.Close();

                     MessageBox.Show("Insert Successfully in the database!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     GetRecord();
                     ResetFormControls();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
            } */
            try
            {
                if (Isvalid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Dashboard VALUES(@ID,@Name,@Email,@address,@phoneNumber)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", dashboard_id.Text);
                    cmd.Parameters.AddWithValue("@Name", dashboard_name.Text);
                    cmd.Parameters.AddWithValue("@Email", dashboard_email.Text);
                    cmd.Parameters.AddWithValue("@address", dashboard_address.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", dashboard_number.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Inserted Successfully in the database!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetRecord();
                    ResetFormControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }



        }

    private bool Isvalid()
        {
            if (dashboard_name.Text == string.Empty)
            {

                MessageBox.Show("Name is required!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void dashboard_reset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
             id = 0; 
            dashboard_id.Clear();
            dashboard_name.Clear();
            dashboard_email.Clear();
            dashboard_number.Clear();
            dashboard_address.Clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

            dashboard_name.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

            dashboard_email.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            dashboard_address.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            dashboard_number.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dashboard_update_Click(object sender, EventArgs e)
        {
            /*
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE  Dashboard SET(ID = @ID,NAME = @Name,EMAIL = @Email,address = @address,phoneNumber = @phoneNummber WHERE ID = @ID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", dashboard_id.Text);
                cmd.Parameters.AddWithValue("@Name", dashboard_name.Text);
                cmd.Parameters.AddWithValue("@Email", dashboard_email.Text);
                cmd.Parameters.AddWithValue("@address", dashboard_address.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", dashboard_number.Text);
                cmd.Parameters.AddWithValue("@ID", this.id);

                con.Open();
                cmd.BeginExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated Successfully in the database!", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRecord();
                ResetFormControls();



            }
            else
            {
                MessageBox.Show("Please Select an id to update information", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } */
            try
            {
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Dashboard SET Name = @Name, Email = @Email, address = @address, phoneNumber = @phoneNumber WHERE ID = @ID", con);
                    cmd.CommandType = CommandType.Text;
                   // cmd.Parameters.AddWithValue("@ID", dashboard_id.Text);
                    cmd.Parameters.AddWithValue("@Name", dashboard_name.Text);
                    cmd.Parameters.AddWithValue("@Email", dashboard_email.Text);
                    cmd.Parameters.AddWithValue("@address", dashboard_address.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", dashboard_number.Text);
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Updated Successfully in the database!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetRecord();
                    ResetFormControls();
                }
                else
                {
                    MessageBox.Show("Please Select an ID to update information", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure connection is closed even if an exception occurs
            }
        }

        private void dashboard_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Dashboard WHERE ID = @ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Deleted from the system!", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetRecord();
                    ResetFormControls();
                }
                else
                {
                    MessageBox.Show("Please Select an information to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure connection is closed even if an exception occurs
            }
        }
    }
}
