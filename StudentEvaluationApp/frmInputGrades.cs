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
    public partial class frmInputGrades : Form
    {
        private ClassDBhelper dbh = new ClassDBhelper();

        private DataTable studCurrent;

        private string cvID, programID, yearID, semID;

        public frmInputGrades()
        {
            InitializeComponent();
        }
        public frmInputGrades(string studId)
        {
            InitializeComponent();

            studCurrent = dbh.GetStudInfo(studId);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEvaluationResult frmEvaluationRes = new frmEvaluationResult();
            frmEvaluationRes.ShowDialog();
            frmEvaluationRes.BringToFront();
        }

        private void frmInputGrades_Load(object sender, EventArgs e)
        {
            //foreach (DataRow r in studCurrent.Rows) 
            //{
            //    lbStudNo.Text = r[0].ToString();
            //    lbFname.Text = r[1].ToString();
            //    lbLname.Text = r[2].ToString();
            //    lbMname.Text = r[3].ToString();

            //    cvID = r[4].ToString();
            //    programID = r[5].ToString();
            //    yearID = r[6].ToString();
            //    semID = r[7].ToString();
            //}

            //MessageBox.Show(dbh.GetCurriculumVersionByID("16"));
            //MessageBox.Show(dbh.GetProgramDesByID("1"));
            //MessageBox.Show(dbh.GetYearDesByID("1"));
            //MessageBox.Show(dbh.GetYearDesByID("1"));
        }
    }
}
