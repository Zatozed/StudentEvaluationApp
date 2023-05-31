using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

namespace StudentEvaluationApp
{
    public partial class frmInputGrades : Form
    {
        private ClassDBhelper dbh = new ClassDBhelper();

        private DataTable studCurrent;

        private string studentID, cvID, programID, yearID, semID;
        private int currentYear, currentSem;

        public frmInputGrades()
        {
            InitializeComponent();
        }
        public frmInputGrades(string studId)
        {
            InitializeComponent();

            studentID = studId;

            studCurrent = dbh.GetStudInfo(studId);

            dgvCourseGrade.DataSource = dbh.ShowCourseAndGrade(studId);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dbh.bagsakGradeCourseArrList.Clear();

            if (dgvCourseGrade.RowCount != 0)
            {
                foreach (DataGridViewRow r in dgvCourseGrade.Rows)
                {
                    if (Convert.ToDouble(r.Cells["colGrade3"].Value) != 0)
                    {
                        if (Convert.ToDouble(r.Cells["colGrade3"].Value) == 5)
                        {
                            dbh.bagsakGradeCourseArrList.Add(r.Cells["colPrereqOf"].Value.ToString());
                        }
                    }
                    else if (Convert.ToDouble(r.Cells["colGrade2"].Value) != 0)
                    {
                        if (Convert.ToDouble(r.Cells["colGrade2"].Value) == 5)
                        {
                            dbh.bagsakGradeCourseArrList.Add(r.Cells["colPrereqOf"].Value.ToString());
                        }
                    }
                    else if (Convert.ToDouble(r.Cells["colGrade"].Value) != 0)
                    {
                        if (Convert.ToDouble(r.Cells["colGrade"].Value) == 5)
                        {
                            dbh.bagsakGradeCourseArrList.Add(r.Cells["colPrereqOf"].Value.ToString());
                        }
                    }

                    dbh.UpdateStudentPermanentRecord(
                        r.Cells["colID"].Value.ToString(),
                        Convert.ToDouble(r.Cells["colGrade"].Value),
                        Convert.ToDouble(r.Cells["colGrade2"].Value),
                        Convert.ToDouble(r.Cells["colGrade3"].Value)
                        );
                }

                if (currentSem == 1)
                {
                    ++currentSem;
                }
                else if(currentSem == 2 && currentYear <= 4)
                {
                    --currentSem;
                    ++currentYear;
                }

                dbh.UpdateStudentSemYear(studentID, dbh.GetYearID(currentYear.ToString()), dbh.GetSemID(currentSem.ToString()));

                foreach (string s in dbh.bagsakGradeCourseArrList)
                {

                }
            }

            //this.Hide();

            //frmEvaluationResult frmEvaluationRes = new frmEvaluationResult();
            //frmEvaluationRes.ShowDialog();
            //frmEvaluationRes.BringToFront();
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

                currentSem = dbh.GetSemByID(semID);
                currentYear = dbh.GetYearByID(yearID);
            }

            lbCv.Text = dbh.GetCurriculumVersionByID(cvID);
            lbProgram.Text = dbh.GetProgramDesByID(programID);
            lbYear.Text = dbh.GetYearByID(yearID).ToString();
            lbSem.Text = dbh.GetSemByID(semID).ToString();
        }
    }
}
