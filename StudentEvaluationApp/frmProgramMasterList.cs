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
    public partial class frmProgramMasterList : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();

        public frmProgramMasterList()
        {
            InitializeComponent();

            dgvPrograms.DataSource = dbh.ShowProgramList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbGotID.Text.Equals("") || lbGotID.Text.Equals("hidden"))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to save this?", "Save", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.InsertToProgram(tbProgramCode.Text, tbProgramName.Text);

                    tbProgramCode.Clear();
                    tbProgramName.Clear();
                    lbGotID.Text = "";
                }

            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to save this changes?", "Save", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.EditAtProgram(tbProgramCode.Text, tbProgramName.Text, lbGotID.Text);

                    tbProgramCode.Clear();
                    tbProgramName.Clear();
                    lbGotID.Text = "";
                }
            }

            dgvPrograms.DataSource = dbh.ShowProgramList();
        }

        private void dgvPrograms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrograms.Columns[e.ColumnIndex].Name.Equals("colEdit"))
            {
                lbGotID.Text = dgvPrograms.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                tbProgramCode.Text = dgvPrograms.Rows[e.RowIndex].Cells["colProgCode"].Value.ToString();
                tbProgramName.Text = dgvPrograms.Rows[e.RowIndex].Cells["colProgName"].Value.ToString();
            }
            else if (dgvPrograms.Columns[e.ColumnIndex].Name.Equals("colDel"))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this?", "Delete", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.DeleteAtProgram(dgvPrograms.Rows[e.RowIndex].Cells["colID"].Value.ToString());
                    dgvPrograms.DataSource = dbh.ShowProgramList();
                }
            }
            //
        }
    }
}
