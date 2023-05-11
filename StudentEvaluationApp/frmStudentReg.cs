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

        string cvID, programID, yearID, semID;

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
                    mtbStudentNum.Text, tbFname.Text, tbLname.Text, tbMname.Text,
                    cbSuffix.Text, cbGender.Text, tbAddress.Text, tbContactNum.Text,
                    tbPgName.Text, tbPgConNum.Text, tbLastSchoolAt.Text, dtpBdate.Text.ToString(),
                    cvID, programID, yearID, semID
                    );

                this.Hide();

                frmInputGrades frmInput = new frmInputGrades();
                frmInput.ShowDialog();
                frmInput.BringToFront();
            }



        }

        private void cbCurricuVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cvID = dbh.GetCvID(cbCurricuVer.Text);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearID = dbh.GetYearID(cbYear.Text);
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            programID = dbh.GetProgramID(cbProgram.Text);
        }

        private void cbSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            semID = dbh.GetSemID(cbSem.Text);
        }

        private void mtbStudentNum_Leave(object sender, EventArgs e)
        {
            if (mtbStudentNum.Text.Length != 11)
            {
                MessageBox.Show("Student number must be 11 digits");
                this.ActiveControl = mtbStudentNum;
            }

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

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            //if (tbAddress.Text.Equals(""))
            //{
            //    MessageBox.Show("Address is required.");
            //    this.ActiveControl = tbLname;
            //}
        }
    }
}
