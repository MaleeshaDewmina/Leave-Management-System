using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LeaveManagementSystem
{
    public partial class EmployeeLoginForm : Form
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        static string connection = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LeaveManagementSystem;Integrated Security=True";
        SqlConnection con = new SqlConnection(connection);

        string Employee_ID, Password;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                Employee_ID = txtEmployeeNum.Text;
                Password = txtPassword.Text;

                string Query = "SELECT * from Employee_Details where Employee_ID ='" + Employee_ID + "' and Password='" + Password + "'";
                SqlConnection con = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dtable = new DataTable();
                MyAdapter.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    timer1.Start();
                    MessageBox.Show("Login sucess Welcome to Employee Dashboard");

                }
                else
                {
                    MessageBox.Show("Invalid Employee Number and Password", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmployeeNum.Text = "";
                    txtPassword.Text = "";
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
            }
            if (checkBox1.Checked == false || txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtEmployeeNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;

            }
            else
            {
                timer1.Enabled = false;
                ApplyLeaveForm x = new ApplyLeaveForm();
                x.Show();
                this.Hide();
            }
        }
    }
}


       