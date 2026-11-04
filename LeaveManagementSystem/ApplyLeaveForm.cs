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
    public partial class ApplyLeaveForm : Form
    {
        public ApplyLeaveForm()
        {
            InitializeComponent();
        }

        static string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);

        string Employee_ID, Leave_Type, Reason, Leave_Start, Leave_End;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employee_DetailsTableAdapter.FillBy(this.leaveManagementSystemDataSet5.Employee_Details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnApplyLeaves_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            ViewLeaveStatusForm x = new ViewLeaveStatusForm();
            x.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            {
                EmployeeMainForm x = new EmployeeMainForm();
                x.Show();
                this.Hide();
            }
        }

        private void btnDeleteLeave_Click(object sender, EventArgs e)
        {

        }

        private void ApplyLeaveForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveManagementSystemDataSet5.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.leaveManagementSystemDataSet5.Employee_Details);
            // TODO: This line of code loads data into the 'leaveManagementSystemDataSet.Leaves' table. You can move, or remove it, as needed.


        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";

            
            string Employee_ID = txtEmployeeNum.Text;  
            string Leave_Type = cmbLeaveType.SelectedItem.ToString();  
            string Reason = txtReason.Text;  
            DateTime Leave_Start = dtpStartDate.Value;  
            DateTime Leave_End = dtpEndDate.Value;  

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    if (MessageBox.Show("Are you going to apply a Leave?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    
                    string insertQuery = @"INSERT INTO TableLeave (Employee_ID, Leave_Type, Reason, Leave_Start, Leave_End) 
                                   VALUES (@Employee_ID, @Leave_Type, @Reason, @Leave_Start, @Leave_End)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Employee_ID", Employee_ID);
                        cmd.Parameters.AddWithValue("@Leave_Type", Leave_Type);
                        cmd.Parameters.AddWithValue("@Reason", Reason);
                        cmd.Parameters.AddWithValue("@Leave_Start", Leave_Start);
                        cmd.Parameters.AddWithValue("@Leave_End", Leave_End);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Leave applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void Remaining_Leaves_BY_ID_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            string Employee_ID = txtEmployeeNum.Text;

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";

            var leaveTypes = new Dictionary<string, (int Limit, DateTime StartDate, DateTime EndDate)>
    {
        { "AnnualLeaves", (30, new DateTime(currentYear, 1, 1), new DateTime(currentYear, 12, 31)) },
        { "CasualLeaves", (12, new DateTime(currentYear, 1, 1), new DateTime(currentYear, 12, 31)) },
        { "ShortLeaves", (6, new DateTime(currentYear, currentMonth, 1), new DateTime(currentYear, currentMonth, DateTime.DaysInMonth(currentYear, currentMonth))) }
    };

            foreach (var leaveType in leaveTypes)
            {
                int remainingLeaveDays = CalculateRemainingLeaves(connectionString, Employee_ID, leaveType.Key, leaveType.Value.StartDate, 
                    leaveType.Value.EndDate, leaveType.Value.Limit);


                if (leaveType.Key == "AnnualLeaves")
                    AnnualLeavesRemain.Text = $"Annual Leaves: {remainingLeaveDays}";
                else if (leaveType.Key == "CasualLeaves")
                    CasualLeavesRemain.Text = $"Casual Leaves: {remainingLeaveDays}";
                else if (leaveType.Key == "ShortLeaves")
                    ShortLeavesRemain.Text = $"Short Leaves: {remainingLeaveDays}";
            }
        }

        private int CalculateRemainingLeaves(string connectionString, string Employee_ID, string leaveType, 
            DateTime startDate, DateTime endDate, int leaveLimit)
        {

            int totalLeaveDays = 0;
            string qry = @"
        SELECT LeaveStart, LeaveEnd
        FROM Leaves
        WHERE LeaveStart >= @startDate
          AND LeaveEnd <= @endDate
          AND LeaveType = @leaveType
          AND EmployeeID = @EmployeeID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand comm = new SqlCommand(qry, conn);
                comm.Parameters.AddWithValue("@startDate", startDate);
                comm.Parameters.AddWithValue("@endDate", endDate);
                comm.Parameters.AddWithValue("@leaveType", leaveType);
                comm.Parameters.AddWithValue("@EmployeeID", Employee_ID);

                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    DateTime pastLeaveStart = (DateTime)reader["LeaveStart"];
                    DateTime pastLeaveEnd = (DateTime)reader["LeaveEnd"];
                    totalLeaveDays += (pastLeaveEnd - pastLeaveStart).Days + 1;
                }
                reader.Close();
            }

            return leaveLimit - totalLeaveDays;
        }


    }
}
