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

            dgvCourse.DataSource = dbh.ShowCourseList();

            btnSave.Enabled = false;
            nUnits.Value = 3;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbGotID.Text.Equals("") || lbGotID.Text.Equals("hidden"))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to save this new Course?", "Save", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.InsertToCourse(tbCourseCode.Text, tbCourseName.Text, tbCourseDes.Text, Convert.ToInt32(nUnits.Value));
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to save this changes?", "Save", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.EditAtCourse
                        (tbCourseCode.Text, tbCourseName.Text, tbCourseDes.Text,
                        Convert.ToInt32(nUnits.Value), Convert.ToInt32(lbGotID.Text));

                    lbGotID.Text = "";
                    tbCourseCode.Clear();
                    tbCourseName.Clear();
                    tbCourseDes.Clear();
                    nUnits.Value = 3;
                }
            }
            dgvCourse.DataSource = dbh.ShowCourseList();

        }

        private void tbCourseCode_TextChanged(object sender, EventArgs e)
        {
            if (tbCourseCode.Text.Equals("") || tbCourseName.Text.Equals(""))
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
            if (tbCourseCode.Text.Equals("") || tbCourseName.Text.Equals("") || tbCourseDes.Text.Equals(""))
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
            if (tbCourseCode.Text.Equals("") || tbCourseName.Text.Equals("") || tbCourseDes.Text.Equals(""))
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
            if (tbCourseCode.Text.Equals("") || tbCourseName.Text.Equals("") || tbCourseDes.Text.Equals(""))
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
            if (tbCourseCode.Text.Equals("") || tbCourseName.Text.Equals("") || tbCourseDes.Text.Equals(""))
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

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourse.Columns[e.ColumnIndex].Name.Equals("colEdit"))
            {
                lbGotID.Text = dgvCourse.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                tbCourseCode.Text = dgvCourse.Rows[e.RowIndex].Cells["colCourseCode"].Value.ToString();
                tbCourseName.Text = dgvCourse.Rows[e.RowIndex].Cells["colCourseName"].Value.ToString();
                tbCourseDes.Text = dgvCourse.Rows[e.RowIndex].Cells["colCourseDes"].Value.ToString();
                nUnits.Text = dgvCourse.Rows[e.RowIndex].Cells["colUnits"].Value.ToString();
            }
            else if (dgvCourse.Columns[e.ColumnIndex].Name.Equals("colDel"))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this?", "Delete", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.DelAtCourse(dgvCourse.Rows[e.RowIndex].Cells["colID"].Value.ToString());
                }
            }
            dgvCourse.DataSource = dbh.ShowCourseList();
        }
    }
}
