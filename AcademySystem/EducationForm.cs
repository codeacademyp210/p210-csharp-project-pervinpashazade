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
    public partial class EducationForm : Form
    {

        EducationProgram EduForm = new EducationProgram();

        public EducationForm()
        {
            InitializeComponent();
            GenerateEduForm();
            FillEduForm();
        }



        private void GenerateEduForm()
        {
            dgvEduForm.Rows.Clear();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<EducationProgram> educationForm = db.EducationPrograms.Where(h => h.Status == true).ToList();

                foreach (var eduProgram in educationForm)
                {
                    dgvEduForm.Rows.Add(eduProgram.ID,
                                        eduProgram.Name,
                                        eduProgram.Price);
                }
            }

            btnDeleteEdu.Enabled = false;
        }

        private void FillEduForm()
        {
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                db.EducationPrograms.ToList();
            }
        }

        private bool CreateEduProgram()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {

                EducationProgram educationProgram = new EducationProgram()
                {
                    Name = txtNameEdu.Text,
                    Price = Convert.ToInt32(txtPriceEdu.Text),
                    Status = true
                };

                db.EducationPrograms.Add(educationProgram);

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }


        private bool UpdateEduProg()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                EducationProgram newEduProg = db.EducationPrograms.Where(edu => edu.ID == EduForm.ID).FirstOrDefault();

                newEduProg.Name = txtNameEdu.Text;
                newEduProg.Price = Convert.ToInt32(txtPriceEdu.Text);

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        private void ResetEduProgForm()
        {
            txtNameEdu.Text = "";
            txtPriceEdu.Text = "";

            btnSaveEdu.Text = "Save";
            btnDeleteEdu.Enabled = false;
        }

        private bool DeleteEduProg()
        {
            int affectRows = 0;

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                EducationProgram educationProgram = db.EducationPrograms.Where(e => e.ID == EduForm.ID).First();
                educationProgram.Status = false;
                affectRows = db.SaveChanges();
            }
            if (affectRows == 0)
            {
                return false;
            }
            GenerateEduForm();
            ResetEduProgForm();
            return true;

        }

        private void DgvEduForm_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            int EduProgID = (int)dgvEduForm.Rows[e.RowIndex].Cells[0].Value;

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                EduForm = db.EducationPrograms.Where(a => a.ID == EduProgID).FirstOrDefault();
                if (EduForm != null)
                {
                    txtNameEdu.Text = dgvEduForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPriceEdu.Text = dgvEduForm.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }

            btnSaveEdu.Text = "Update";
            btnDeleteEdu.Enabled = true;
        }

        private void BtnResetEdu_Click(object sender, EventArgs e)
        {
            ResetEduProgForm();
        }

        private void BtnDeleteEdu_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + EduForm.Name +
                           "  from Database?", "Delete Education Program", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteEduProg())
            {
                MessageBox.Show("Education Program was not deleted!", "Error");
                return;
            }

            MessageBox.Show("Education Program was successfully deleted");
        }

        private void BtnSaveEdu_Click(object sender, EventArgs e)
        {
            //is empty 
            if (txtNameEdu.Text == "" || txtPriceEdu.Text == "")
            {
                // display popup box  
                MessageBox.Show("Please fill in all fields", "Error");
                txtNameEdu.Focus(); // set focus to lastNameTextBox  
                return;
            }
            //Name box
            //if (!Regex.Match(txtNameEdu.Text, @"^[a-zA-Z0-9]+$").Success)
            //{
            //    MessageBox.Show("Please, use only letters and first " +
            //        "letter must will be large", "Sorry! Invalid name format");
            //    txtNameEdu.Focus();
            //    return;
            //}
            //Price box
            if (!Regex.Match(txtPriceEdu.Text, @"^\d+$").Success)
            { 
                MessageBox.Show("Please, use only numbers for Price.", "Sorry! Invalid Price format");
                txtPriceEdu.Focus();
                return;
            }




            if (btnDeleteEdu.Enabled == true)
            {
                if (!UpdateEduProg())
                {
                    MessageBox.Show("Education Program was not updated", "ERROR");
                    return;
                }

                GenerateEduForm();
                MessageBox.Show("Education Program was successfully updated");
            }
            else
            {
                if (!CreateEduProgram())
                {
                    MessageBox.Show("Education Program was not created", "ERROR");
                    return;
                }

                GenerateEduForm();
                MessageBox.Show("New Education Program was successfully created");
            }
            ResetEduProgForm();

        }

    }

      
   
}
