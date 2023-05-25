namespace StudentEvaluationApp
{
    partial class frmSetPrerequisiteOf
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
            dgvSelect = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCourseCode = new DataGridViewTextBoxColumn();
            colCourseName = new DataGridViewTextBoxColumn();
            colCourseDes = new DataGridViewTextBoxColumn();
            colCourseUnits = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            lbCourse = new Label();
            label2 = new Label();
            btnSelect = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelect).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dgvSelect, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbCourse, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSelect, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(707, 244);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvSelect
            // 
            dgvSelect.AllowUserToAddRows = false;
            dgvSelect.AllowUserToDeleteRows = false;
            dgvSelect.AllowUserToOrderColumns = true;
            dgvSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelect.BackgroundColor = Color.White;
            dgvSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelect.Columns.AddRange(new DataGridViewColumn[] { colID, colCourseCode, colCourseName, colCourseDes, colCourseUnits });
            tableLayoutPanel1.SetColumnSpan(dgvSelect, 4);
            dgvSelect.Dock = DockStyle.Fill;
            dgvSelect.Location = new Point(3, 47);
            dgvSelect.Name = "dgvSelect";
            dgvSelect.ReadOnly = true;
            dgvSelect.RowTemplate.Height = 25;
            dgvSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelect.Size = new Size(701, 165);
            dgvSelect.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "courseID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // colCourseCode
            // 
            colCourseCode.DataPropertyName = "courseCode";
            colCourseCode.HeaderText = "Course Code";
            colCourseCode.Name = "colCourseCode";
            colCourseCode.ReadOnly = true;
            // 
            // colCourseName
            // 
            colCourseName.DataPropertyName = "courseName";
            colCourseName.HeaderText = "Course";
            colCourseName.Name = "colCourseName";
            colCourseName.ReadOnly = true;
            // 
            // colCourseDes
            // 
            colCourseDes.DataPropertyName = "courseDes";
            colCourseDes.HeaderText = "Description";
            colCourseDes.Name = "colCourseDes";
            colCourseDes.ReadOnly = true;
            // 
            // colCourseUnits
            // 
            colCourseUnits.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colCourseUnits.DataPropertyName = "unit";
            colCourseUnits.HeaderText = "Units";
            colCourseUnits.Name = "colCourseUnits";
            colCourseUnits.ReadOnly = true;
            colCourseUnits.Width = 59;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(3, 29);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(44, 15);
            lbCourse.TabIndex = 4;
            lbCourse.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 29);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "is Prerequisit of:";
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.Location = new Point(629, 218);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmSetPrerequisiteOf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 244);
            Controls.Add(tableLayoutPanel1);
            Name = "frmSetPrerequisiteOf";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvSelect;
        private TextBox textBox1;
        private Label lbCourse;
        private Label label2;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCourseCode;
        private DataGridViewTextBoxColumn colCourseName;
        private DataGridViewTextBoxColumn colCourseDes;
        private DataGridViewTextBoxColumn colCourseUnits;
        private Button btnSelect;
    }
}