using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EducationForm educationForm = new EducationForm();
            educationForm.ShowDialog();
        }

        private void EducationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchEducationForm searchEduForm = new SearchEducationForm();
            searchEduForm.ShowDialog();
        }

        private void TeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionForm positionForm = new PositionForm();
            positionForm.ShowDialog();
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPositionsForm searchPositionsForm = new SearchPositionsForm();
            searchPositionsForm.ShowDialog();
        }

        private void ClassroomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchClassrooms searchClassrooms = new SearchClassrooms();
            searchClassrooms.ShowDialog();
        }

        private void ClassroomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassroomForm classroomForm = new ClassroomForm();
            classroomForm.ShowDialog();
        }
    }
}
