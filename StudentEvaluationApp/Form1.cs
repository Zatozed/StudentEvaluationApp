using System.Data.OleDb;
using System.Drawing;
using System.Security.Cryptography;

namespace StudentEvaluationApp
{
    public partial class Form1 : Form
    {
        private bool isProgramFormVisible = false;
        private bool isCurriculumFormVisible = false;
        private bool isCourseMasterListFormVisible = false;
        private bool isEvauationFormVisible = false;

        private string onTopForm = "";

        ClassDBhelper cs = new ClassDBhelper();

        frmProgramMasterList fpml = new frmProgramMasterList()
        {
            Dock = DockStyle.Fill,
            TopLevel = false
        };

        frmCurriculum fc = new frmCurriculum()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
        };
        frmCourseMasterList frmCourse = new frmCourseMasterList()
        {
            Dock = DockStyle.Fill,
            TopLevel = false
        };
        frmEvaluateOptions frmEvaluateOp = new frmEvaluateOptions()
        {
            Dock = DockStyle.Fill,
            TopLevel = false
        };

        frmConfigureDb frmConfig = new frmConfigureDb();

        public Form1()
        {
            InitializeComponent();
            checkCon();
        }

        private void ShowProgramForm()
        {
            if (isProgramFormVisible == true)
            {
                panel1.Controls.Remove(fpml);
                panel1.Controls.Add(fpml);
                fpml.BringToFront();
            }
            else
            {
                fpml.AutoScroll = true;
                panel1.Controls.Add(fpml);
                fpml.Show();
                fpml.BringToFront();
                isProgramFormVisible = true;
            }
        }
        private void ShowCurriculumForm()
        {

            if (isCurriculumFormVisible == true)
            {
                panel1.Controls.Remove(fc);
                panel1.Controls.Add(fc);
                fc.BringToFront();
            }
            else
            {
                fc.AutoScroll = true;
                panel1.Controls.Add(fc);
                fc.Show();
                fc.BringToFront();
                isCurriculumFormVisible = true;
            }
        }
        private void ShowCourseMasterListForm()
        {
            if (isCourseMasterListFormVisible == true)
            {
                panel1.Controls.Remove(frmCourse);
                panel1.Controls.Add(frmCourse);
                frmCourse.BringToFront();
            }
            else
            {
                frmCourse.AutoScroll = true;
                panel1.Controls.Add(frmCourse);
                frmCourse.Show();
                frmCourse.BringToFront();
                isCourseMasterListFormVisible = true;
            }
        }
        private void ShowEvaluateOpForm()
        {
            if (isEvauationFormVisible == true)
            {
                panel1.Controls.Remove(frmEvaluateOp);
                panel1.Controls.Add(frmEvaluateOp);
                frmEvaluateOp.BringToFront();
            }
            else
            {
                frmEvaluateOp.AutoScroll = true;
                panel1.Controls.Add(frmEvaluateOp);
                frmEvaluateOp.Show();
                frmEvaluateOp.BringToFront();
                isEvauationFormVisible = true;
            }
        }
        private void programMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProgramForm();
            onTopForm = fpml.Name;
        }

        private void utilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void curriculumVersionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCurriculumForm();
            onTopForm = fc.Name;
        }
        private void courseMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCourseMasterListForm();
            onTopForm = frmCourse.Name;
        }
        private void studentMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }


        private void checkCon()
        {

            if (cs.TestCon() == 1)
            {
                toolStripStatusLabel1.Text = "Database Connected";
            }
            else
            {
                toolStripStatusLabel1.Text = "Database Not Connected";
            }


        }

        private void configureDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (onTopForm.Equals(fpml.Name))
            {
                panel1.Controls.Remove(fpml);
                panel1.Controls.Add(fpml);

                fpml.BringToFront();
            }
            else if (onTopForm.Equals(fc.Name))
            {
                panel1.Controls.Remove(fc);
                panel1.Controls.Add(fc);

                fc.BringToFront();
            }
            else if (onTopForm.Equals(frmCourse.Name))
            {
                panel1.Controls.Remove(frmCourse);
                panel1.Controls.Add(frmCourse);

                frmCourse.BringToFront();
            }
            else if (onTopForm.Equals(frmEvaluateOp.Name))
            {
                panel1.Controls.Remove(frmEvaluateOp);
                panel1.Controls.Add(frmEvaluateOp);
            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEvaluateOpForm();
            onTopForm = frmEvaluateOp.Name;
        }
    }
}