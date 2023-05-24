namespace StudentEvaluationApp
{
    partial class frmManageCurriculum
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
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnSearch = new Button();
            btnNext = new Button();
            dgvCourses = new DataGridView();
            colCourseID = new DataGridViewTextBoxColumn();
            colCourseCode = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colUnits = new DataGridViewTextBoxColumn();
            colToRight = new DataGridViewImageColumn();
            dgvToCurriculum = new DataGridView();
            colIDToCv = new DataGridViewTextBoxColumn();
            colCourseCodeToCv = new DataGridViewTextBoxColumn();
            colCourseToCv = new DataGridViewTextBoxColumn();
            colUnitsToCv = new DataGridViewTextBoxColumn();
            colPrereq = new DataGridViewComboBoxColumn();
            colCash = new DataGridViewTextBoxColumn();
            colLowMonthly = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvToCurriculum).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666622F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 4, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(btnSearch, 1, 1);
            tableLayoutPanel1.Controls.Add(btnNext, 5, 8);
            tableLayoutPanel1.Controls.Add(dgvCourses, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvToCurriculum, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 2, 2);
            tableLayoutPanel1.Controls.Add(label6, 4, 2);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(comboBox3, 5, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            tableLayoutPanel1.SetColumnSpan(label1, 6);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 15);
            label1.TabIndex = 0;
            label1.Text = "Courses";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 21);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 15);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 4;
            label5.Text = "C V";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 15);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Curriculum Version:";
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.White;
            btnSearch.BackgroundImage = R_icons1.icons8_search_50;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(136, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(37, 14);
            btnSearch.TabIndex = 11;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.AutoSize = true;
            btnNext.BackColor = Color.ForestGreen;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(722, 420);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 27);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToOrderColumns = true;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Columns.AddRange(new DataGridViewColumn[] { colCourseID, colCourseCode, colCourse, colUnits, colToRight });
            tableLayoutPanel1.SetColumnSpan(dgvCourses, 6);
            dgvCourses.Dock = DockStyle.Fill;
            dgvCourses.Location = new Point(3, 65);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowTemplate.Height = 25;
            dgvCourses.Size = new Size(794, 151);
            dgvCourses.TabIndex = 6;
            dgvCourses.CellContentClick += dgvCourses_CellContentClick;
            // 
            // colCourseID
            // 
            colCourseID.DataPropertyName = "courseID";
            colCourseID.HeaderText = "ID";
            colCourseID.Name = "colCourseID";
            colCourseID.ReadOnly = true;
            colCourseID.Visible = false;
            // 
            // colCourseCode
            // 
            colCourseCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCourseCode.DataPropertyName = "courseCode";
            colCourseCode.HeaderText = "Course Code";
            colCourseCode.Name = "colCourseCode";
            colCourseCode.ReadOnly = true;
            // 
            // colCourse
            // 
            colCourse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCourse.DataPropertyName = "courseName";
            colCourse.HeaderText = "Course";
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // 
            // colUnits
            // 
            colUnits.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colUnits.DataPropertyName = "unit";
            colUnits.HeaderText = "Units";
            colUnits.Name = "colUnits";
            colUnits.ReadOnly = true;
            colUnits.Width = 60;
            // 
            // colToRight
            // 
            colToRight.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colToRight.HeaderText = "";
            colToRight.Image = R_icons1.icons8_arrow_right_24;
            colToRight.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colToRight.Name = "colToRight";
            colToRight.ReadOnly = true;
            colToRight.Resizable = DataGridViewTriState.True;
            colToRight.SortMode = DataGridViewColumnSortMode.Automatic;
            colToRight.Width = 19;
            // 
            // dgvToCurriculum
            // 
            dgvToCurriculum.AllowUserToAddRows = false;
            dgvToCurriculum.AllowUserToDeleteRows = false;
            dgvToCurriculum.AllowUserToOrderColumns = true;
            dgvToCurriculum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToCurriculum.BackgroundColor = Color.White;
            dgvToCurriculum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToCurriculum.Columns.AddRange(new DataGridViewColumn[] { colIDToCv, colCourseCodeToCv, colCourseToCv, colUnitsToCv, colPrereq, colCash, colLowMonthly });
            tableLayoutPanel1.SetColumnSpan(dgvToCurriculum, 6);
            dgvToCurriculum.Dock = DockStyle.Fill;
            dgvToCurriculum.Location = new Point(3, 242);
            dgvToCurriculum.Name = "dgvToCurriculum";
            dgvToCurriculum.ReadOnly = true;
            dgvToCurriculum.RowTemplate.Height = 25;
            dgvToCurriculum.Size = new Size(794, 151);
            dgvToCurriculum.TabIndex = 7;
            // 
            // colIDToCv
            // 
            colIDToCv.HeaderText = "ID";
            colIDToCv.Name = "colIDToCv";
            colIDToCv.ReadOnly = true;
            // 
            // colCourseCodeToCv
            // 
            colCourseCodeToCv.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colCourseCodeToCv.HeaderText = "Course Code";
            colCourseCodeToCv.Name = "colCourseCodeToCv";
            colCourseCodeToCv.ReadOnly = true;
            colCourseCodeToCv.Width = 95;
            // 
            // colCourseToCv
            // 
            colCourseToCv.HeaderText = "Course";
            colCourseToCv.Name = "colCourseToCv";
            colCourseToCv.ReadOnly = true;
            // 
            // colUnitsToCv
            // 
            colUnitsToCv.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colUnitsToCv.HeaderText = "Units";
            colUnitsToCv.Name = "colUnitsToCv";
            colUnitsToCv.ReadOnly = true;
            colUnitsToCv.Width = 60;
            // 
            // colPrereq
            // 
            colPrereq.HeaderText = "Prerequisite Of:";
            colPrereq.Name = "colPrereq";
            colPrereq.ReadOnly = true;
            // 
            // colCash
            // 
            colCash.HeaderText = "Cash Payment";
            colCash.Name = "colCash";
            colCash.ReadOnly = true;
            colCash.Resizable = DataGridViewTriState.True;
            colCash.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLowMonthly
            // 
            colLowMonthly.HeaderText = "Low Monthly Payment";
            colLowMonthly.Name = "colLowMonthly";
            colLowMonthly.ReadOnly = true;
            colLowMonthly.Resizable = DataGridViewTriState.True;
            colLowMonthly.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 42);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 13;
            label3.Text = "Year:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 42);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Term:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(402, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(668, 45);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 17;
            // 
            // frmManageCurriculum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmManageCurriculum";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmManageCurriculum_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvToCurriculum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private DataGridView dgvCourses;
        private DataGridView dgvToCurriculum;
        private Button btnSearch;
        private Button btnNext;
        private Label label2;
        private Label label3;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridViewTextBoxColumn colCourseID;
        private DataGridViewTextBoxColumn colCourseCode;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colUnits;
        private DataGridViewImageColumn colToRight;
        private DataGridViewTextBoxColumn colIDToCv;
        private DataGridViewTextBoxColumn colCourseCodeToCv;
        private DataGridViewTextBoxColumn colCourseToCv;
        private DataGridViewTextBoxColumn colUnitsToCv;
        private DataGridViewComboBoxColumn colPrereq;
        private DataGridViewTextBoxColumn colCash;
        private DataGridViewTextBoxColumn colLowMonthly;
    }
}