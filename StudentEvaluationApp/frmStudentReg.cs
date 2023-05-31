using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace StudentEvaluationApp
{
    public partial class frmStudentReg : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();


        public frmStudentReg()
        {
            InitializeComponent();

            cbCurricuVer.DataSource = dbh.CurriculumVerList();
            cbProgram.DataSource = dbh.ProgramList();
            cbYear.DataSource = dbh.YearList();
            cbSem.DataSource = dbh.SemList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to Save this and Proceed", "Save", buttons);
            if (result == DialogResult.Yes)
            {
                dbh.InsertToStudent
                    (
                        tbStudentNum.Text, tbFname.Text, tbLname.Text, tbMname.Text,
                        cbSuffix.Text, cbGender.Text, tbAddress.Text, tbContactNum.Text,
                        tbPgName.Text, tbPgConNum.Text, tbLastSchoolAt.Text, dtpBdate.Text.ToString(),
                        Properties.Settings.Default.CurrentCV,
                        Properties.Settings.Default.CurrentProgram,
                        Properties.Settings.Default.CurrentYearID,
                        Properties.Settings.Default.CurrentSemID
                    );

                Properties.Settings.Default.CurrentStudentID = dbh.GetStudRecentID();

                foreach (DataRow s in dbh.GetCourseCurricuVerIDList
                    (Properties.Settings.Default.CurrentCV,
                    Properties.Settings.Default.CurrentProgram,
                    Properties.Settings.Default.CurrentSemID,
                    Properties.Settings.Default.CurrentYearID).Rows)
                {
                    dbh.InsertToStudentPermanentRecord(Properties.Settings.Default.CurrentStudentID, s[0].ToString());
                }

                this.Hide();

                frmInputGrades frmInput = new frmInputGrades(Properties.Settings.Default.CurrentStudentID);
                frmInput.ShowDialog();
                frmInput.BringToFront();

            }

        }

        private void cbCurricuVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentCV = dbh.GetCvID(cbCurricuVer.Text);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentYearID = dbh.GetYearID(cbYear.Text);
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentProgram = dbh.GetProgramID(cbProgram.Text);
        }

        private void cbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentSemID = dbh.GetSemID(cbSem.Text);
        }

        private void tbFname_Leave(object sender, EventArgs e)
        {
            if (tbFname.Text.Equals(""))
            {
                MessageBox.Show("First Name is required.");
                this.ActiveControl = tbFname;
            }
        }

        private void tbLname_Leave(object sender, EventArgs e)
        {
            if (tbLname.Text.Equals(""))
            {
                MessageBox.Show("Last Name is required.");
                this.ActiveControl = tbLname;
            }
        }

        private void tbContactNum_Leave(object sender, EventArgs e)
        {
            if (tbContactNum.Text.Length < 11 && !tbContactNum.Text.Equals(""))
            {
                MessageBox.Show("Contact number must be 11 digits.");
                this.ActiveControl = tbContactNum;
            }
        }

        private void tbPgName_Leave(object sender, EventArgs e)
        {
            if (tbPgName.Text.Equals(""))
            {
                MessageBox.Show("Parent/Guardian name is required.");
                this.ActiveControl = tbPgName;
            }
        }

        private void tbPgConNum_Leave(object sender, EventArgs e)
        {
            if (tbPgConNum.Text.Length < 11 && !tbPgConNum.Text.Equals(""))
            {
                MessageBox.Show("Contact number must be 11 digits.");
                this.ActiveControl = tbPgConNum;
            }
        }

        private void tbStudentNum_Leave(object sender, EventArgs e)
        {
            if (tbStudentNum.Text.Length < 11 || tbStudentNum.Text.Equals(""))
            {
                MessageBox.Show("Student number is required and must be 11 digits.");
                this.ActiveControl = tbStudentNum;
            }
        }

        private void frmStudentReg_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbStudentNum;
        }
    }
}
