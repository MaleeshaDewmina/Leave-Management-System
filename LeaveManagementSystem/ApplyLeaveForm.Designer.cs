namespace LeaveManagementSystem
{
    partial class ApplyLeaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLeaveForm));
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSet5 = new LeaveManagementSystem.LeaveManagementSystemDataSet5();
            this.leavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSet = new LeaveManagementSystem.LeaveManagementSystemDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.leavesTableAdapter = new LeaveManagementSystem.LeaveManagementSystemDataSetTableAdapters.LeavesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnDeleteLeave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnApplyLeaves = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeNum = new System.Windows.Forms.TextBox();
            this.leaveManagementSystemDataSet4 = new LeaveManagementSystem.LeaveManagementSystemDataSet4();
            this.leaveManagementSystemDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSet4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSet3 = new LeaveManagementSystem.LeaveManagementSystemDataSet3();
            this.leaveManagementSystemDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new LeaveManagementSystem.LeaveManagementSystemDataSet5TableAdapters.Employee_DetailsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ShortLeavesRemain = new System.Windows.Forms.Label();
            this.CasualLeavesRemain = new System.Windows.Forms.Label();
            this.AnnualLeavesRemain = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.View_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet3BindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "Annual Leave",
            "Casual Leave",
            "Short Leave"});
            this.cmbLeaveType.Location = new System.Drawing.Point(612, 320);
            this.cmbLeaveType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(229, 24);
            this.cmbLeaveType.TabIndex = 0;
            this.cmbLeaveType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.leaveManagementSystemDataSet5;
            // 
            // leaveManagementSystemDataSet5
            // 
            this.leaveManagementSystemDataSet5.DataSetName = "LeaveManagementSystemDataSet5";
            this.leaveManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leavesBindingSource
            // 
            this.leavesBindingSource.DataMember = "Leaves";
            this.leavesBindingSource.DataSource = this.leaveManagementSystemDataSet;
            // 
            // leaveManagementSystemDataSet
            // 
            this.leaveManagementSystemDataSet.DataSetName = "LeaveManagementSystemDataSet";
            this.leaveManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(397, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of the Leave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(409, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leave Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(612, 445);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnApplyLeave.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLeave.Location = new System.Drawing.Point(513, 563);
            this.btnApplyLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(204, 62);
            this.btnApplyLeave.TabIndex = 4;
            this.btnApplyLeave.Text = "Apply Leave";
            this.btnApplyLeave.UseVisualStyleBackColor = false;
            this.btnApplyLeave.Click += new System.EventHandler(this.btnApplyLeave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 281);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apply your Required Leave ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(776, 644);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 39);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // leavesTableAdapter
            // 
            this.leavesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(417, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Leave End Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(612, 500);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 22);
            this.dtpEndDate.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 123);
            this.panel1.TabIndex = 14;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.Location = new System.Drawing.Point(0, 374);
            this.btnViewStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(308, 88);
            this.btnViewStatus.TabIndex = 15;
            this.btnViewStatus.Text = "View History and Leave Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnDeleteLeave
            // 
            this.btnDeleteLeave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLeave.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLeave.Location = new System.Drawing.Point(0, 500);
            this.btnDeleteLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteLeave.Name = "btnDeleteLeave";
            this.btnDeleteLeave.Size = new System.Drawing.Size(308, 62);
            this.btnDeleteLeave.TabIndex = 16;
            this.btnDeleteLeave.Text = "Delete Applied Leaves";
            this.btnDeleteLeave.UseVisualStyleBackColor = false;
            this.btnDeleteLeave.Click += new System.EventHandler(this.btnDeleteLeave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(366, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reason for the Leave:";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.LightGray;
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(612, 373);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(255, 30);
            this.txtReason.TabIndex = 21;
            // 
            // btnApplyLeaves
            // 
            this.btnApplyLeaves.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnApplyLeaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyLeaves.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLeaves.Location = new System.Drawing.Point(0, 276);
            this.btnApplyLeaves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyLeaves.Name = "btnApplyLeaves";
            this.btnApplyLeaves.Size = new System.Drawing.Size(308, 62);
            this.btnApplyLeaves.TabIndex = 23;
            this.btnApplyLeaves.Text = "Apply Leave >>";
            this.btnApplyLeaves.UseVisualStyleBackColor = false;
            this.btnApplyLeaves.Click += new System.EventHandler(this.btnApplyLeaves_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(394, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Employee Number:";
            // 
            // txtEmployeeNum
            // 
            this.txtEmployeeNum.BackColor = System.Drawing.Color.LightGray;
            this.txtEmployeeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNum.Location = new System.Drawing.Point(612, 265);
            this.txtEmployeeNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeNum.Name = "txtEmployeeNum";
            this.txtEmployeeNum.Size = new System.Drawing.Size(231, 30);
            this.txtEmployeeNum.TabIndex = 25;
            // 
            // leaveManagementSystemDataSet4
            // 
            this.leaveManagementSystemDataSet4.DataSetName = "LeaveManagementSystemDataSet4";
            this.leaveManagementSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveManagementSystemDataSet4BindingSource
            // 
            this.leaveManagementSystemDataSet4BindingSource.DataSource = this.leaveManagementSystemDataSet4;
            this.leaveManagementSystemDataSet4BindingSource.Position = 0;
            // 
            // leaveManagementSystemDataSet4BindingSource1
            // 
            this.leaveManagementSystemDataSet4BindingSource1.DataSource = this.leaveManagementSystemDataSet4;
            this.leaveManagementSystemDataSet4BindingSource1.Position = 0;
            // 
            // leaveManagementSystemDataSet3
            // 
            this.leaveManagementSystemDataSet3.DataSetName = "LeaveManagementSystemDataSet3";
            this.leaveManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveManagementSystemDataSet3BindingSource
            // 
            this.leaveManagementSystemDataSet3BindingSource.DataSource = this.leaveManagementSystemDataSet3;
            this.leaveManagementSystemDataSet3BindingSource.Position = 0;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Location = new System.Drawing.Point(307, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 588);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 588);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 687);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 13);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Location = new System.Drawing.Point(898, 122);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 588);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.ShortLeavesRemain);
            this.panel6.Controls.Add(this.CasualLeavesRemain);
            this.panel6.Controls.Add(this.AnnualLeavesRemain);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(362, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(404, 108);
            this.panel6.TabIndex = 26;
            // 
            // ShortLeavesRemain
            // 
            this.ShortLeavesRemain.AutoSize = true;
            this.ShortLeavesRemain.BackColor = System.Drawing.Color.Transparent;
            this.ShortLeavesRemain.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortLeavesRemain.ForeColor = System.Drawing.Color.Black;
            this.ShortLeavesRemain.Location = new System.Drawing.Point(5, 73);
            this.ShortLeavesRemain.Name = "ShortLeavesRemain";
            this.ShortLeavesRemain.Size = new System.Drawing.Size(110, 19);
            this.ShortLeavesRemain.TabIndex = 16;
            this.ShortLeavesRemain.Text = "Short Leaves:";
            // 
            // CasualLeavesRemain
            // 
            this.CasualLeavesRemain.AutoSize = true;
            this.CasualLeavesRemain.BackColor = System.Drawing.Color.Transparent;
            this.CasualLeavesRemain.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasualLeavesRemain.ForeColor = System.Drawing.Color.Black;
            this.CasualLeavesRemain.Location = new System.Drawing.Point(5, 50);
            this.CasualLeavesRemain.Name = "CasualLeavesRemain";
            this.CasualLeavesRemain.Size = new System.Drawing.Size(119, 19);
            this.CasualLeavesRemain.TabIndex = 15;
            this.CasualLeavesRemain.Text = "Casual Leaves:";
            // 
            // AnnualLeavesRemain
            // 
            this.AnnualLeavesRemain.AutoSize = true;
            this.AnnualLeavesRemain.BackColor = System.Drawing.Color.Transparent;
            this.AnnualLeavesRemain.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnualLeavesRemain.ForeColor = System.Drawing.Color.Black;
            this.AnnualLeavesRemain.Location = new System.Drawing.Point(5, 27);
            this.AnnualLeavesRemain.Name = "AnnualLeavesRemain";
            this.AnnualLeavesRemain.Size = new System.Drawing.Size(121, 19);
            this.AnnualLeavesRemain.TabIndex = 14;
            this.AnnualLeavesRemain.Text = "Annual Leaves:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Remaining Leaves";
            // 
            // View_button
            // 
            this.View_button.BackColor = System.Drawing.Color.Gray;
            this.View_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_button.Location = new System.Drawing.Point(788, 169);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(79, 40);
            this.View_button.TabIndex = 139;
            this.View_button.Text = "View";
            this.View_button.UseVisualStyleBackColor = false;
            // 
            // ApplyLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 700);
            this.Controls.Add(this.View_button);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtEmployeeNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnApplyLeaves);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteLeave);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLeaveType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApplyLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplyLeaveForm";
            this.Load += new System.EventHandler(this.ApplyLeaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet3BindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
        private LeaveManagementSystemDataSet leaveManagementSystemDataSet;
        private System.Windows.Forms.BindingSource leavesBindingSource;
        private LeaveManagementSystemDataSetTableAdapters.LeavesTableAdapter leavesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnDeleteLeave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnApplyLeaves;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeNum;
        private System.Windows.Forms.BindingSource leaveManagementSystemDataSet4BindingSource1;
        private LeaveManagementSystemDataSet4 leaveManagementSystemDataSet4;
        private System.Windows.Forms.BindingSource leaveManagementSystemDataSet4BindingSource;
        private LeaveManagementSystemDataSet3 leaveManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource leaveManagementSystemDataSet3BindingSource;
        private LeaveManagementSystemDataSet5 leaveManagementSystemDataSet5;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private LeaveManagementSystemDataSet5TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Label ShortLeavesRemain;
        private System.Windows.Forms.Label CasualLeavesRemain;
        private System.Windows.Forms.Label AnnualLeavesRemain;
    }
}