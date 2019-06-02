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
    public partial class SearchClassrooms : Form
    {
        public SearchClassrooms()
        {
            InitializeComponent();
        }

        private void BtnSearchClassrooms_Click(object sender, EventArgs e)
        {
            string ClassroomSearch = txtSearchBoxClassrooms.Text.Trim().ToLower();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<Classroom> classroom =
                    db.Classrooms
                        .Where(x => x.Status == true)
                            .Where(x => x.Name.Contains(ClassroomSearch))
                                .ToList();



                dataGridView_classrooms.DataSource = classroom;

                dataGridView_classrooms.Columns[0].Visible = false;
                dataGridView_classrooms.Columns[3].Visible = false;
                dataGridView_classrooms.Columns["Status"].Visible = false;

                dataGridView_classrooms.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                txtSearchBoxClassrooms.Text = "";
            }
        }
    }
}
