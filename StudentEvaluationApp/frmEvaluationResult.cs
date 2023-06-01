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
    public partial class frmEvaluationResult : Form
    {
        ClassDBhelper dbh = new ClassDBhelper();
        public frmEvaluationResult()
        {
            InitializeComponent();

            lbStudName.Text = dbh.GetFullName(Properties.Settings.Default.CurrentStudentID);
            lbStudNum.Text = dbh.GetStudNum(Properties.Settings.Default.CurrentStudentID);
        }

        private void frmEvaluationResult_Load(object sender, EventArgs e)
        {
            //if sem = sem1 do sem 2
        }
    }
}
