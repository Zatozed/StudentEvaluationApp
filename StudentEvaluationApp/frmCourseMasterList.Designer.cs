namespace StudentEvaluationApp
{
    partial class frmCourseMasterList
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
            tbPrereq = new TextBox();
            label8 = new Label();
            tbComponets = new TextBox();
            label7 = new Label();
            label4 = new Label();
            cbCurricuVer = new ComboBox();
            label1 = new Label();
            tbCourseCode = new TextBox();
            nUnits = new NumericUpDown();
            label3 = new Label();
            tbSubDes = new TextBox();
            label2 = new Label();
            cbProgram = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            tbLvlTerm = new TextBox();
            dgvCourse = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCourseCode = new DataGridViewTextBoxColumn();
            colCourseDes = new DataGridViewTextBoxColumn();
            colComponent = new DataGridViewTextBoxColumn();
            colUnits = new DataGridViewTextBoxColumn();
            colProgID = new DataGridViewTextBoxColumn();
            colProg = new DataGridViewTextBoxColumn();
            colCurricuVerID = new DataGridViewTextBoxColumn();
            colCurriculumVer = new DataGridViewTextBoxColumn();
            colPrereq = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            btnSave = new Button();
            panel1 = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            btnOpenCurricuVer = new Button();
            btnOpenProgram = new Button();
            tbToSearch = new TextBox();
            lbGotCurricuVerID = new Label();
            label10 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(label10, 7, 0);
            tableLayoutPanel1.Controls.Add(tbPrereq, 7, 2);
            tableLayoutPanel1.Controls.Add(label8, 5, 2);
            tableLayoutPanel1.Controls.Add(tbComponets, 7, 1);
            tableLayoutPanel1.Controls.Add(label7, 5, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(cbCurricuVer, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tbCourseCode, 1, 1);
            tableLayoutPanel1.Controls.Add(nUnits, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(tbSubDes, 4, 1);
            tableLayoutPanel1.Controls.Add(label2, 3, 1);
            tableLayoutPanel1.Controls.Add(cbProgram, 5, 0);
            tableLayoutPanel1.Controls.Add(label6, 4, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 2);
            tableLayoutPanel1.Controls.Add(tbLvlTerm, 4, 2);
            tableLayoutPanel1.Controls.Add(dgvCourse, 0, 6);
            tableLayoutPanel1.Controls.Add(btnSave, 7, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSearch, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(btnOpenCurricuVer, 2, 0);
            tableLayoutPanel1.Controls.Add(btnOpenProgram, 6, 0);
            tableLayoutPanel1.Controls.Add(lbGotCurricuVerID, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPrereq
            // 
            tbPrereq.Dock = DockStyle.Fill;
            tbPrereq.Location = new Point(675, 62);
            tbPrereq.Name = "tbPrereq";
            tbPrereq.Size = new Size(122, 23);
            tbPrereq.TabIndex = 22;
            tbPrereq.TextChanged += tbPrereq_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(525, 59);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 21;
            label8.Text = "Prerequisite of:";
            // 
            // tbComponets
            // 
            tbComponets.Dock = DockStyle.Fill;
            tbComponets.Location = new Point(675, 33);
            tbComponets.Name = "tbComponets";
            tbComponets.Size = new Size(122, 23);
            tbComponets.TabIndex = 20;
            tbComponets.TextChanged += tbComponets_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 30);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 19;
            label7.Text = "Components";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Curriculum Version";
            // 
            // cbCurricuVer
            // 
            cbCurricuVer.Dock = DockStyle.Fill;
            cbCurricuVer.FormattingEnabled = true;
            cbCurricuVer.Location = new Point(127, 3);
            cbCurricuVer.Name = "cbCurricuVer";
            cbCurricuVer.Size = new Size(118, 23);
            cbCurricuVer.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Code:";
            // 
            // tbCourseCode
            // 
            tbCourseCode.Dock = DockStyle.Fill;
            tbCourseCode.Location = new Point(127, 33);
            tbCourseCode.Name = "tbCourseCode";
            tbCourseCode.Size = new Size(118, 23);
            tbCourseCode.TabIndex = 6;
            tbCourseCode.TextChanged += tbCourseCode_TextChanged;
            // 
            // nUnits
            // 
            nUnits.Dock = DockStyle.Fill;
            nUnits.Location = new Point(127, 62);
            nUnits.Name = "nUnits";
            nUnits.Size = new Size(118, 23);
            nUnits.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 59);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Units";
            // 
            // tbSubDes
            // 
            tbSubDes.Dock = DockStyle.Fill;
            tbSubDes.Location = new Point(401, 33);
            tbSubDes.Name = "tbSubDes";
            tbSubDes.Size = new Size(118, 23);
            tbSubDes.TabIndex = 7;
            tbSubDes.TextChanged += tbSubDes_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 30);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Subject Description:";
            // 
            // cbProgram
            // 
            cbProgram.Dock = DockStyle.Fill;
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(525, 3);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(118, 23);
            cbProgram.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 15;
            label6.Text = "Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 59);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "Level/Term";
            // 
            // tbLvlTerm
            // 
            tbLvlTerm.Dock = DockStyle.Fill;
            tbLvlTerm.Location = new Point(401, 62);
            tbLvlTerm.Name = "tbLvlTerm";
            tbLvlTerm.Size = new Size(118, 23);
            tbLvlTerm.TabIndex = 9;
            tbLvlTerm.TextChanged += tbLvlTerm_TextChanged;
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.BackgroundColor = Color.White;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Columns.AddRange(new DataGridViewColumn[] { colID, colCourseCode, colCourseDes, colComponent, colUnits, colProgID, colProg, colCurricuVerID, colCurriculumVer, colPrereq, colEdit, dataGridViewImageColumn1 });
            tableLayoutPanel1.SetColumnSpan(dgvCourse, 8);
            dgvCourse.Dock = DockStyle.Fill;
            dgvCourse.Location = new Point(3, 161);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowTemplate.Height = 25;
            dgvCourse.Size = new Size(794, 286);
            dgvCourse.TabIndex = 14;
            // 
            // colID
            // 
            colID.DataPropertyName = "courseID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colCourseCode
            // 
            colCourseCode.DataPropertyName = "courseCode";
            colCourseCode.HeaderText = "Code";
            colCourseCode.Name = "colCourseCode";
            colCourseCode.ReadOnly = true;
            // 
            // colCourseDes
            // 
            colCourseDes.DataPropertyName = "courseDescription";
            colCourseDes.HeaderText = "Description";
            colCourseDes.Name = "colCourseDes";
            colCourseDes.ReadOnly = true;
            // 
            // colComponent
            // 
            colComponent.DataPropertyName = "courseComponent";
            colComponent.HeaderText = "Component";
            colComponent.Name = "colComponent";
            colComponent.ReadOnly = true;
            // 
            // colUnits
            // 
            colUnits.DataPropertyName = "units";
            colUnits.HeaderText = "Units";
            colUnits.Name = "colUnits";
            colUnits.ReadOnly = true;
            // 
            // colProgID
            // 
            colProgID.DataPropertyName = "programID";
            colProgID.HeaderText = "ProgramID";
            colProgID.Name = "colProgID";
            colProgID.ReadOnly = true;
            // 
            // colProg
            // 
            colProg.DataPropertyName = "programCode";
            colProg.HeaderText = "Program";
            colProg.Name = "colProg";
            colProg.ReadOnly = true;
            // 
            // colCurricuVerID
            // 
            colCurricuVerID.DataPropertyName = "curricuVerID";
            colCurricuVerID.HeaderText = "curriculumVerID";
            colCurricuVerID.Name = "colCurricuVerID";
            colCurricuVerID.ReadOnly = true;
            // 
            // colCurriculumVer
            // 
            colCurriculumVer.DataPropertyName = "curricuDescription";
            colCurriculumVer.HeaderText = "Curriculum Version";
            colCurriculumVer.Name = "colCurriculumVer";
            colCurriculumVer.ReadOnly = true;
            // 
            // colPrereq
            // 
            colPrereq.DataPropertyName = "prereqCourseID";
            colPrereq.HeaderText = "Prereq";
            colPrereq.Name = "colPrereq";
            colPrereq.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "";
            colEdit.Image = R_icons1.icons8_edit_50;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "";
            dataGridViewImageColumn1.Image = R_icons1.icons8_delete_48;
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.True;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Location = new Point(722, 91);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(panel1, 8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 3);
            panel1.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(3, 129);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 26);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(127, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 24;
            // 
            // btnOpenCurricuVer
            // 
            btnOpenCurricuVer.BackgroundImage = R_icons1.icons8_add_new_50;
            btnOpenCurricuVer.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenCurricuVer.FlatAppearance.BorderSize = 0;
            btnOpenCurricuVer.FlatStyle = FlatStyle.Flat;
            btnOpenCurricuVer.Location = new Point(251, 3);
            btnOpenCurricuVer.Name = "btnOpenCurricuVer";
            btnOpenCurricuVer.Size = new Size(20, 20);
            btnOpenCurricuVer.TabIndex = 17;
            btnOpenCurricuVer.UseVisualStyleBackColor = true;
            btnOpenCurricuVer.Click += btnOpenCurricuVer_Click;
            // 
            // btnOpenProgram
            // 
            btnOpenProgram.BackgroundImage = R_icons1.icons8_add_new_50;
            btnOpenProgram.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenProgram.FlatAppearance.BorderSize = 0;
            btnOpenProgram.FlatStyle = FlatStyle.Flat;
            btnOpenProgram.Location = new Point(649, 3);
            btnOpenProgram.Name = "btnOpenProgram";
            btnOpenProgram.Size = new Size(20, 20);
            btnOpenProgram.TabIndex = 18;
            btnOpenProgram.UseVisualStyleBackColor = true;
            btnOpenProgram.Click += btnOpenProgram_Click;
            // 
            // tbToSearch
            // 
            tbToSearch.Location = new Point(269, 192);
            tbToSearch.Name = "tbToSearch";
            tbToSearch.Size = new Size(100, 23);
            tbToSearch.TabIndex = 11;
            // 
            // lbGotCurricuVerID
            // 
            lbGotCurricuVerID.AutoSize = true;
            lbGotCurricuVerID.Location = new Point(277, 0);
            lbGotCurricuVerID.Name = "lbGotCurricuVerID";
            lbGotCurricuVerID.Size = new Size(111, 30);
            lbGotCurricuVerID.TabIndex = 25;
            lbGotCurricuVerID.Text = "Curriculum version ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(675, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 26;
            label10.Text = "program ID";
            // 
            // frmCourseMasterList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCourseMasterList";
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbLvlTerm;
        private TextBox tbSubDes;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private NumericUpDown nUnits;
        private TextBox tbCourseCode;
        private ComboBox cbCurricuVer;
        private Button btnSearch;
        private TextBox tbToSearch;
        private Button btnSave;
        private DataGridView dgvCourse;
        private Label label6;
        private ComboBox cbProgram;
        private Button btnOpenCurricuVer;
        private Button btnOpenProgram;
        private Label label7;
        private TextBox tbComponets;
        private TextBox tbPrereq;
        private Label label8;
        private Panel panel1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCourseCode;
        private DataGridViewTextBoxColumn colCourseDes;
        private DataGridViewTextBoxColumn colComponent;
        private DataGridViewTextBoxColumn colUnits;
        private DataGridViewTextBoxColumn colProgID;
        private DataGridViewTextBoxColumn colProg;
        private DataGridViewTextBoxColumn colCurricuVerID;
        private DataGridViewTextBoxColumn colCurriculumVer;
        private DataGridViewTextBoxColumn colPrereq;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Label label10;
        private Label lbGotCurricuVerID;
    }
}