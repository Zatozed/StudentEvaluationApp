using System.Data.OleDb;
using System.Drawing;
using System.Security.Cryptography;

namespace StudentEvaluationApp
{
    public partial class Form1 : Form
    {
        private bool isProgramFormVisible = false;
        private bool isCurriculumFormVisible = false;

        private string onTopForm;

        ClassDBhelper cs = new ClassDBhelper();

        frmProgramMasterList fpml = new frmProgramMasterList()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };

        frmCurriculum fc = new frmCurriculum()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
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
                fpml.Dock = DockStyle.Fill;
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
                fc.Dock = DockStyle.Fill;
                fc.Show();
                fc.BringToFront();
                isCurriculumFormVisible = true;
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
        }
    }
}