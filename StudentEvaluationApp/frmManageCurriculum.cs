using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEvaluationApp
{
    public partial class frmManageCurriculum : Form
    {
        private ClassDBhelper dbh = new ClassDBhelper();

        public frmManageCurriculum()
        {
            InitializeComponent();

            dgvCourses.DataSource = dbh.ShowCourseListNoDes();

        }

        private void frmManageCurriculum_Load(object sender, EventArgs e)
        {


        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourses.Columns[e.ColumnIndex].Name.Equals("colToRight"))
            {
                if (dgvToCurriculum.Rows.Count == 0)
                {
                    dgvToCurriculum.Rows.Add(
                        dgvCourses.Rows[e.RowIndex].Cells["colCourseID"].Value,
                        dgvCourses.Rows[e.RowIndex].Cells["colCourseCode"].Value,
                        dgvCourses.Rows[e.RowIndex].Cells["colCourse"].Value,
                        dgvCourses.Rows[e.RowIndex].Cells["colUnits"].Value,
                        "Click to Select");
                }
                else
                {
                    int matchCount = 0;
                    foreach (DataGridViewRow r in dgvToCurriculum.Rows)
                    {
                        if (r.Cells["colIDToCv"].Value.ToString().Equals
                            (dgvCourses.Rows[e.RowIndex].Cells["colCourseID"].Value.ToString()))
                        {
                            matchCount++;
                        }
                    }

                    if (matchCount != 0)
                    {
                        MessageBox.Show("The Course is already added.");
                    }
                    else
                    {
                        dgvToCurriculum.Rows.Add(
                            dgvCourses.Rows[e.RowIndex].Cells["colCourseID"].Value,
                            dgvCourses.Rows[e.RowIndex].Cells["colCourseCode"].Value,
                            dgvCourses.Rows[e.RowIndex].Cells["colCourse"].Value,
                            dgvCourses.Rows[e.RowIndex].Cells["colUnits"].Value,
                            "Click to Select");
                    }
                }
            }
        }

        private void dgvToCurriculum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvToCurriculum.Columns["colPrereq"].Name.Equals("colPrereq"))
            {
                frmSetPrerequisiteOf frmSet = new frmSetPrerequisiteOf();
                frmSet.ShowDialog();

                dgvToCurriculum.Rows[e.RowIndex].Cells["colPrereq"].Value = Properties.Settings.Default.SelectedCourse;
            }
        }
    }
}
