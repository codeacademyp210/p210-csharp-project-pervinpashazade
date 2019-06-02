using AcademySystem.Models;
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
    public partial class SearchEducationForm : Form
    {
        public SearchEducationForm()
        {
            InitializeComponent();
        }

        private void BtnSearchEdu_Click(object sender, EventArgs e)
        {
            string EduSearch = txtSearchBoxEdu.Text.Trim().ToLower();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<EducationProgram> educationPrograms =
                    db.EducationPrograms
                        .Where(x=>x.Status==true)
                            .Where(x => x.Name.Contains(EduSearch) || x.Price.ToString().Contains(EduSearch))
                                .ToList();

                

                dataGridView_edu.DataSource = educationPrograms;

                dataGridView_edu.Columns[0].Visible = false;
                dataGridView_edu.Columns[3].Visible = false;

                dataGridView_edu.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                txtSearchBoxEdu.Text = "";


            }
        }
    }
}
