namespace LeaveManagementSystem
{
    partial class ViewLeaveStatusForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLeaveStatusForm));
            this.dataGridViewLeaveStatus = new System.Windows.Forms.DataGridView();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leave_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leave_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSet2 = new LeaveManagementSystem.LeaveManagementSystemDataSet2();
            this.leavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveManagementSystemDataSet = new LeaveManagementSystem.LeaveManagementSystemDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new LeaveManagementSystem.LeaveManagementSystemDataSetTableAdapters.AdminsTableAdapter();
            this.leavesTableAdapter = new LeaveManagementSystem.LeaveManagementSystemDataSetTableAdapters.LeavesTableAdapter();
            this.btnReturn = new System.Windows.Forms.Button();
            this.leaveManagementSystemDataSet1 = new LeaveManagementSystem.LeaveManagementSystemDataSet1();
            this.leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveTableAdapter = new LeaveManagementSystem.LeaveManagementSystemDataSet1TableAdapters.LeaveTableAdapter();
            this.leaveTableAdapter1 = new LeaveManagementSystem.LeaveManagementSystemDataSet2TableAdapters.LeaveTableAdapter();
            this.Search_button = new System.Windows.Forms.Button();
            this.Type_the_ID_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnDeleteLeave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnApplyLeaves = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLeaveStatus
            // 
            this.dataGridViewLeaveStatus.AllowUserToAddRows = false;
            this.dataGridViewLeaveStatus.AllowUserToDeleteRows = false;
            this.dataGridViewLeaveStatus.AutoGenerateColumns = false;
            this.dataGridViewLeaveStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaveStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Name,
            this.leaveTypeDataGridViewTextBoxColumn,
            this.leaveIDDataGridViewTextBoxColumn,
            this.Reason,
            this.Leave_Start,
            this.Leave_End,
            this.Status});
            this.dataGridViewLeaveStatus.DataSource = this.leaveBindingSource1;
            this.dataGridViewLeaveStatus.Location = new System.Drawing.Point(370, 240);
            this.dataGridViewLeaveStatus.Name = "dataGridViewLeaveStatus";
            this.dataGridViewLeaveStatus.ReadOnly = true;
            this.dataGridViewLeaveStatus.RowHeadersWidth = 51;
            this.dataGridViewLeaveStatus.RowTemplate.Height = 24;
            this.dataGridViewLeaveStatus.Size = new System.Drawing.Size(751, 316);
            this.dataGridViewLeaveStatus.TabIndex = 0;
            this.dataGridViewLeaveStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeaveStatus_CellContentClick);
            this.dataGridViewLeaveStatus.DoubleClick += new System.EventHandler(this.dataGridViewLeaveStatus_DoubleClick);
            // 
            // Employee_Name
            // 
            this.Employee_Name.DataPropertyName = "Employee_Name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Employee_Name.HeaderText = "Employee Name";
            this.Employee_Name.MinimumWidth = 6;
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            this.Employee_Name.Visible = false;
            this.Employee_Name.Width = 125;
            // 
            // leaveTypeDataGridViewTextBoxColumn
            // 
            this.leaveTypeDataGridViewTextBoxColumn.DataPropertyName = "Leave_Type";
            this.leaveTypeDataGridViewTextBoxColumn.HeaderText = "Leave Type";
            this.leaveTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveTypeDataGridViewTextBoxColumn.Name = "leaveTypeDataGridViewTextBoxColumn";
            this.leaveTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // leaveIDDataGridViewTextBoxColumn
            // 
            this.leaveIDDataGridViewTextBoxColumn.DataPropertyName = "Leave_ID";
            this.leaveIDDataGridViewTextBoxColumn.HeaderText = "Leave ID";
            this.leaveIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveIDDataGridViewTextBoxColumn.Name = "leaveIDDataGridViewTextBoxColumn";
            this.leaveIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 125;
            // 
            // Leave_Start
            // 
            this.Leave_Start.DataPropertyName = "Leave_Start";
            this.Leave_Start.HeaderText = "Leave Start";
            this.Leave_Start.MinimumWidth = 6;
            this.Leave_Start.Name = "Leave_Start";
            this.Leave_Start.ReadOnly = true;
            this.Leave_Start.Width = 125;
            // 
            // Leave_End
            // 
            this.Leave_End.DataPropertyName = "Leave_End";
            this.Leave_End.HeaderText = "Leave End";
            this.Leave_End.MinimumWidth = 6;
            this.Leave_End.Name = "Leave_End";
            this.Leave_End.ReadOnly = true;
            this.Leave_End.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // leaveBindingSource1
            // 
            this.leaveBindingSource1.DataMember = "Leave";
            this.leaveBindingSource1.DataSource = this.leaveManagementSystemDataSet2;
            // 
            // leaveManagementSystemDataSet2
            // 
            this.leaveManagementSystemDataSet2.DataSetName = "LeaveManagementSystemDataSet2";
            this.leaveManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leavesBindingSource
            // 
            this.leavesBindingSource.DataMember = "Leaves";
            this.leavesBindingSource.DataSource = this.leaveManagementSystemDataSetBindingSource;
            // 
            // leaveManagementSystemDataSetBindingSource
            // 
            this.leaveManagementSystemDataSetBindingSource.DataSource = this.leaveManagementSystemDataSet;
            this.leaveManagementSystemDataSetBindingSource.Position = 0;
            // 
            // leaveManagementSystemDataSet
            // 
            this.leaveManagementSystemDataSet.DataSetName = "LeaveManagementSystemDataSet";
            this.leaveManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.leaveManagementSystemDataSetBindingSource;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // leavesTableAdapter
            // 
            this.leavesTableAdapter.ClearBeforeFill = true;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Firebrick;
            this.btnReturn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(1047, 593);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 45);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // leaveManagementSystemDataSet1
            // 
            this.leaveManagementSystemDataSet1.DataSetName = "LeaveManagementSystemDataSet1";
            this.leaveManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveBindingSource
            // 
            this.leaveBindingSource.DataMember = "Leave";
            this.leaveBindingSource.DataSource = this.leaveManagementSystemDataSet1;
            // 
            // leaveTableAdapter
            // 
            this.leaveTableAdapter.ClearBeforeFill = true;
            // 
            // leaveTableAdapter1
            // 
            this.leaveTableAdapter1.ClearBeforeFill = true;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Gray;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search_button.Location = new System.Drawing.Point(961, 173);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(121, 40);
            this.Search_button.TabIndex = 135;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Type_the_ID_txt
            // 
            this.Type_the_ID_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Type_the_ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_the_ID_txt.Location = new System.Drawing.Point(722, 178);
            this.Type_the_ID_txt.Name = "Type_the_ID_txt";
            this.Type_the_ID_txt.Size = new System.Drawing.Size(233, 30);
            this.Type_the_ID_txt.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(470, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 27);
            this.label8.TabIndex = 133;
            this.label8.Text = "Type the Emplyee ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 280);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "View your Leave Status and History here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 123);
            this.panel1.TabIndex = 32;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.ForeColor = System.Drawing.Color.Black;
            this.btnViewStatus.Location = new System.Drawing.Point(-3, 372);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(314, 82);
            this.btnViewStatus.TabIndex = 33;
            this.btnViewStatus.Text = "View History and Leave Status >>";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnDeleteLeave
            // 
            this.btnDeleteLeave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLeave.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLeave.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteLeave.Location = new System.Drawing.Point(-3, 486);
            this.btnDeleteLeave.Name = "btnDeleteLeave";
            this.btnDeleteLeave.Size = new System.Drawing.Size(314, 61);
            this.btnDeleteLeave.TabIndex = 34;
            this.btnDeleteLeave.Text = "Delete Applied Leaves";
            this.btnDeleteLeave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Location = new System.Drawing.Point(310, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 558);
            this.panel2.TabIndex = 39;
            // 
            // btnApplyLeaves
            // 
            this.btnApplyLeaves.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnApplyLeaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyLeaves.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLeaves.ForeColor = System.Drawing.Color.Black;
            this.btnApplyLeaves.Location = new System.Drawing.Point(-3, 279);
            this.btnApplyLeaves.Name = "btnApplyLeaves";
            this.btnApplyLeaves.Size = new System.Drawing.Size(314, 61);
            this.btnApplyLeaves.TabIndex = 40;
            this.btnApplyLeaves.Text = "Apply Leave";
            this.btnApplyLeaves.UseVisualStyleBackColor = false;
            this.btnApplyLeaves.Click += new System.EventHandler(this.btnApplyLeaves_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(-2, 121);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 588);
            this.panel3.TabIndex = 136;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1192, 14);
            this.panel4.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Location = new System.Drawing.Point(1182, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 558);
            this.panel5.TabIndex = 40;
            // 
            // ViewLeaveStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 677);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Type_the_ID_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnApplyLeaves);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDeleteLeave);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridViewLeaveStatus);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLeaveStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLeaveStatusForm";
            this.Load += new System.EventHandler(this.ViewLeaveStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveManagementSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeaveStatus;
        private System.Windows.Forms.BindingSource leaveManagementSystemDataSetBindingSource;
        private LeaveManagementSystemDataSet leaveManagementSystemDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private LeaveManagementSystemDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.BindingSource leavesBindingSource;
        private LeaveManagementSystemDataSetTableAdapters.LeavesTableAdapter leavesTableAdapter;
        private System.Windows.Forms.Button btnReturn;
        private LeaveManagementSystemDataSet1 leaveManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource leaveBindingSource;
        private LeaveManagementSystemDataSet1TableAdapters.LeaveTableAdapter leaveTableAdapter;
        private LeaveManagementSystemDataSet2 leaveManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource leaveBindingSource1;
        private LeaveManagementSystemDataSet2TableAdapters.LeaveTableAdapter leaveTableAdapter1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Type_the_ID_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnDeleteLeave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnApplyLeaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leave_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leave_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}