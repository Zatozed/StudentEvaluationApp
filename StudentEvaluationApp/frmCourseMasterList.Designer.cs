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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nUnits = new NumericUpDown();
            tbCourseCode = new TextBox();
            tbSubDes = new TextBox();
            cbCurricuVer = new ComboBox();
            tbLvlTerm = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUnits).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(tbLvlTerm, 3, 1);
            tableLayoutPanel1.Controls.Add(tbSubDes, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 4, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(nUnits, 5, 0);
            tableLayoutPanel1.Controls.Add(tbCourseCode, 1, 0);
            tableLayoutPanel1.Controls.Add(cbCurricuVer, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Subject Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Units";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Curriculum Version";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 112);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "Level/Term";
            // 
            // nUnits
            // 
            nUnits.Location = new Point(668, 3);
            nUnits.Name = "nUnits";
            nUnits.Size = new Size(120, 23);
            nUnits.TabIndex = 5;
            // 
            // tbCourseCode
            // 
            tbCourseCode.Location = new Point(136, 3);
            tbCourseCode.Name = "tbCourseCode";
            tbCourseCode.Size = new Size(100, 23);
            tbCourseCode.TabIndex = 6;
            // 
            // tbSubDes
            // 
            tbSubDes.Location = new Point(402, 3);
            tbSubDes.Name = "tbSubDes";
            tbSubDes.Size = new Size(100, 23);
            tbSubDes.TabIndex = 7;
            // 
            // cbCurricuVer
            // 
            cbCurricuVer.FormattingEnabled = true;
            cbCurricuVer.Location = new Point(136, 115);
            cbCurricuVer.Name = "cbCurricuVer";
            cbCurricuVer.Size = new Size(121, 23);
            cbCurricuVer.TabIndex = 8;
            // 
            // tbLvlTerm
            // 
            tbLvlTerm.Location = new Point(402, 115);
            tbLvlTerm.Name = "tbLvlTerm";
            tbLvlTerm.Size = new Size(100, 23);
            tbLvlTerm.TabIndex = 9;
            // 
            // frmCourseMasterList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCourseMasterList";
            Text = "frmCourseMasterList";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUnits).EndInit();
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
    }
}