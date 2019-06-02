namespace AcademySystem
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.positionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classroomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classroomsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.educationToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.classroomsToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.educationToolStripMenuItem.Text = "Education";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.EducationToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherToolStripMenuItem.Text = "Positions";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.TeacherToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.educationToolStripMenuItem1,
            this.positionsToolStripMenuItem,
            this.classroomsToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // educationToolStripMenuItem1
            // 
            this.educationToolStripMenuItem1.Name = "educationToolStripMenuItem1";
            this.educationToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.educationToolStripMenuItem1.Text = "Education";
            this.educationToolStripMenuItem1.Click += new System.EventHandler(this.EducationToolStripMenuItem1_Click);
            // 
            // positionsToolStripMenuItem
            // 
            this.positionsToolStripMenuItem.Name = "positionsToolStripMenuItem";
            this.positionsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.positionsToolStripMenuItem.Text = "Positions";
            this.positionsToolStripMenuItem.Click += new System.EventHandler(this.PositionsToolStripMenuItem_Click);
            // 
            // classroomsToolStripMenuItem
            // 
            this.classroomsToolStripMenuItem.Name = "classroomsToolStripMenuItem";
            this.classroomsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.classroomsToolStripMenuItem.Text = "Classrooms";
            this.classroomsToolStripMenuItem.Click += new System.EventHandler(this.ClassroomsToolStripMenuItem_Click);
            // 
            // classroomsToolStripMenuItem1
            // 
            this.classroomsToolStripMenuItem1.Name = "classroomsToolStripMenuItem1";
            this.classroomsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.classroomsToolStripMenuItem1.Text = "Classrooms";
            this.classroomsToolStripMenuItem1.Click += new System.EventHandler(this.ClassroomsToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academy System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem positionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classroomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classroomsToolStripMenuItem1;
    }
}

