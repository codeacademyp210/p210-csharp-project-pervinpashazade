namespace AcademySystem
{
    partial class SearchEducationForm
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
            this.txtSearchBoxEdu = new System.Windows.Forms.TextBox();
            this.btnSearchEdu = new System.Windows.Forms.Button();
            this.dataGridView_edu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_edu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchBoxEdu);
            this.panel1.Controls.Add(this.btnSearchEdu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 70);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchBoxEdu
            // 
            this.txtSearchBoxEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchBoxEdu.Location = new System.Drawing.Point(12, 23);
            this.txtSearchBoxEdu.Name = "txtSearchBoxEdu";
            this.txtSearchBoxEdu.Size = new System.Drawing.Size(389, 26);
            this.txtSearchBoxEdu.TabIndex = 1;
            // 
            // btnSearchEdu
            // 
            this.btnSearchEdu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchEdu.Location = new System.Drawing.Point(407, 21);
            this.btnSearchEdu.Name = "btnSearchEdu";
            this.btnSearchEdu.Size = new System.Drawing.Size(100, 30);
            this.btnSearchEdu.TabIndex = 0;
            this.btnSearchEdu.Text = "Search";
            this.btnSearchEdu.UseVisualStyleBackColor = true;
            this.btnSearchEdu.Click += new System.EventHandler(this.BtnSearchEdu_Click);
            // 
            // dataGridView_edu
            // 
            this.dataGridView_edu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_edu.Location = new System.Drawing.Point(12, 76);
            this.dataGridView_edu.Name = "dataGridView_edu";
            this.dataGridView_edu.Size = new System.Drawing.Size(495, 310);
            this.dataGridView_edu.TabIndex = 1;
            // 
            // SearchEducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 398);
            this.Controls.Add(this.dataGridView_edu);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "SearchEducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Education programs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_edu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchBoxEdu;
        private System.Windows.Forms.Button btnSearchEdu;
        private System.Windows.Forms.DataGridView dataGridView_edu;
    }
}