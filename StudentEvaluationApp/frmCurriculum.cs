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
    public partial class frmCurriculum : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();

        public frmCurriculum()
        {
            InitializeComponent();

            dgvCurricuVer.DataSource = dbh.ShowCurricuVerList();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (lbGotID.Text.Equals("") || lbGotID.Text.Equals("hidden"))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to save this?", "Save", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.InsertToCurricuVer(tbCurricuVer.Text);
                    tbCurricuVer.Clear();
                }

            }
            else if (tbCurricuVer.Text.Equals(""))
            {
                errorProvider1.SetError(tbCurricuVer, "Insert Curriculum version first!");
            }
            else
            {

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to save this changes?", "Save", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.EditAtCurricuVer(lbGotID.Text, tbCurricuVer.Text);
                    tbCurricuVer.Clear();
                    lbGotID.Text = "";
                }
            }
                dgvCurricuVer.DataSource = dbh.ShowCurricuVerList();
            
            
                
            

        }

        private void dgvCurricuVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurricuVer.Columns[e.ColumnIndex].Name.Equals("colEdit"))
            {
                lbGotID.Text = dgvCurricuVer.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                tbCurricuVer.Text = dgvCurricuVer.Rows[e.RowIndex].Cells["colCurricuDes"].Value.ToString();
            }
            else if (dgvCurricuVer.Columns[e.ColumnIndex].Name.Equals("colDel"))
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this?", "Delete", buttons);
                if (result == DialogResult.Yes)
                {
                    dbh.DelAtCurricuver(dgvCurricuVer.Rows[e.RowIndex].Cells["colID"].Value.ToString());
                }
            }
            dgvCurricuVer.DataSource = dbh.ShowCurricuVerList();
        }
    }
}
