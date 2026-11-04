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
    public partial class ViewLeaveStatusForm : Form
    {
        public ViewLeaveStatusForm()
        {
            InitializeComponent();
        }

        static string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);

        private void ViewLeaveStatusForm_Load(object sender, EventArgs e)
        {


        }

        private void dataGridViewLeaveStatus_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EmployeeMainForm x = new EmployeeMainForm();
            x.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLeaveStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                dataGridViewLeaveStatus.DataSource = dt;
                MessageBox.Show("Data Found");
            }
            else
            {
                MessageBox.Show("data not found");
            }
            con.Close();

        }

        private void btnApplyLeaves_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {

        }
    }

}