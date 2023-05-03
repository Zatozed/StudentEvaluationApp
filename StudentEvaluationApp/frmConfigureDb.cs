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
    public partial class frmConfigureDb : Form
    {
        private string provider = "Provider=Microsoft.ACE.OLEDB.12.0;";
        private string location = "Data Source=";
        private string con = "";

        private ClassDBhelper dbh = new ClassDBhelper();

        public frmConfigureDb()
        {
            InitializeComponent();
            dbh.con = new System.Data.OleDb.OleDbConnection(Properties.Settings.Default.ConString);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                location = location + openFileDialog1.FileName;
                con = con + provider + location;

                tbDBpath.Text = con;

                Properties.Settings.Default.ConString = @con;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Restart Application to Save Changes", "Save", buttons);
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void frmConfigureDb_Load(object sender, EventArgs e)
        {
            tbDBpath.Text = Properties.Settings.Default.ConString;
        }

        private void tbDBpath_TextChanged(object sender, EventArgs e)
        {
            tbDBpath.Text.TrimStart().TrimEnd();
        }
    }
}
