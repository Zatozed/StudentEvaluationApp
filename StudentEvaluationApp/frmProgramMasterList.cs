﻿using System;
using System.Windows.Forms;

namespace StudentEvaluationApp
{
    public partial class frmProgramMasterList : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();

        public frmProgramMasterList()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            dgvPrograms.DataSource = dbh.ShowProgramList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbProgramCode.Text = tbProgramCode.Text.TrimStart().TrimEnd();
            tbProgramName.Text = tbProgramName.Text.TrimStart().TrimEnd();

            if (tbProgramCode.Text.Equals(null) || tbProgramCode.Text.Equals(""))
            {
                errorProvider1.SetError(tbProgramCode, "Enter a Program code!");
                errorProvider1.SetError(tbProgramName, "Enter a Program name!");
            }
            else if (lbGotID.Text.Equals("") || lbGotID.Text.Equals("hidden"))
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

        private void frmProgramMasterList_Load(object sender, EventArgs e)
        {

        }

        private void tbProgramCode_TextChanged(object sender, EventArgs e)
        {
            if (tbProgramCode.Text.Equals("") || tbProgramName.Text.Equals(""))
            {
                btnSave.Enabled = false;

            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void tbProgramName_TextChanged(object sender, EventArgs e)
        {
            if (tbProgramCode.Text.Equals("") || tbProgramName.Text.Equals(""))
            {
                btnSave.Enabled = false;

            }
            else
            {
                btnSave.Enabled = true;
            }
        }
    }
}
