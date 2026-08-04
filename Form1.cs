using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FirstDatabaseApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                MessageBox.Show("Connection successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";

            string query = "INSERT INTO Students (FullName, Gender, DateOfBirth, PhoneNumber, Address) " +
                           "VALUES (@FullName, @Gender, @DateOfBirth, @PhoneNumber, @Address)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Student record saved successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";

            string query = "UPDATE Students SET FullName=@FullName, Gender=@Gender, DateOfBirth=@DateOfBirth, " +
                           "PhoneNumber=@PhoneNumber, Address=@Address WHERE StudentID=@StudentID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Student record updated successfully.");
                        else
                            MessageBox.Show("No matching record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                      "Confirm Delete",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";

            string query = "DELETE FROM Students WHERE StudentID=@StudentID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Student record deleted successfully.");
                        else
                            MessageBox.Show("No matching record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}


