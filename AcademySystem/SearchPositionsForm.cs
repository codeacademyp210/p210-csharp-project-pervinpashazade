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
    public partial class SearchPositionsForm : Form
    {
        public SearchPositionsForm()
        {
            InitializeComponent();
        }

        private void BtnSearchPositions_Click(object sender, EventArgs e)
        {
            string PositionsSearch = txtSearchBoxPositions.Text.Trim().ToLower();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<Position> positions =
                    db.Positions
                        .Where(x => x.Status == true)
                            .Where(x => x.Name.Contains(PositionsSearch))
                                .ToList();



                dataGridView_positions.DataSource = positions;

                dataGridView_positions.Columns[0].Visible = false;
                dataGridView_positions.Columns[3].Visible = false;
                dataGridView_positions.Columns["Status"].Visible = false;

                dataGridView_positions.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                txtSearchBoxPositions.Text = "";


            }
        }
    }
}
