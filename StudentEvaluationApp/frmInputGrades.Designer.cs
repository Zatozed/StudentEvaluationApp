namespace StudentEvaluationApp
{
    partial class frmInputGrades
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbStudNo = new Label();
            label1 = new Label();
            label3 = new Label();
            lbFname = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lbCv = new Label();
            label12 = new Label();
            lbProgram = new Label();
            lbYear = new Label();
            lbSem = new Label();
            dgvCourseGrade = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCourseCode = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colGrade2 = new DataGridViewTextBoxColumn();
            colGrade3 = new DataGridViewTextBoxColumn();
            colPrereqOf = new DataGridViewTextBoxColumn();
            colStudentID = new DataGridViewTextBoxColumn();
            btnNext = new Button();
            tbSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseGrade).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lbStudNo, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(label10, 1, 3);
            tableLayoutPanel1.Controls.Add(label11, 2, 3);
            tableLayoutPanel1.Controls.Add(lbCv, 1, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 5);
            tableLayoutPanel1.Controls.Add(lbProgram, 0, 4);
            tableLayoutPanel1.Controls.Add(lbYear, 1, 4);
            tableLayoutPanel1.Controls.Add(lbSem, 2, 4);
            tableLayoutPanel1.Controls.Add(dgvCourseGrade, 0, 6);
            tableLayoutPanel1.Controls.Add(btnNext, 2, 7);
            tableLayoutPanel1.Controls.Add(tbSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(lbFname, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbStudNo
            // 
            lbStudNo.AutoSize = true;
            lbStudNo.Location = new Point(269, 29);
            lbStudNo.Margin = new Padding(3, 0, 3, 10);
            lbStudNo.Name = "lbStudNo";
            lbStudNo.Size = new Size(84, 15);
            lbStudNo.TabIndex = 1;
            lbStudNo.Text = "###########";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 29);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 54);
            label3.Margin = new Padding(3, 0, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Student Name:";
            // 
            // lbFname
            // 
            lbFname.AutoSize = true;
            lbFname.Location = new Point(269, 54);
            lbFname.Margin = new Padding(3, 0, 3, 10);
            lbFname.Name = "lbFname";
            lbFname.Size = new Size(49, 15);
            lbFname.TabIndex = 5;
            lbFname.Text = "FFFFFFF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 79);
            label9.Margin = new Padding(3, 0, 3, 10);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 8;
            label9.Text = "Program";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(269, 79);
            label10.Margin = new Padding(3, 0, 3, 10);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 9;
            label10.Text = "Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(535, 79);
            label11.Margin = new Padding(3, 0, 3, 10);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 10;
            label11.Text = "Semester";
            // 
            // lbCv
            // 
            lbCv.AutoSize = true;
            lbCv.Location = new Point(269, 129);
            lbCv.Margin = new Padding(3, 0, 3, 10);
            lbCv.Name = "lbCv";
            lbCv.Size = new Size(49, 15);
            lbCv.TabIndex = 12;
            lbCv.Text = "VVVVVV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 129);
            label12.Margin = new Padding(3, 0, 3, 10);
            label12.Name = "label12";
            label12.Size = new Size(129, 15);
            label12.TabIndex = 11;
            label12.Text = "Curriculum Version";
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Location = new Point(3, 104);
            lbProgram.Margin = new Padding(3, 0, 3, 10);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(35, 15);
            lbProgram.TabIndex = 13;
            lbProgram.Text = "PPPP";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new Point(269, 104);
            lbYear.Margin = new Padding(3, 0, 3, 10);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(21, 15);
            lbYear.TabIndex = 14;
            lbYear.Text = "YY";
            // 
            // lbSem
            // 
            lbSem.AutoSize = true;
            lbSem.Location = new Point(535, 104);
            lbSem.Margin = new Padding(3, 0, 3, 10);
            lbSem.Name = "lbSem";
            lbSem.Size = new Size(25, 15);
            lbSem.TabIndex = 15;
            lbSem.Text = "SSS";
            // 
            // dgvCourseGrade
            // 
            dgvCourseGrade.AllowUserToAddRows = false;
            dgvCourseGrade.AllowUserToDeleteRows = false;
            dgvCourseGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourseGrade.BackgroundColor = Color.White;
            dgvCourseGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseGrade.Columns.AddRange(new DataGridViewColumn[] { colID, colCourseCode, colCourse, colGrade, colGrade2, colGrade3, colPrereqOf, colStudentID });
            tableLayoutPanel1.SetColumnSpan(dgvCourseGrade, 3);
            dgvCourseGrade.Dock = DockStyle.Fill;
            dgvCourseGrade.Location = new Point(3, 157);
            dgvCourseGrade.Name = "dgvCourseGrade";
            dgvCourseGrade.RowTemplate.Height = 25;
            dgvCourseGrade.Size = new Size(794, 257);
            dgvCourseGrade.TabIndex = 16;
            // 
            // colID
            // 
            colID.DataPropertyName = "recordID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colCourseCode
            // 
            colCourseCode.DataPropertyName = "courseCode";
            colCourseCode.HeaderText = "Course Code";
            colCourseCode.Name = "colCourseCode";
            colCourseCode.ReadOnly = true;
            // 
            // colCourse
            // 
            colCourse.DataPropertyName = "courseName";
            colCourse.HeaderText = "Course";
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // 
            // colGrade
            // 
            colGrade.DataPropertyName = "grade1stTake";
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            colGrade.DefaultCellStyle = dataGridViewCellStyle3;
            colGrade.HeaderText = "Grade (1st Take)";
            colGrade.Name = "colGrade";
            // 
            // colGrade2
            // 
            colGrade2.DataPropertyName = "grade2ndTake";
            colGrade2.HeaderText = "Grade (2nd Take)";
            colGrade2.Name = "colGrade2";
            // 
            // colGrade3
            // 
            colGrade3.DataPropertyName = "grade3rdTake";
            colGrade3.HeaderText = "Grade (3rd Take)";
            colGrade3.Name = "colGrade3";
            // 
            // colPrereqOf
            // 
            colPrereqOf.DataPropertyName = "prereqID";
            colPrereqOf.HeaderText = "PrereqOf";
            colPrereqOf.Name = "colPrereqOf";
            colPrereqOf.ReadOnly = true;
            // 
            // colStudentID
            // 
            colStudentID.HeaderText = "StudentID";
            colStudentID.Name = "colStudentID";
            colStudentID.ReadOnly = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.AutoSize = true;
            btnNext.BackColor = Color.ForestGreen;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(722, 420);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 27);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // tbSearch
            // 
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.Location = new Point(3, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(260, 23);
            tbSearch.TabIndex = 18;
            tbSearch.Text = "Search by Student No.";
            // 
            // frmInputGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmInputGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "p-";
            Load += frmInputGrades_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseGrade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbStudNo;
        private Label label1;
        private Label label3;
        private Label lbFname;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lbCv;
        private Label lbProgram;
        private Label lbYear;
        private Label lbSem;
        private DataGridView dgvCourseGrade;
        private Button btnNext;
        private TextBox tbSearch;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCourseCode;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colGrade2;
        private DataGridViewTextBoxColumn colGrade3;
        private DataGridViewTextBoxColumn colPrereqOf;
        private DataGridViewTextBoxColumn colStudentID;
    }
}