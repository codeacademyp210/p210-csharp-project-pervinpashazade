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
    public partial class PositionForm : Form
    {
        Position NewPosition = new Position();
        public PositionForm()
        {
            InitializeComponent();
            GeneratePositionForm();
            FillPositionsForm();
        }

        private void GeneratePositionForm()
        {
            dgvPositionForm.Rows.Clear();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<Position> positionForm = db.Positions.Where(p => p.Status == true).ToList();

                foreach (var position in positionForm)
                {
                    dgvPositionForm.Rows.Add(position.ID,
                                        position.Name);
                }
            }

            btnRDeletePosition.Enabled = false;
        }

        private void FillPositionsForm()
        {
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                db.Positions.ToList();
            }
        }

        private bool CreatePositions()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {

                Position position = new Position()
                {
                    Name = txtNamePositions.Text,
                    Status = true
                };

                db.Positions.Add(position);

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        private bool UpdatePositionsForm()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                Position newPosition = db.Positions.Where(p => p.ID == NewPosition.ID).FirstOrDefault();

                newPosition.Name = txtNamePositions.Text;;

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
            txtNamePositions.Text = "";

            btnSavePosition.Text = "Save";
            btnRDeletePosition.Enabled = false;
        }

        private bool DeleteEduProg()
        {
            int affectRows = 0;

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                Position position = db.Positions.Where(e => e.ID == NewPosition.ID).First();
                position.Status = false;
                affectRows = db.SaveChanges();
            }
            if (affectRows == 0)
            {
                return false;
            }
            GeneratePositionForm();
            ResetPositionsForm();
            return true;

        }


        private void BtnSavePosition_Click(object sender, EventArgs e)
        {
            //is empty 
            if (txtNamePositions.Text == "")
            {
                // display popup box  
                MessageBox.Show("Please fill in all fields", "Error");
                txtNamePositions.Focus(); // set focus to lastNameTextBox  
                return;
            }
            //Name box



            if (!Regex.Match(txtNamePositions.Text, @"^[a-z' 'A-Z]+$").Success)
            {
                MessageBox.Show("Please, use only letters and first " +
                    "letter must will be large", "Sorry! Invalid name format");
                txtNamePositions.Focus();
                return;
            }


            if (btnRDeletePosition.Enabled == true)
            {
                if (!UpdatePositionsForm())
                {
                    MessageBox.Show("Position was not updated", "ERROR");
                    return;
                }

                GeneratePositionForm();
                MessageBox.Show("Position was successfully updated", "Message");
            }
            else
            {
                if (!CreatePositions())
                {
                    MessageBox.Show("Position was not created", "ERROR");
                    return;
                }

                GeneratePositionForm();
                MessageBox.Show("New Position Program was successfully created", "Message");
            }
            ResetPositionsForm();

        }

        private void BtnResetPosition_Click(object sender, EventArgs e)
        {
            ResetPositionsForm();
        }

        private void BtnRDeletePosition_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure delete " + NewPosition.Name +
                          "  from Database?", "Delete Position", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteEduProg())
            {
                MessageBox.Show("Position was not deleted!", "Error");
                return;
            }

            MessageBox.Show("Position was successfully deleted");
        }

        private void DgvPositionForm_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int positionID = (int)dgvPositionForm.Rows[e.RowIndex].Cells[0].Value;

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                NewPosition = db.Positions.Where(a => a.ID == positionID).FirstOrDefault();
                if (NewPosition != null)
                {
                    txtNamePositions.Text = dgvPositionForm.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }

            btnSavePosition.Text = "Update";
            btnRDeletePosition.Enabled = true;
        }
    }
}
