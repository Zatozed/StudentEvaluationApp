namespace StudentEvaluationApp
{
    partial class frmEvaluationResult
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lbStudName = new Label();
            label4 = new Label();
            lbStudNum = new Label();
            label6 = new Label();
            lbProgram = new Label();
            label8 = new Label();
            lbCv = new Label();
            label10 = new Label();
            lbYear = new Label();
            label12 = new Label();
            lbSem = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvCourses = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.Controls.Add(button2, 4, 5);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(lbStudName, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(lbStudNum, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(lbProgram, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 3, 1);
            tableLayoutPanel1.Controls.Add(lbCv, 4, 1);
            tableLayoutPanel1.Controls.Add(label10, 3, 2);
            tableLayoutPanel1.Controls.Add(lbYear, 4, 2);
            tableLayoutPanel1.Controls.Add(label12, 3, 3);
            tableLayoutPanel1.Controls.Add(lbSem, 4, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(799, 451);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.ForestGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(695, 421);
            button2.Name = "button2";
            button2.Size = new Size(101, 27);
            button2.TabIndex = 4;
            button2.Text = "Print and Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 0);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 5;
            label1.Text = "Evaluation and Charge Slip";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 25);
            label2.Margin = new Padding(3, 0, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Student Name:";
            // 
            // lbStudName
            // 
            lbStudName.AutoSize = true;
            lbStudName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudName.Location = new Point(154, 25);
            lbStudName.Margin = new Padding(3, 0, 3, 10);
            lbStudName.Name = "lbStudName";
            lbStudName.Size = new Size(41, 15);
            lbStudName.TabIndex = 7;
            lbStudName.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 50);
            label4.Margin = new Padding(3, 0, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Student #:";
            // 
            // lbStudNum
            // 
            lbStudNum.AutoSize = true;
            lbStudNum.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudNum.Location = new Point(154, 50);
            lbStudNum.Margin = new Padding(3, 0, 3, 10);
            lbStudNum.Name = "lbStudNum";
            lbStudNum.Size = new Size(41, 15);
            lbStudNum.TabIndex = 9;
            lbStudNum.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 75);
            label6.Margin = new Padding(3, 0, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Program:";
            // 
            // lbProgram
            // 
            lbProgram.AutoSize = true;
            lbProgram.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbProgram.Location = new Point(154, 75);
            lbProgram.Margin = new Padding(3, 0, 3, 10);
            lbProgram.Name = "lbProgram";
            lbProgram.Size = new Size(41, 15);
            lbProgram.TabIndex = 11;
            lbProgram.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(496, 25);
            label8.Margin = new Padding(3, 0, 3, 10);
            label8.Name = "label8";
            label8.Size = new Size(133, 15);
            label8.TabIndex = 12;
            label8.Text = "Curriculum Version:";
            // 
            // lbCv
            // 
            lbCv.AutoSize = true;
            lbCv.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCv.Location = new Point(647, 25);
            lbCv.Margin = new Padding(3, 0, 3, 10);
            lbCv.Name = "lbCv";
            lbCv.Size = new Size(41, 15);
            lbCv.TabIndex = 13;
            lbCv.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(496, 50);
            label10.Margin = new Padding(3, 0, 3, 10);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 14;
            label10.Text = "Year:";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbYear.Location = new Point(647, 50);
            lbYear.Margin = new Padding(3, 0, 3, 10);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(48, 15);
            lbYear.TabIndex = 15;
            lbYear.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(496, 75);
            label12.Margin = new Padding(3, 0, 3, 10);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 16;
            label12.Text = "Semester:";
            // 
            // lbSem
            // 
            lbSem.AutoSize = true;
            lbSem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSem.Location = new Point(647, 75);
            lbSem.Margin = new Padding(3, 0, 3, 10);
            lbSem.Name = "lbSem";
            lbSem.Size = new Size(48, 15);
            lbSem.TabIndex = 17;
            lbSem.Text = "label13";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.DarkSeaGreen;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 5);
            flowLayoutPanel1.Controls.Add(dgvCourses);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(793, 312);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // dgvCourses
            // 
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(3, 3);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowTemplate.Height = 25;
            dgvCourses.Size = new Size(787, 309);
            dgvCourses.TabIndex = 1;
            // 
            // frmEvaluationResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(799, 451);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(815, 490);
            Name = "frmEvaluationResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEvaluationResult";
            Load += frmEvaluationResult_Load;
            SizeChanged += frmEvaluationResult_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label lbStudName;
        private Label label4;
        private Label lbStudNum;
        private Label label6;
        private Label lbProgram;
        private Label label8;
        private Label lbCv;
        private Label label10;
        private Label lbYear;
        private Label label12;
        private Label lbSem;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvCourses;
    }
}