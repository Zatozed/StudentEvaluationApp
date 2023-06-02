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

        public frmInputGrades()
        {
            InitializeComponent();
        }
        public frmInputGrades(string studId)
        {
            InitializeComponent();

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

                if (Properties.Settings.Default.CurrentSem == 1)
                {
                    Properties.Settings.Default.CurrentSem += 1;
                    
                }
                else if (Properties.Settings.Default.CurrentSem == 2 && Properties.Settings.Default.CurrentYear < 4)
                {
                    Properties.Settings.Default.CurrentSem -= 1;
                    Properties.Settings.Default.CurrentYear += 1;
                }

                dbh.UpdateStudentSemYearStudentInfo(
                    Properties.Settings.Default.CurrentStudentID,
                    dbh.GetSemID(Properties.Settings.Default.CurrentSem.ToString()),
                    dbh.GetYearID(Properties.Settings.Default.CurrentYear.ToString()));

                Properties.Settings.Default.CurrentSemID = dbh.GetSemID(Properties.Settings.Default.CurrentSem.ToString());
                Properties.Settings.Default.CurrentYearID = dbh.GetSemID(Properties.Settings.Default.CurrentYear.ToString());

                foreach (DataRow s in dbh.GetSemYearFromStudentInfo(Properties.Settings.Default.CurrentStudentID).Rows) 
                {
                    Properties.Settings.Default.CurrentSemID = s[0].ToString();
                    Properties.Settings.Default.CurrentYearID = s[1].ToString();
                }

                foreach (DataRow s in dbh.GetCourseWithCurricuVerIDListWhereCvProgramSemYearMatch(
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

            Properties.Settings.Default.CurrentSem = dbh.GetSemByID(Properties.Settings.Default.CurrentSemID);
            Properties.Settings.Default.CurrentYear = dbh.GetYearByID(Properties.Settings.Default.CurrentYearID);

            lbYear.Text = Properties.Settings.Default.CurrentYear.ToString();
            lbSem.Text = Properties.Settings.Default.CurrentSem.ToString();
        }
    }
}
