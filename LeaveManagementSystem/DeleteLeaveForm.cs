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
    public partial class DeleteLeaveForm : Form
    {
        public DeleteLeaveForm()
        {
            InitializeComponent();
        }


        static string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);

        int Employee_ID;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            con.Open();
            int Employee_ID = int.Parse(Type_the_ID_txt.Text);

            SqlDataAdapter da = new SqlDataAdapter
                ("select * from TableLeave where Employee_ID = '" + Employee_ID + "'", con);
            DataTable dt = new DataTable();
            int count = da.Fill(dt);
            if (count > 0)
            {
                dataGridView1.DataSource = dt;
                MessageBox.Show("Data Found");
            }
            else
            {
                MessageBox.Show("data not found");
            }
            con.Close();
        }

        private void Type_the_ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteLeaveForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveManagementSystemDataSet.Leaves' table. You can move, or remove it, as needed.
           

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
            Employee_ID = int.Parse(Type_the_ID_txt.Text);

            con.Open();

            string delete = "delete from TableEmployee where Employee_ID = '" + Employee_ID + "'";
            if (MessageBox.Show("Are you sure to delete?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully removed");
            }
        }

        private void btnDeleteLeave_Click_1(object sender, EventArgs e)
        {
            Employee_ID = int.Parse(Type_the_ID_txt.Text);

            con.Open();

            string delete = "delete from TableLeave where Employee_ID = '" + Employee_ID + "'";
            if (MessageBox.Show("Are you sure to delete?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully removed");
            }
        }
    }
}
