namespace StudentEvaluationApp
{
    public partial class Form1 : Form
    {
        private bool isProgramFormVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowProgramForm()
        {
            frmProgramMasterList fpml = new frmProgramMasterList();

            if (isProgramFormVisible == true)
            {
                fpml.BringToFront();
            }
            else
            {
                fpml.TopLevel = false;
                fpml.AutoScroll = true;
                panel1.Controls.Add(fpml);
                fpml.Show();
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
    }
}