namespace AcademySystem
{
    partial class ClassroomForm
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
            this.btnSaveClassroom = new System.Windows.Forms.Button();
            this.btnResetClassroom = new System.Windows.Forms.Button();
            this.btnRDeleteClassroom = new System.Windows.Forms.Button();
            this.txtNameClassroom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClassroomForm = new System.Windows.Forms.DataGridView();
            this.PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroomForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveClassroom
            // 
            this.btnSaveClassroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveClassroom.Location = new System.Drawing.Point(16, 142);
            this.btnSaveClassroom.Name = "btnSaveClassroom";
            this.btnSaveClassroom.Size = new System.Drawing.Size(233, 40);
            this.btnSaveClassroom.TabIndex = 3;
            this.btnSaveClassroom.Text = "Save";
            this.btnSaveClassroom.UseVisualStyleBackColor = true;
            this.btnSaveClassroom.Click += new System.EventHandler(this.BtnSaveClassroom_Click);
            // 
            // btnResetClassroom
            // 
            this.btnResetClassroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetClassroom.Location = new System.Drawing.Point(134, 101);
            this.btnResetClassroom.Name = "btnResetClassroom";
            this.btnResetClassroom.Size = new System.Drawing.Size(115, 35);
            this.btnResetClassroom.TabIndex = 4;
            this.btnResetClassroom.Text = "Reset";
            this.btnResetClassroom.UseVisualStyleBackColor = true;
            this.btnResetClassroom.Click += new System.EventHandler(this.BtnResetClassroom_Click);
            // 
            // btnRDeleteClassroom
            // 
            this.btnRDeleteClassroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRDeleteClassroom.Location = new System.Drawing.Point(16, 101);
            this.btnRDeleteClassroom.Name = "btnRDeleteClassroom";
            this.btnRDeleteClassroom.Size = new System.Drawing.Size(115, 35);
            this.btnRDeleteClassroom.TabIndex = 5;
            this.btnRDeleteClassroom.Text = "Delete";
            this.btnRDeleteClassroom.UseVisualStyleBackColor = true;
            this.btnRDeleteClassroom.Click += new System.EventHandler(this.BtnRDeleteClassroom_Click);
            // 
            // txtNameClassroom
            // 
            this.txtNameClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNameClassroom.Location = new System.Drawing.Point(69, 47);
            this.txtNameClassroom.Name = "txtNameClassroom";
            this.txtNameClassroom.Size = new System.Drawing.Size(180, 21);
            this.txtNameClassroom.TabIndex = 1;
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
            // dgvClassroomForm
            // 
            this.dgvClassroomForm.AllowUserToAddRows = false;
            this.dgvClassroomForm.AllowUserToDeleteRows = false;
            this.dgvClassroomForm.AllowUserToResizeColumns = false;
            this.dgvClassroomForm.AllowUserToResizeRows = false;
            this.dgvClassroomForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassroomForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassroomForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassroomForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionID,
            this.PostionName});
            this.dgvClassroomForm.Location = new System.Drawing.Point(276, 12);
            this.dgvClassroomForm.Name = "dgvClassroomForm";
            this.dgvClassroomForm.Size = new System.Drawing.Size(319, 250);
            this.dgvClassroomForm.TabIndex = 4;
            this.dgvClassroomForm.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClassroomForm_CellMouseDoubleClick);
            // 
            // PositionID
            // 
            this.PositionID.HeaderText = "ID";
            this.PositionID.Name = "PositionID";
            this.PositionID.Visible = false;
            // 
            // PostionName
            // 
            this.PostionName.HeaderText = "Name";
            this.PostionName.Name = "PostionName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveClassroom);
            this.panel1.Controls.Add(this.btnResetClassroom);
            this.panel1.Controls.Add(this.btnRDeleteClassroom);
            this.panel1.Controls.Add(this.txtNameClassroom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 274);
            this.panel1.TabIndex = 3;
            // 
            // ClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 274);
            this.Controls.Add(this.dgvClassroomForm);
            this.Controls.Add(this.panel1);
            this.Name = "ClassroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroomForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveClassroom;
        private System.Windows.Forms.Button btnResetClassroom;
        private System.Windows.Forms.Button btnRDeleteClassroom;
        private System.Windows.Forms.TextBox txtNameClassroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClassroomForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostionName;
        private System.Windows.Forms.Panel panel1;
    }
}