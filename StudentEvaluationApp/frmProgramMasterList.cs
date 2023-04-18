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
                dbh.InsertToProgram(tbProgramCode.Text, tbProgramName.Text);
                //MessageBox.Show("inser pag");
            }
            else 
            {
                dbh.EditAtProgram(tbProgramCode.Text, tbProgramName.Text, lbGotID.Text);

                tbProgramCode.Clear();
                tbProgramName.Clear();
                lbGotID.Text = "";
                //MessageBox.Show("pag number laber");
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
                dbh.DeleteAtProgram(dgvPrograms.Rows[e.RowIndex].Cells["colID"].Value.ToString());
                dgvPrograms.DataSource = dbh.ShowProgramList();
            }
        }
    }
}
