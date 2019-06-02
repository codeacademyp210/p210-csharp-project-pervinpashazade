namespace AcademySystem
{
    partial class SearchPositionsForm
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
            this.txtSearchBoxPositions = new System.Windows.Forms.TextBox();
            this.btnSearchPositions = new System.Windows.Forms.Button();
            this.dataGridView_positions = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_positions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchBoxPositions);
            this.panel1.Controls.Add(this.btnSearchPositions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 70);
            this.panel1.TabIndex = 2;
            // 
            // txtSearchBoxPositions
            // 
            this.txtSearchBoxPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearchBoxPositions.Location = new System.Drawing.Point(12, 23);
            this.txtSearchBoxPositions.Name = "txtSearchBoxPositions";
            this.txtSearchBoxPositions.Size = new System.Drawing.Size(262, 26);
            this.txtSearchBoxPositions.TabIndex = 1;
            // 
            // btnSearchPositions
            // 
            this.btnSearchPositions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchPositions.Location = new System.Drawing.Point(280, 21);
            this.btnSearchPositions.Name = "btnSearchPositions";
            this.btnSearchPositions.Size = new System.Drawing.Size(100, 30);
            this.btnSearchPositions.TabIndex = 0;
            this.btnSearchPositions.Text = "Search";
            this.btnSearchPositions.UseVisualStyleBackColor = true;
            this.btnSearchPositions.Click += new System.EventHandler(this.BtnSearchPositions_Click);
            // 
            // dataGridView_positions
            // 
            this.dataGridView_positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_positions.Location = new System.Drawing.Point(12, 76);
            this.dataGridView_positions.Name = "dataGridView_positions";
            this.dataGridView_positions.Size = new System.Drawing.Size(368, 300);
            this.dataGridView_positions.TabIndex = 3;
            // 
            // SearchPositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_positions);
            this.Name = "SearchPositionsForm";
            this.Text = "SearchPositionsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_positions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchBoxPositions;
        private System.Windows.Forms.Button btnSearchPositions;
        private System.Windows.Forms.DataGridView dataGridView_positions;
    }
}