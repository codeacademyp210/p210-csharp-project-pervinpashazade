using AcademySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySystem
{
    public partial class ClassroomForm : Form

    {
        Classroom newClassroom = new Classroom();
        public ClassroomForm()
        {
            InitializeComponent();
            GenerateClassroomsForm();
            FillClassroomsForm();
        }

        private void GenerateClassroomsForm()
        {
            dgvClassroomForm.Rows.Clear();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<Classroom> classroomsForm = db.Classrooms.Where(c => c.Status == true).ToList();

                foreach (var classroom in classroomsForm)
                {
                    dgvClassroomForm.Rows.Add(classroom.ID,
                                        classroom.Name);
                }
            }

            btnRDeleteClassroom.Enabled = false;
        }

        private void FillClassroomsForm()
        {
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                db.Positions.ToList();
            }
        }

        private bool CreateClassrooms()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {

                Classroom classroom = new Classroom()
                {
                    Name = txtNameClassroom.Text,
                    Status = true
                };

                db.Classrooms.Add(classroom);

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        private bool UpdateClassroomsForm()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                Position newPosition = db.Positions.Where(p => p.ID == newClassroom.ID).FirstOrDefault();

                newPosition.Name = txtNameClassroom.Text; ;

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        private void ResetPositionsForm()
        {
            txtNameClassroom.Text = "";

            btnSaveClassroom.Text = "Save";
            btnRDeleteClassroom.Enabled = false;
        }

        private bool DeleteEduProg()
        {
            int affectRows = 0;

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                Classroom classrooms = db.Classrooms.Where(e => e.ID == newClassroom.ID).First();
                classrooms.Status = false;
                affectRows = db.SaveChanges();
            }
            if (affectRows == 0)
            {
                return false;
            }
            GenerateClassroomsForm();
            ResetPositionsForm();
            return true;

        }

        private void BtnSaveClassroom_Click(object sender, EventArgs e)
        {

            //is empty 
            if (txtNameClassroom.Text == "")
            {
                // display popup box  
                MessageBox.Show("Please fill in all fields", "Error");
                txtNameClassroom.Focus();
                return;
            }
            //Name box



            if (!Regex.Match(txtNameClassroom.Text, @"^[a-z' 'A-Z]+$").Success)
            {
                MessageBox.Show("Please, use only letters and first " +
                    "letter must will be large", "Sorry! Invalid name format");
                txtNameClassroom.Focus();
                return;
            }


            if (btnRDeleteClassroom.Enabled == true)
            {
                if (!UpdateClassroomsForm())
                {
                    MessageBox.Show("Classrom was not updated", "ERROR");
                    return;
                }

                GenerateClassroomsForm();
                MessageBox.Show("Classroom was successfully updated", "Message");
            }
            else
            {
                if (!CreateClassrooms())
                {
                    MessageBox.Show("Classroom was not created", "ERROR");
                    return;
                }

                GenerateClassroomsForm();
                MessageBox.Show("New Classroom was successfully created", "Message");
            }
            ResetPositionsForm();

        }

        private void BtnResetClassroom_Click(object sender, EventArgs e)
        {
            ResetPositionsForm();
        }

        private void BtnRDeleteClassroom_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + newClassroom.Name +
                         "  from Database?", "Delete Position", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteEduProg())
            {
                MessageBox.Show("Classroom was not deleted!", "Error");
                return;
            }

            MessageBox.Show("Classroom was successfully deleted", "Message");
        }

        private void DgvClassroomForm_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int classromID = (int)dgvClassroomForm.Rows[e.RowIndex].Cells[0].Value;

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                newClassroom = db.Classrooms.Where(c => c.ID == classromID).FirstOrDefault();
                if (newClassroom != null)
                {
                    txtNameClassroom.Text = dgvClassroomForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }

            btnSaveClassroom.Text = "Update";
            btnRDeleteClassroom.Enabled = true;
        }
    }
}
