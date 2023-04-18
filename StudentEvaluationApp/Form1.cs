namespace StudentEvaluationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowProgramForm()
        {
            frmProgramMasterList fpml = new frmProgramMasterList();
            fpml.TopLevel = false;
            fpml.AutoScroll = true;
            panel1.Controls.Add(fpml);
            fpml.Show();
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