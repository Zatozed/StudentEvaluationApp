namespace StudentEvaluationApp
{
    partial class frmProgramMasterList
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            tbProgramCode = new TextBox();
            label1 = new Label();
            tbProgramName = new TextBox();
            btnSave = new Button();
            dgvPrograms = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colProgCode = new DataGridViewTextBoxColumn();
            colProgName = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDel = new DataGridViewImageColumn();
            lbGotID = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrograms).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.110363F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4448166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4448128F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(tbProgramCode, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbProgramName, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 2, 1);
            tableLayoutPanel1.Controls.Add(dgvPrograms, 0, 2);
            tableLayoutPanel1.Controls.Add(lbGotID, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Program Name";
            // 
            // tbProgramCode
            // 
            tbProgramCode.Location = new Point(3, 18);
            tbProgramCode.Name = "tbProgramCode";
            tbProgramCode.Size = new Size(100, 23);
            tbProgramCode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Program Code";
            // 
            // tbProgramName
            // 
            tbProgramName.Location = new Point(267, 18);
            tbProgramName.Name = "tbProgramName";
            tbProgramName.Size = new Size(100, 23);
            tbProgramName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(534, 18);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvPrograms
            // 
            dgvPrograms.AllowUserToAddRows = false;
            dgvPrograms.AllowUserToDeleteRows = false;
            dgvPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrograms.Columns.AddRange(new DataGridViewColumn[] { colID, colProgCode, colProgName, colEdit, colDel });
            tableLayoutPanel1.SetColumnSpan(dgvPrograms, 3);
            dgvPrograms.Dock = DockStyle.Fill;
            dgvPrograms.Location = new Point(3, 47);
            dgvPrograms.Name = "dgvPrograms";
            dgvPrograms.ReadOnly = true;
            dgvPrograms.RowTemplate.Height = 25;
            dgvPrograms.Size = new Size(794, 400);
            dgvPrograms.TabIndex = 5;
            dgvPrograms.CellContentClick += dgvPrograms_CellContentClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "programID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // colProgCode
            // 
            colProgCode.DataPropertyName = "programCode";
            colProgCode.HeaderText = "Program Code";
            colProgCode.Name = "colProgCode";
            colProgCode.ReadOnly = true;
            // 
            // colProgName
            // 
            colProgName.DataPropertyName = "programName";
            colProgName.HeaderText = "Program Name";
            colProgName.Name = "colProgName";
            colProgName.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colEdit.HeaderText = "";
            colEdit.Image = R_icons1.icons8_edit_50;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Width = 5;
            // 
            // colDel
            // 
            colDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colDel.HeaderText = "";
            colDel.Image = R_icons1.icons8_delete_48;
            colDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDel.Name = "colDel";
            colDel.ReadOnly = true;
            colDel.Width = 5;
            // 
            // lbGotID
            // 
            lbGotID.AutoSize = true;
            lbGotID.Location = new Point(534, 0);
            lbGotID.Name = "lbGotID";
            lbGotID.Size = new Size(44, 15);
            lbGotID.TabIndex = 6;
            lbGotID.Text = "hidden";
            lbGotID.Visible = false;
            // 
            // frmProgramMasterList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "frmProgramMasterList";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrograms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox tbProgramCode;
        private Label label1;
        private TextBox tbProgramName;
        private Button btnSave;
        private DataGridView dgvPrograms;
        private Label lbGotID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colProgCode;
        private DataGridViewTextBoxColumn colProgName;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDel;
    }
}