using System;
using System.Collections.Generic;
using System.Data;

namespace StudentEvaluationApp
{
    public partial class frmInputGrades : Form
    {
        private ClassDBhelper dbh = new ClassDBhelper();

        private DataTable studCurrent;

        private string cvID, programID, yearID, semID;

        public frmInputGrades()
        {
            InitializeComponent();
        }
        public frmInputGrades(string studId)
        {
            InitializeComponent();

            studCurrent = dbh.GetStudInfo(studId);

            dgvCourseGrade.DataSource = dbh.ShowCourseAndGrade(studId);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dbh.bagsakGradeCourseList.Clear();

            foreach (DataGridViewRow r in dgvCourseGrade.Rows)
            {
                if (Convert.ToDouble(r.Cells["colGrade"].Value) == 5)
                {
                    dbh.bagsakGradeCourseList.Add(r.Cells["colPrereqOf"].Value.ToString());
                }

            }

            this.Hide();

            frmEvaluationResult frmEvaluationRes = new frmEvaluationResult();
            frmEvaluationRes.ShowDialog();
            frmEvaluationRes.BringToFront();
        }

        private void frmInputGrades_Load(object sender, EventArgs e)
        {
            foreach (DataRow r in studCurrent.Rows)
            {
                lbStudNo.Text = r[0].ToString();
                lbFname.Text = r[1].ToString();
                lbLname.Text = r[2].ToString();
                lbMname.Text = r[3].ToString();

                cvID = r[4].ToString();
                programID = r[5].ToString();
                yearID = r[6].ToString();
                semID = r[7].ToString();

            }

            lbCv.Text = dbh.GetCurriculumVersionByID(cvID);
            lbProgram.Text = dbh.GetProgramDesByID(programID);
            lbYear.Text = dbh.GetYearDesByID(yearID);
            lbSem.Text = dbh.GetSemDesByID(semID);
        }
    }
}
