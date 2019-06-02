namespace AcademySystem
{
    partial class SearchClassrooms
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
            this.txtSearchBoxClassrooms = new System.Windows.Forms.TextBox();
            this.btnSearchClassrooms = new System.Windows.Forms.Button();
            this.dataGridView_classrooms = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchBoxClassrooms);
            this.panel1.Controls.Add(this.btnSearchClassrooms);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 70);
            this.panel1.TabIndex = 4;
            // 
            // txtSearchBoxClassrooms
            // 
            this.txtSearchBoxClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchBoxClassrooms.Location = new System.Drawing.Point(12, 23);
            this.txtSearchBoxClassrooms.Name = "txtSearchBoxClassrooms";
            this.txtSearchBoxClassrooms.Size = new System.Drawing.Size(270, 26);
            this.txtSearchBoxClassrooms.TabIndex = 1;
            // 
            // btnSearchClassrooms
            // 
            this.btnSearchClassrooms.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchClassrooms.Location = new System.Drawing.Point(288, 21);
            this.btnSearchClassrooms.Name = "btnSearchClassrooms";
            this.btnSearchClassrooms.Size = new System.Drawing.Size(100, 30);
            this.btnSearchClassrooms.TabIndex = 0;
            this.btnSearchClassrooms.Text = "Search";
            this.btnSearchClassrooms.UseVisualStyleBackColor = true;
            this.btnSearchClassrooms.Click += new System.EventHandler(this.BtnSearchClassrooms_Click);
            // 
            // dataGridView_classrooms
            // 
            this.dataGridView_classrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classrooms.Location = new System.Drawing.Point(12, 76);
            this.dataGridView_classrooms.Name = "dataGridView_classrooms";
            this.dataGridView_classrooms.Size = new System.Drawing.Size(376, 327);
            this.dataGridView_classrooms.TabIndex = 5;
            // 
            // SearchClassrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_classrooms);
            this.Name = "SearchClassrooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchClassrooms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classrooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchBoxClassrooms;
        private System.Windows.Forms.Button btnSearchClassrooms;
        private System.Windows.Forms.DataGridView dataGridView_classrooms;
    }
}