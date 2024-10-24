using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "Data Source=DESKTOP-B8AO3PN;Initial Catalog=form;Integrated Security=True";

            // User input
            string f_name = textBox1.Text;
            string N_name = textBox2.Text;

            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                string query = "INSERT INTO persons (PersonID, LastName, FirstName, Address, City) VALUES (@PersonID, @LastName, @FirstName, @Address, @City)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@PersonID", 10); // Ideally, this should be dynamically generated
                    cmd.Parameters.AddWithValue("@LastName", N_name);
                    cmd.Parameters.AddWithValue("@FirstName", f_name);
                    cmd.Parameters.AddWithValue("@Address", N_name);
                    cmd.Parameters.AddWithValue("@City", N_name);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your data has been saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connect = "Data Source=DESKTOP-B8AO3PN;Initial Catalog=form;Integrated Security=True";
            string delete = textBox3.Text;

            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                string query = "DELETE FROM persons WHERE FirstName = '" + delete+"'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LastName", delete);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Email is deleted");
                        }
                        else
                        {
                            MessageBox.Show("Email is not confirmed");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
