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
            label1 = new Label();
            tbCourseCode = new TextBox();
            nUnits = new NumericUpDown();
            label3 = new Label();
            tbSubDes = new TextBox();
            label2 = new Label();
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
            tbToSearch = new TextBox();
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
            tableLayoutPanel1.Controls.Add(tbPrereq, 7, 1);
            tableLayoutPanel1.Controls.Add(label8, 5, 1);
            tableLayoutPanel1.Controls.Add(tbComponets, 7, 0);
            tableLayoutPanel1.Controls.Add(label7, 5, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbCourseCode, 1, 0);
            tableLayoutPanel1.Controls.Add(nUnits, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(tbSubDes, 4, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 1);
            tableLayoutPanel1.Controls.Add(tbLvlTerm, 4, 1);
            tableLayoutPanel1.Controls.Add(dgvCourse, 0, 5);
            tableLayoutPanel1.Controls.Add(btnSave, 7, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSearch, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPrereq
            // 
            tbPrereq.Dock = DockStyle.Fill;
            tbPrereq.Location = new Point(697, 33);
            tbPrereq.Name = "tbPrereq";
            tbPrereq.Size = new Size(100, 23);
            tbPrereq.TabIndex = 22;
            tbPrereq.TextChanged += tbPrereq_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 30);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 21;
            label8.Text = "Prerequisite of:";
            // 
            // tbComponets
            // 
            tbComponets.Dock = DockStyle.Fill;
            tbComponets.Location = new Point(697, 3);
            tbComponets.Name = "tbComponets";
            tbComponets.Size = new Size(100, 23);
            tbComponets.TabIndex = 20;
            tbComponets.TextChanged += tbComponets_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 19;
            label7.Text = "Components";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Code:";
            // 
            // tbCourseCode
            // 
            tbCourseCode.Dock = DockStyle.Fill;
            tbCourseCode.Location = new Point(108, 3);
            tbCourseCode.Name = "tbCourseCode";
            tbCourseCode.Size = new Size(99, 23);
            tbCourseCode.TabIndex = 6;
            tbCourseCode.TextChanged += tbCourseCode_TextChanged;
            // 
            // nUnits
            // 
            nUnits.Dock = DockStyle.Fill;
            nUnits.Location = new Point(108, 33);
            nUnits.Name = "nUnits";
            nUnits.Size = new Size(99, 23);
            nUnits.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Units";
            // 
            // tbSubDes
            // 
            tbSubDes.Dock = DockStyle.Fill;
            tbSubDes.Location = new Point(402, 3);
            tbSubDes.Name = "tbSubDes";
            tbSubDes.Size = new Size(99, 23);
            tbSubDes.TabIndex = 7;
            tbSubDes.TextChanged += tbSubDes_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 1;
            label2.Text = "Subject Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 30);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "Level/Term";
            // 
            // tbLvlTerm
            // 
            tbLvlTerm.Dock = DockStyle.Fill;
            tbLvlTerm.Location = new Point(402, 33);
            tbLvlTerm.Name = "tbLvlTerm";
            tbLvlTerm.Size = new Size(99, 23);
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
            dgvCourse.Location = new Point(3, 132);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowTemplate.Height = 25;
            dgvCourse.Size = new Size(794, 315);
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
            btnSave.Location = new Point(722, 62);
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
            panel1.Location = new Point(3, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 3);
            panel1.TabIndex = 23;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(3, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 26);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(108, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(99, 23);
            textBox1.TabIndex = 24;
            // 
            // tbToSearch
            // 
            tbToSearch.Location = new Point(269, 192);
            tbToSearch.Name = "tbToSearch";
            tbToSearch.Size = new Size(100, 23);
            tbToSearch.TabIndex = 11;
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
        private Label label5;
        private NumericUpDown nUnits;
        private TextBox tbCourseCode;
        private Button btnSearch;
        private TextBox tbToSearch;
        private Button btnSave;
        private DataGridView dgvCourse;
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
    }
}