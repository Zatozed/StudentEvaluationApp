namespace StudentEvaluationApp
{
    partial class frmConfigureDb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbDBpath = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnBrowse = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(tbDBpath, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 2);
            tableLayoutPanel1.Controls.Add(btnBrowse, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(445, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbDBpath
            // 
            tableLayoutPanel1.SetColumnSpan(tbDBpath, 2);
            tbDBpath.Dock = DockStyle.Fill;
            tbDBpath.Location = new Point(3, 18);
            tbDBpath.Name = "tbDBpath";
            tbDBpath.Size = new Size(439, 23);
            tbDBpath.TabIndex = 0;
            tbDBpath.TextChanged += tbDBpath_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Database Location";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(299, 47);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(3, 47);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // frmConfigureDb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 76);
            Controls.Add(tableLayoutPanel1);
            Name = "frmConfigureDb";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configure Database";
            Load += frmConfigureDb_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbDBpath;
        private Label label1;
        private Button btnSave;
        private Button btnBrowse;
    }
}