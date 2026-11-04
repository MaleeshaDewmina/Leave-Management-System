using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem
{
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            ApplyLeaveForm x = new ApplyLeaveForm();
            x.Show();
            this.Hide();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            ViewLeaveStatusForm x = new ViewLeaveStatusForm();
            x.Show();
            this.Hide();
        }

        private void btnDeleteLeave_Click(object sender, EventArgs e)
        {
            DeleteLeaveForm x = new DeleteLeaveForm();
            x.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EmployeeLoginForm x = new EmployeeLoginForm();
            x.Show();
            this.Hide();
        }
    }
    
    
    
   
}
