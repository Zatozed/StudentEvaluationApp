namespace StudentEvaluationApp
{
    public partial class Form1 : Form
    {
        private bool isProgramFormVisible = false;
        private bool isCurriculumFormVisible = false;

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
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowProgramForm()
        {
            if (isProgramFormVisible == true)
            {
                fpml.Hide();
                fpml.Show();
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
                fc.Hide();
                fc.Show();
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
        }

        private void utilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void curriculumVersionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCurriculumForm();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}