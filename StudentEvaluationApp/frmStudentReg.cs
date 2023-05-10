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
    public partial class frmStudentReg : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();

        public frmStudentReg()
        {
            InitializeComponent();

            cbCurricuVer.DataSource = dbh.CurriculumVerList();
            cbYear.DataSource = dbh.YearList();
            cbSem.DataSource = dbh.SemList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmInputGrades frmInput = new frmInputGrades();
            frmInput.ShowDialog();
            frmInput.BringToFront();


        }
    }
}
