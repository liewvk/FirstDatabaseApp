using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FirstDatabaseApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManagementDB;Integrated Security=True;TrustServerCertificate=True";
        private void LoadStudentsToGrid()
        {
            string query = "SELECT * FROM Students";

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "Students");
                    dgvStudents.DataSource = ds.Tables["Students"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void LoadStudents()
        {
            string query = "SELECT StudentID, FullName, Gender, DateOfBirth, PhoneNumber, Address FROM Students";

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dgvStudents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student records: " + ex.Message);
            }
        }
        private void SaveStudent()
        {
            string query = "INSERT INTO Students (FullName, Gender, DateOfBirth, PhoneNumber, Address) " +
                           "VALUES (@FullName, @Gender, @DateOfBirth, @PhoneNumber, @Address)";

            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void ClearFields()
        {
            txtFullName.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            dtpDateOfBirth.Value = DateTime.Today;
            txtFullName.Focus();
        }

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
            try
            {
                SaveStudent();
                LoadStudents();
                ClearFields();
                MessageBox.Show("Student record saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Students SET FullName=@FullName, Gender=@Gender, DateOfBirth=@DateOfBirth, " +
                    "PhoneNumber=@PhoneNumber, Address=@Address WHERE StudentID=@StudentID";

            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32(txtStudentID.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT FullName, Gender, DateOfBirth, PhoneNumber, Address " +
                   "FROM Students WHERE StudentID = @StudentID";

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32(txtStudentID.Text));

                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["FullName"].ToString();
                                cmbGender.Text = reader["Gender"].ToString();
                                dtpDateOfBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                                txtPhoneNumber.Text = reader["PhoneNumber"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No student record found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void tnLoadStudents_Click(object sender, EventArgs e)
        {
            string query = "SELECT StudentID, FullName FROM Students";

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lstStudents.Items.Clear();

                            while (reader.Read())
                            {
                                string studentInfo = reader["StudentID"].ToString() + " - " +
                                                     reader["FullName"].ToString();

                                lstStudents.Items.Add(studentInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value != null
                    ? row.Cells["PhoneNumber"].Value.ToString()
                    : "";
                txtAddress.Text = row.Cells["Address"].Value != null
                    ? row.Cells["Address"].Value.ToString()
                    : "";
            }

        }
    }
}


