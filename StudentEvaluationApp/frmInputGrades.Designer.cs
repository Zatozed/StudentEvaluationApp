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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            dgvCourseGrade = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCourse = new DataGridViewTextBoxColumn();
            colGrade = new DataGridViewTextBoxColumn();
            colGrade2 = new DataGridViewTextBoxColumn();
            colGrade3 = new DataGridViewTextBoxColumn();
            btnNext = new Button();
            textBox1 = new TextBox();
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
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(label7, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(label10, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 2, 4);
            tableLayoutPanel1.Controls.Add(label13, 1, 6);
            tableLayoutPanel1.Controls.Add(label12, 0, 6);
            tableLayoutPanel1.Controls.Add(label14, 0, 5);
            tableLayoutPanel1.Controls.Add(label15, 1, 5);
            tableLayoutPanel1.Controls.Add(label16, 2, 5);
            tableLayoutPanel1.Controls.Add(dgvCourseGrade, 0, 7);
            tableLayoutPanel1.Controls.Add(btnNext, 2, 8);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 29);
            label2.Margin = new Padding(3, 0, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "###########";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(535, 54);
            label5.Margin = new Padding(3, 0, 3, 10);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 4;
            label5.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(269, 54);
            label4.Margin = new Padding(3, 0, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 54);
            label3.Margin = new Padding(3, 0, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 79);
            label6.Margin = new Padding(3, 0, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 5;
            label6.Text = "FFFFFFF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 79);
            label8.Margin = new Padding(3, 0, 3, 10);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 7;
            label8.Text = "MMMMM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 79);
            label7.Margin = new Padding(3, 0, 3, 10);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 6;
            label7.Text = "LLLLLLL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 104);
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
            label10.Location = new Point(269, 104);
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
            label11.Location = new Point(535, 104);
            label11.Margin = new Padding(3, 0, 3, 10);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 10;
            label11.Text = "Semester";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(269, 154);
            label13.Margin = new Padding(3, 0, 3, 10);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 12;
            label13.Text = "VVVVVV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 154);
            label12.Margin = new Padding(3, 0, 3, 10);
            label12.Name = "label12";
            label12.Size = new Size(129, 15);
            label12.TabIndex = 11;
            label12.Text = "Curriculum Version";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 129);
            label14.Margin = new Padding(3, 0, 3, 10);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 13;
            label14.Text = "PPPP";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(269, 129);
            label15.Margin = new Padding(3, 0, 3, 10);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 14;
            label15.Text = "YY";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(535, 129);
            label16.Margin = new Padding(3, 0, 3, 10);
            label16.Name = "label16";
            label16.Size = new Size(25, 15);
            label16.TabIndex = 15;
            label16.Text = "SSS";
            // 
            // dgvCourseGrade
            // 
            dgvCourseGrade.AllowUserToAddRows = false;
            dgvCourseGrade.AllowUserToDeleteRows = false;
            dgvCourseGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourseGrade.BackgroundColor = Color.White;
            dgvCourseGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourseGrade.Columns.AddRange(new DataGridViewColumn[] { colID, colCourse, colGrade, colGrade2, colGrade3 });
            tableLayoutPanel1.SetColumnSpan(dgvCourseGrade, 3);
            dgvCourseGrade.Dock = DockStyle.Fill;
            dgvCourseGrade.Location = new Point(3, 182);
            dgvCourseGrade.Name = "dgvCourseGrade";
            dgvCourseGrade.ReadOnly = true;
            dgvCourseGrade.RowTemplate.Height = 25;
            dgvCourseGrade.Size = new Size(794, 232);
            dgvCourseGrade.TabIndex = 16;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colCourse
            // 
            colCourse.HeaderText = "Course";
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // 
            // colGrade
            // 
            colGrade.HeaderText = "Grade/s";
            colGrade.Name = "colGrade";
            colGrade.ReadOnly = true;
            // 
            // colGrade2
            // 
            colGrade2.HeaderText = "";
            colGrade2.Name = "colGrade2";
            colGrade2.ReadOnly = true;
            // 
            // colGrade3
            // 
            colGrade3.HeaderText = "";
            colGrade3.Name = "colGrade3";
            colGrade3.ReadOnly = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // frmInputGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmInputGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Grades";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseGrade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private DataGridView dgvCourseGrade;
        private Button btnNext;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn colGrade2;
        private DataGridViewTextBoxColumn colGrade3;
        private TextBox textBox1;
    }
}