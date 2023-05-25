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
            Properties.Settings.Default.SelectedCourse = dgvSelect.CurrentRow.Cells["colCourseName"].Value.ToString();
            Properties.Settings.Default.SelectedCourseID = dgvSelect.CurrentRow.Cells["colID"].Value.ToString();

            this.Hide();
        }
    }
}
