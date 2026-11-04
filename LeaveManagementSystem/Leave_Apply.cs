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

namespace LeaveManagementSystem
{
    public partial class Leave_Apply : Form
    {
        private int GenerateLeaveID()
        {
            int newID = 1;
            string query = "SELECT MAX(Leave_ID) FROM Leave_Table";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            var result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                newID = Convert.ToInt32(result) + 1;
            }
            con.Close();

            return newID;
        }

        

        public Leave_Apply()
        {
            InitializeComponent();
        }

        static string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);

        string  Employee_ID, Employee_Name, Leave_Type, Reason, Leave_Start, Leave_End, Status;

        private void btnApplyLeave_Click_1(object sender, EventArgs e)
        {
            string Employee_ID = txtEmployeeNum.Text;
            string Employee_Name = textEmployeeName.Text;
            string Leave_Type = cmbLeaveType.SelectedItem.ToString();
            string Reason = txtReason.Text;
            string Leave_Start = dtpStartDate.Value.ToString("yyyy-MM-dd");  // Use proper date format
            string Leave_End = dtpEndDate.Value.ToString("yyyy-MM-dd");      // Use proper date format
            string Status = "Pending";  // Assuming default status is "Pending"



            con.Open();

            // Correct SQL INSERT query with column specification and parameterized values
            string insert = "INSERT INTO Leave_Table (Employee_ID, Employee_Name, Leave_Type, Reason, Leave_Start, Leave_End, Status) " +
                            "VALUES (@Employee_ID, @Employee_Name, @Leave_Type, @Reason, @Leave_Start, @Leave_End, @Status)";

            // Create SqlCommand object and use parameters to prevent SQL injection
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@Employee_ID", Employee_ID);
            cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name);  // Make sure this value is being captured somewhere
            cmd.Parameters.AddWithValue("@Leave_Type", Leave_Type);
            cmd.Parameters.AddWithValue("@Reason", Reason);
            cmd.Parameters.AddWithValue("@Leave_Start", Leave_Start);
            cmd.Parameters.AddWithValue("@Leave_End", Leave_End);
            cmd.Parameters.AddWithValue("@Status", Status);

            // Confirmation message
            if (MessageBox.Show("Are you going to apply for a leave?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                con.Close();
                return;
            }
            else
            {
                cmd.ExecuteNonQuery();  // Execute the SQL query
                MessageBox.Show("Leave application submitted successfully.");
            }

            // Close the connection
            con.Close();
        }

        private void txtEmployeeNum_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmployeeNum.Text;  // Get Employee ID from input
            FetchEmployeeName(employeeID);  // Call method to fetch name
        }

        private void textEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FetchEmployeeName(string employeeID)
        {
            // SQL query to get the Employee Name based on Employee_ID
            string query = "SELECT Employee_Name FROM Employee_Details WHERE Employee_ID = @Employee_ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Employee_ID", employeeID);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textEmployeeName.Text = reader["Employee_Name"].ToString();
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }
            con.Close();
        }

        private void Leave_Apply_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            EmployeeMainForm x = new EmployeeMainForm();
            x.Show();
            this.Hide();
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            
        }

    }
}
