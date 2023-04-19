namespace StudentEvaluationApp
{
    public partial class Form1 : Form
    {
        private bool isProgramFormVisible = false;
        private bool isCurriculumFormVisible = false;

        frmProgramMasterList fpml = new frmProgramMasterList()
        {
            Dock = DockStyle.Fill,
            TopLevel = false
        };

        frmCurriculum fc = new frmCurriculum()
        {
            Dock = DockStyle.Fill,
            TopLevel = false
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowProgramForm()
        {


            if (isProgramFormVisible == true)
            {
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
        private void programMasterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProgramForm();
        }

        private void utilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void curriculumVersionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCurriculumFormVisible == true)
            {
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
    }
}