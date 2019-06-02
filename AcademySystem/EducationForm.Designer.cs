namespace AcademySystem
{
    partial class EducationForm
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
            this.txtPriceEdu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameEdu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEduForm = new System.Windows.Forms.DataGridView();
            this.eduID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eduName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eduPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEduForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveEdu);
            this.panel1.Controls.Add(this.btnResetEdu);
            this.panel1.Controls.Add(this.btnDeleteEdu);
            this.panel1.Controls.Add(this.txtPriceEdu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNameEdu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 271);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveEdu
            // 
            this.btnSaveEdu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEdu.Location = new System.Drawing.Point(16, 178);
            this.btnSaveEdu.Name = "btnSaveEdu";
            this.btnSaveEdu.Size = new System.Drawing.Size(233, 40);
            this.btnSaveEdu.TabIndex = 3;
            this.btnSaveEdu.Text = "Save";
            this.btnSaveEdu.UseVisualStyleBackColor = true;
            this.btnSaveEdu.Click += new System.EventHandler(this.BtnSaveEdu_Click);
            // 
            // btnResetEdu
            // 
            this.btnResetEdu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetEdu.Location = new System.Drawing.Point(134, 137);
            this.btnResetEdu.Name = "btnResetEdu";
            this.btnResetEdu.Size = new System.Drawing.Size(115, 35);
            this.btnResetEdu.TabIndex = 4;
            this.btnResetEdu.Text = "Reset";
            this.btnResetEdu.UseVisualStyleBackColor = true;
            this.btnResetEdu.Click += new System.EventHandler(this.BtnResetEdu_Click);
            // 
            // btnDeleteEdu
            // 
            this.btnDeleteEdu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteEdu.Location = new System.Drawing.Point(16, 137);
            this.btnDeleteEdu.Name = "btnDeleteEdu";
            this.btnDeleteEdu.Size = new System.Drawing.Size(115, 35);
            this.btnDeleteEdu.TabIndex = 5;
            this.btnDeleteEdu.Text = "Delete";
            this.btnDeleteEdu.UseVisualStyleBackColor = true;
            this.btnDeleteEdu.Click += new System.EventHandler(this.BtnDeleteEdu_Click);
            // 
            // txtPriceEdu
            // 
            this.txtPriceEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPriceEdu.Location = new System.Drawing.Point(69, 93);
            this.txtPriceEdu.Name = "txtPriceEdu";
            this.txtPriceEdu.Size = new System.Drawing.Size(180, 21);
            this.txtPriceEdu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // txtNameEdu
            // 
            this.txtNameEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNameEdu.Location = new System.Drawing.Point(69, 47);
            this.txtNameEdu.Name = "txtNameEdu";
            this.txtNameEdu.Size = new System.Drawing.Size(180, 21);
            this.txtNameEdu.TabIndex = 1;
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
            // dgvEduForm
            // 
            this.dgvEduForm.AllowUserToAddRows = false;
            this.dgvEduForm.AllowUserToDeleteRows = false;
            this.dgvEduForm.AllowUserToResizeColumns = false;
            this.dgvEduForm.AllowUserToResizeRows = false;
            this.dgvEduForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEduForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEduForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEduForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eduID,
            this.eduName,
            this.eduPrice});
            this.dgvEduForm.Location = new System.Drawing.Point(276, 12);
            this.dgvEduForm.Name = "dgvEduForm";
            this.dgvEduForm.Size = new System.Drawing.Size(411, 247);
            this.dgvEduForm.TabIndex = 1;
            this.dgvEduForm.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEduForm_CellMouseDoubleClick_1);
            // 
            // eduID
            // 
            this.eduID.HeaderText = "ID";
            this.eduID.Name = "eduID";
            this.eduID.Visible = false;
            // 
            // eduName
            // 
            this.eduName.HeaderText = "Name";
            this.eduName.Name = "eduName";
            // 
            // eduPrice
            // 
            this.eduPrice.HeaderText = "Price";
            this.eduPrice.Name = "eduPrice";
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 271);
            this.Controls.Add(this.dgvEduForm);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EducationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEduForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPriceEdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameEdu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEdu;
        private System.Windows.Forms.Button btnResetEdu;
        private System.Windows.Forms.Button btnDeleteEdu;
        private System.Windows.Forms.DataGridView dgvEduForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn eduID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eduName;
        private System.Windows.Forms.DataGridViewTextBoxColumn eduPrice;
    }
}