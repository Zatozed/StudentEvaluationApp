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
                MessageBox.Show("mange");
            }
        }
    }
}
