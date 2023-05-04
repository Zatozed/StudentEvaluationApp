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
            tbCourseDes = new TextBox();
            label7 = new Label();
            label1 = new Label();
            tbCourseCode = new TextBox();
            nUnits = new NumericUpDown();
            label3 = new Label();
            tbCourseName = new TextBox();
            label2 = new Label();
            dgvCourse = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCourseCode = new DataGridViewTextBoxColumn();
            colCourseName = new DataGridViewTextBoxColumn();
            colCourseDes = new DataGridViewTextBoxColumn();
            colUnits = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDel = new DataGridViewImageColumn();
            btnSave = new Button();
            panel1 = new Panel();
            btnSearch = new Button();
            textBox1 = new TextBox();
            lbGotID = new Label();
            tbToSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tbCourseDes, 5, 0);
            tableLayoutPanel1.Controls.Add(label7, 4, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbCourseCode, 1, 0);
            tableLayoutPanel1.Controls.Add(nUnits, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(tbCourseName, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(dgvCourse, 0, 5);
            tableLayoutPanel1.Controls.Add(btnSave, 5, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSearch, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(lbGotID, 2, 1);
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbCourseDes
            // 
            tbCourseDes.Dock = DockStyle.Fill;
            tbCourseDes.Location = new Point(668, 3);
            tbCourseDes.Name = "tbCourseDes";
            tbCourseDes.Size = new Size(129, 23);
            tbCourseDes.TabIndex = 20;
            tbCourseDes.TextChanged += tbComponets_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(535, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 30);
            label7.TabIndex = 19;
            label7.Text = "Description/Components";
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
            tbCourseCode.Location = new Point(136, 3);
            tbCourseCode.Name = "tbCourseCode";
            tbCourseCode.Size = new Size(127, 23);
            tbCourseCode.TabIndex = 6;
            tbCourseCode.TextChanged += tbCourseCode_TextChanged;
            // 
            // nUnits
            // 
            nUnits.Dock = DockStyle.Fill;
            nUnits.Location = new Point(136, 33);
            nUnits.Name = "nUnits";
            nUnits.Size = new Size(127, 23);
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
            // tbCourseName
            // 
            tbCourseName.Dock = DockStyle.Fill;
            tbCourseName.Location = new Point(402, 3);
            tbCourseName.Name = "tbCourseName";
            tbCourseName.Size = new Size(127, 23);
            tbCourseName.TabIndex = 7;
            tbCourseName.TextChanged += tbSubDes_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Course Name:";
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.BackgroundColor = Color.White;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Columns.AddRange(new DataGridViewColumn[] { colID, colCourseCode, colCourseName, colCourseDes, colUnits, colEdit, colDel });
            tableLayoutPanel1.SetColumnSpan(dgvCourse, 6);
            dgvCourse.Dock = DockStyle.Fill;
            dgvCourse.Location = new Point(3, 132);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowTemplate.Height = 25;
            dgvCourse.Size = new Size(794, 315);
            dgvCourse.TabIndex = 14;
            dgvCourse.CellContentClick += dgvCourse_CellContentClick;
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
            colCourseDes.HeaderText = "Component/Description";
            colCourseDes.Name = "colCourseDes";
            colCourseDes.ReadOnly = true;
            // 
            // colUnits
            // 
            colUnits.DataPropertyName = "unit";
            colUnits.HeaderText = "Units";
            colUnits.Name = "colUnits";
            colUnits.ReadOnly = true;
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
            colDel.Resizable = DataGridViewTriState.True;
            colDel.Width = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Dock = DockStyle.Left;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(668, 62);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(panel1, 6);
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
            textBox1.Location = new Point(136, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 24;
            // 
            // lbGotID
            // 
            lbGotID.AutoSize = true;
            lbGotID.Location = new Point(269, 30);
            lbGotID.Name = "lbGotID";
            lbGotID.Size = new Size(44, 15);
            lbGotID.TabIndex = 25;
            lbGotID.Text = "hidden";
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
        private TextBox tbCourseName;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown nUnits;
        private TextBox tbCourseCode;
        private Button btnSearch;
        private TextBox tbToSearch;
        private Button btnSave;
        private DataGridView dgvCourse;
        private Label label7;
        private TextBox tbCourseDes;
        private Panel panel1;
        private TextBox textBox1;
        private Label lbGotID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCourseCode;
        private DataGridViewTextBoxColumn colCourseName;
        private DataGridViewTextBoxColumn colCourseDes;
        private DataGridViewTextBoxColumn colUnits;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDel;
    }
}