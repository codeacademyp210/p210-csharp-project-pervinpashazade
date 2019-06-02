namespace AcademySystem
{
    partial class PositionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamePositions = new System.Windows.Forms.TextBox();
            this.btnRDeletePosition = new System.Windows.Forms.Button();
            this.btnResetPosition = new System.Windows.Forms.Button();
            this.btnSavePosition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPositionForm = new System.Windows.Forms.DataGridView();
            this.PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionForm)).BeginInit();
            this.SuspendLayout();
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
            // txtNamePositions
            // 
            this.txtNamePositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNamePositions.Location = new System.Drawing.Point(69, 47);
            this.txtNamePositions.Name = "txtNamePositions";
            this.txtNamePositions.Size = new System.Drawing.Size(180, 21);
            this.txtNamePositions.TabIndex = 1;
            // 
            // btnRDeletePosition
            // 
            this.btnRDeletePosition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRDeletePosition.Location = new System.Drawing.Point(16, 101);
            this.btnRDeletePosition.Name = "btnRDeletePosition";
            this.btnRDeletePosition.Size = new System.Drawing.Size(115, 35);
            this.btnRDeletePosition.TabIndex = 5;
            this.btnRDeletePosition.Text = "Delete";
            this.btnRDeletePosition.UseVisualStyleBackColor = true;
            this.btnRDeletePosition.Click += new System.EventHandler(this.BtnRDeletePosition_Click);
            // 
            // btnResetPosition
            // 
            this.btnResetPosition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetPosition.Location = new System.Drawing.Point(134, 101);
            this.btnResetPosition.Name = "btnResetPosition";
            this.btnResetPosition.Size = new System.Drawing.Size(115, 35);
            this.btnResetPosition.TabIndex = 4;
            this.btnResetPosition.Text = "Reset";
            this.btnResetPosition.UseVisualStyleBackColor = true;
            this.btnResetPosition.Click += new System.EventHandler(this.BtnResetPosition_Click);
            // 
            // btnSavePosition
            // 
            this.btnSavePosition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePosition.Location = new System.Drawing.Point(16, 142);
            this.btnSavePosition.Name = "btnSavePosition";
            this.btnSavePosition.Size = new System.Drawing.Size(233, 40);
            this.btnSavePosition.TabIndex = 3;
            this.btnSavePosition.Text = "Save";
            this.btnSavePosition.UseVisualStyleBackColor = true;
            this.btnSavePosition.Click += new System.EventHandler(this.BtnSavePosition_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSavePosition);
            this.panel1.Controls.Add(this.btnResetPosition);
            this.panel1.Controls.Add(this.btnRDeletePosition);
            this.panel1.Controls.Add(this.txtNamePositions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 271);
            this.panel1.TabIndex = 1;
            // 
            // dgvPositionForm
            // 
            this.dgvPositionForm.AllowUserToAddRows = false;
            this.dgvPositionForm.AllowUserToDeleteRows = false;
            this.dgvPositionForm.AllowUserToResizeColumns = false;
            this.dgvPositionForm.AllowUserToResizeRows = false;
            this.dgvPositionForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPositionForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositionForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositionForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionID,
            this.PostionName});
            this.dgvPositionForm.Location = new System.Drawing.Point(282, 12);
            this.dgvPositionForm.Name = "dgvPositionForm";
            this.dgvPositionForm.Size = new System.Drawing.Size(315, 247);
            this.dgvPositionForm.TabIndex = 2;
            this.dgvPositionForm.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPositionForm_CellMouseDoubleClick);
            // 
            // PositionID
            // 
            this.PositionID.HeaderText = "ID";
            this.PositionID.Name = "PositionID";
            this.PositionID.ReadOnly = true;
            this.PositionID.Visible = false;
            // 
            // PostionName
            // 
            this.PostionName.HeaderText = "Name";
            this.PostionName.Name = "PostionName";
            this.PostionName.ReadOnly = true;
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 271);
            this.Controls.Add(this.dgvPositionForm);
            this.Controls.Add(this.panel1);
            this.Name = "PositionForm";
            this.Text = "PositionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositionForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamePositions;
        private System.Windows.Forms.Button btnRDeletePosition;
        private System.Windows.Forms.Button btnResetPosition;
        private System.Windows.Forms.Button btnSavePosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPositionForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostionName;
    }
}