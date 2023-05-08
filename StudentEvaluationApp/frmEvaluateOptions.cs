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
    public partial class frmEvaluateOptions : Form
    {
        public frmEvaluateOptions()
        {
            InitializeComponent();
        }

        private void btnEvNewStud_Click(object sender, EventArgs e)
        {
            frmStudentReg frmStudentReg = new frmStudentReg();
            frmStudentReg.ControlBox = true;
            frmStudentReg.FormBorderStyle = FormBorderStyle.FixedSingle;
            frmStudentReg.ShowDialog();
        }
    }
}
