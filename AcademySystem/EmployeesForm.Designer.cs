namespace AcademySystem
{
    partial class EmployeesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveEdu = new System.Windows.Forms.Button();
            this.btnResetEdu = new System.Windows.Forms.Button();
            this.btnDeleteEdu = new System.Windows.Forms.Button();
            this.txtSurnameEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneEmp = new System.Windows.Forms.TextBox();
            this.cmbPositionEmp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalaryEmp = new System.Windows.Forms.TextBox();
            this.dgvEmpForm = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeStartTime);
            this.panel1.Controls.Add(this.cmbPositionEmp);
            this.panel1.Controls.Add(this.btnSaveEdu);
            this.panel1.Controls.Add(this.btnResetEdu);
            this.panel1.Controls.Add(this.btnDeleteEdu);
            this.panel1.Controls.Add(this.txtSalaryEmp);
            this.panel1.Controls.Add(this.txtPhoneEmp);
            this.panel1.Controls.Add(this.txtSurnameEmp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmailEmp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNameEmp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 450);
            this.panel1.TabIndex = 2;
            // 
            // btnSaveEdu
            // 
            this.btnSaveEdu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEdu.Location = new System.Drawing.Point(16, 344);
            this.btnSaveEdu.Name = "btnSaveEdu";
            this.btnSaveEdu.Size = new System.Drawing.Size(270, 40);
            this.btnSaveEdu.TabIndex = 3;
            this.btnSaveEdu.Text = "Save";
            this.btnSaveEdu.UseVisualStyleBackColor = true;
            // 
            // btnResetEdu
            // 
            this.btnResetEdu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetEdu.Location = new System.Drawing.Point(158, 303);
            this.btnResetEdu.Name = "btnResetEdu";
            this.btnResetEdu.Size = new System.Drawing.Size(128, 35);
            this.btnResetEdu.TabIndex = 4;
            this.btnResetEdu.Text = "Reset";
            this.btnResetEdu.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEdu
            // 
            this.btnDeleteEdu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEdu.Location = new System.Drawing.Point(16, 303);
            this.btnDeleteEdu.Name = "btnDeleteEdu";
            this.btnDeleteEdu.Size = new System.Drawing.Size(139, 35);
            this.btnDeleteEdu.TabIndex = 5;
            this.btnDeleteEdu.Text = "Delete";
            this.btnDeleteEdu.UseVisualStyleBackColor = true;
            // 
            // txtSurnameEmp
            // 
            this.txtSurnameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSurnameEmp.Location = new System.Drawing.Point(106, 84);
            this.txtSurnameEmp.Name = "txtSurnameEmp";
            this.txtSurnameEmp.Size = new System.Drawing.Size(180, 21);
            this.txtSurnameEmp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNameEmp.Location = new System.Drawing.Point(106, 48);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(180, 21);
            this.txtNameEmp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmailEmp.Location = new System.Drawing.Point(106, 120);
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(180, 21);
            this.txtEmailEmp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            // 
            // txtPhoneEmp
            // 
            this.txtPhoneEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPhoneEmp.Location = new System.Drawing.Point(106, 156);
            this.txtPhoneEmp.Name = "txtPhoneEmp";
            this.txtPhoneEmp.Size = new System.Drawing.Size(180, 21);
            this.txtPhoneEmp.TabIndex = 2;
            // 
            // cmbPositionEmp
            // 
            this.cmbPositionEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPositionEmp.FormattingEnabled = true;
            this.cmbPositionEmp.Location = new System.Drawing.Point(106, 192);
            this.cmbPositionEmp.Name = "cmbPositionEmp";
            this.cmbPositionEmp.Size = new System.Drawing.Size(180, 23);
            this.cmbPositionEmp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Position";
            // 
            // dateTimeStartTime
            // 
            this.dateTimeStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimeStartTime.Location = new System.Drawing.Point(106, 230);
            this.dateTimeStartTime.Name = "dateTimeStartTime";
            this.dateTimeStartTime.Size = new System.Drawing.Size(180, 21);
            this.dateTimeStartTime.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salary";
            // 
            // txtSalaryEmp
            // 
            this.txtSalaryEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSalaryEmp.Location = new System.Drawing.Point(106, 265);
            this.txtSalaryEmp.Name = "txtSalaryEmp";
            this.txtSalaryEmp.Size = new System.Drawing.Size(180, 21);
            this.txtSalaryEmp.TabIndex = 2;
            // 
            // dgvEmpForm
            // 
            this.dgvEmpForm.AllowUserToAddRows = false;
            this.dgvEmpForm.AllowUserToDeleteRows = false;
            this.dgvEmpForm.AllowUserToOrderColumns = true;
            this.dgvEmpForm.AllowUserToResizeRows = false;
            this.dgvEmpForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.empName,
            this.empSurname,
            this.empEmail,
            this.empPhone,
            this.empPosition,
            this.empStartTime,
            this.empSalary});
            this.dgvEmpForm.Location = new System.Drawing.Point(314, 12);
            this.dgvEmpForm.Name = "dgvEmpForm";
            this.dgvEmpForm.Size = new System.Drawing.Size(808, 426);
            this.dgvEmpForm.TabIndex = 3;
            // 
            // empID
            // 
            this.empID.HeaderText = "ID";
            this.empID.Name = "empID";
            this.empID.Visible = false;
            // 
            // empName
            // 
            this.empName.HeaderText = "Nmae";
            this.empName.Name = "empName";
            // 
            // empSurname
            // 
            this.empSurname.HeaderText = "Surname";
            this.empSurname.Name = "empSurname";
            // 
            // empEmail
            // 
            this.empEmail.HeaderText = "Email";
            this.empEmail.Name = "empEmail";
            // 
            // empPhone
            // 
            this.empPhone.HeaderText = "Phone";
            this.empPhone.Name = "empPhone";
            // 
            // empPosition
            // 
            this.empPosition.HeaderText = "Position";
            this.empPosition.Name = "empPosition";
            // 
            // empStartTime
            // 
            this.empStartTime.HeaderText = "Start time";
            this.empStartTime.Name = "empStartTime";
            // 
            // empSalary
            // 
            this.empSalary.HeaderText = "Salary";
            this.empSalary.Name = "empSalary";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.dgvEmpForm);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveEdu;
        private System.Windows.Forms.Button btnResetEdu;
        private System.Windows.Forms.Button btnDeleteEdu;
        private System.Windows.Forms.TextBox txtSurnameEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeStartTime;
        private System.Windows.Forms.ComboBox cmbPositionEmp;
        private System.Windows.Forms.TextBox txtSalaryEmp;
        private System.Windows.Forms.TextBox txtPhoneEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmpForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn empStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalary;
    }
}