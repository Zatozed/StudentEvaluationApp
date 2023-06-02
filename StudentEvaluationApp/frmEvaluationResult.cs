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
    public partial class frmEvaluationResult : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();
        public frmEvaluationResult()
        {
            InitializeComponent();

            lbStudName.Text = dbh.GetFullName(Properties.Settings.Default.CurrentStudentID);
            lbStudNum.Text = dbh.GetStudNum(Properties.Settings.Default.CurrentStudentID);
            lbProgram.Text = Properties.Settings.Default.CurrentProgram;

            lbCv.Text = Properties.Settings.Default.CurrentCv;
            lbYear.Text = Properties.Settings.Default.CurrentYear.ToString();
            lbSem.Text = Properties.Settings.Default.CurrentSem.ToString();

            dgvCourses.DataSource = dbh.ShowCourseWithCurricuVerListWhereCvProgramSemYearMatch(
                Properties.Settings.Default.CurrentCvID,
                Properties.Settings.Default.CurrentProgramID,
                Properties.Settings.Default.CurrentSemID,
                Properties.Settings.Default.CurrentYearID);
        }

        private void frmEvaluationResult_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.CurrentYearID.ToString() + " " + Properties.Settings.Default.CurrentSemID.ToString());
        }

        private void frmEvaluationResult_SizeChanged(object sender, EventArgs e)
        {
            dgvCourses.Size = new Size((int)(this.Width * 0.98), (int)(this.Height * 0.6306));
        }
    }
}
