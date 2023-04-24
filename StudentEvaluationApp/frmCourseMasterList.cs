using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentEvaluationApp
{
    public partial class frmCourseMasterList : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();
        public frmCourseMasterList()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            cbCurricuVer.DataSource = dbh.CurriculumVerList();
            cbProgram.DataSource = dbh.ProgramList();

            nUnits.Value = 3;

            dgvCourse.DataSource = dbh.ShowCourseList();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tbCourseCode_TextChanged(object sender, EventArgs e)
        {
            if (tbCourseCode.Text.Equals("") || tbSubDes.Text.Equals("") || tbLvlTerm.Text.Equals(""))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void tbSubDes_TextChanged(object sender, EventArgs e)
        {
            if (tbCourseCode.Text.Equals("") || tbSubDes.Text.Equals("") || tbLvlTerm.Text.Equals("") || tbComponets.Text.Equals("") || tbPrereq.Text.Equals(""))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void tbLvlTerm_TextChanged(object sender, EventArgs e)
        {
            if (tbCourseCode.Text.Equals("") || tbSubDes.Text.Equals("") || tbLvlTerm.Text.Equals("") || tbComponets.Text.Equals("") || tbPrereq.Text.Equals(""))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void tbComponets_TextChanged(object sender, EventArgs e)
        {
            if (tbCourseCode.Text.Equals("") || tbSubDes.Text.Equals("") || tbLvlTerm.Text.Equals("") || tbComponets.Text.Equals("") || tbPrereq.Text.Equals(""))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void tbPrereq_TextChanged(object sender, EventArgs e)
        {
            if (tbCourseCode.Text.Equals("") || tbSubDes.Text.Equals("") || tbLvlTerm.Text.Equals("") || tbComponets.Text.Equals("") || tbPrereq.Text.Equals(""))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnOpenCurricuVer_Click(object sender, EventArgs e)
        {
            frmCurriculum fc = new frmCurriculum();

            fc.WindowState = FormWindowState.Normal;
            fc.FormBorderStyle = FormBorderStyle.FixedSingle;
            fc.ControlBox = true;
            fc.MinimizeBox = false;
            fc.MaximizeBox = false;
            fc.ShowDialog();
        }

        private void btnOpenProgram_Click(object sender, EventArgs e)
        {
            frmProgramMasterList fp = new frmProgramMasterList();
            fp.WindowState = FormWindowState.Normal;
            fp.FormBorderStyle = FormBorderStyle.FixedDialog;
            fp.ControlBox = true;
            fp.MinimizeBox = false;
            fp.MaximizeBox = false;
            fp.ShowDialog();
        }
    }
}
