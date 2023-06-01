using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;

namespace StudentEvaluationApp
{
    public partial class frmInputGrades : Form
    {
        private ClassDBhelper dbh = new ClassDBhelper();

        //private DataTable studCurrent;

        //private string cvID, programID, yearID, semID;
        private int currentYear, currentSem;

        public frmInputGrades()
        {
            InitializeComponent();
        }
        public frmInputGrades(string studId)
        {
            InitializeComponent();

            //studCurrent = dbh.GetStudInfo(studId);

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
                else if (currentSem == 2 && currentYear <= 4)
                {
                    --currentSem;
                    ++currentYear;
                }
                dbh.UpdateStudentSemYear(Properties.Settings.Default.CurrentStudentID,
                    Properties.Settings.Default.CurrentYearID,
                    Properties.Settings.Default.CurrentSemID);

                ;
                ;
                foreach (DataRow s in dbh.GetCourseCurricuVerIDList(
                    Properties.Settings.Default.CurrentCvID,
                    Properties.Settings.Default.CurrentProgramID,
                    Properties.Settings.Default.CurrentSemID,
                    Properties.Settings.Default.CurrentYearID).Rows)
                {
                    dbh.InsertToStudentPermanentRecord(Properties.Settings.Default.CurrentStudentID, s[0].ToString());
                }

            }

            this.Hide();

            frmEvaluationResult frmEvaluationRes = new frmEvaluationResult();
            frmEvaluationRes.ShowDialog();
            frmEvaluationRes.BringToFront();
        }

        private void frmInputGrades_Load(object sender, EventArgs e)
        {
            lbStudNo.Text = Properties.Settings.Default.CurrentStudNum;
            lbFname.Text = Properties.Settings.Default.CurrentStudFname;

            lbCv.Text = dbh.GetCurriculumVersionByID(Properties.Settings.Default.CurrentCvID);
            lbProgram.Text = dbh.GetProgramDesByID(Properties.Settings.Default.CurrentProgramID);
            lbYear.Text = dbh.GetYearByID(Properties.Settings.Default.CurrentYearID).ToString();
            lbSem.Text = dbh.GetSemByID(Properties.Settings.Default.CurrentSemID).ToString();
        }
    }
}
