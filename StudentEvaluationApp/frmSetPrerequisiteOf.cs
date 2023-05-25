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
    public partial class frmSetPrerequisiteOf : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();
        public frmSetPrerequisiteOf()
        {
            InitializeComponent();

            dgvSelect.DataSource = dbh.ShowCourseList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.SelectedCourseID = dgvSelect.CurrentCell.RowIndex.ce;
            //    [e.RowIndex].Cells["colID"].Value.ToString();
            //Properties.Settings.Default.SelectedCourse = dgvSelect.Rows[e.RowIndex].Cells["colCourseName"].Value.ToString();

            MessageBox.Show(dgvSelect.CurrentRow.Cells["colCourseName"].Value.ToString());

            MessageBox.Show(dgvSelect.CurrentRow.Cells["colID"].Value.ToString());
        }
    }
}
