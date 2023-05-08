namespace StudentEvaluationApp
{
    partial class frmStudentReg
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
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label10 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(maskedTextBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 3, 1);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 5, 1);
            tableLayoutPanel1.Controls.Add(label5, 6, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 7, 1);
            tableLayoutPanel1.Controls.Add(label6, 8, 1);
            tableLayoutPanel1.Controls.Add(comboBox2, 9, 1);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 3);
            tableLayoutPanel1.Controls.Add(label7, 3, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 4, 2);
            tableLayoutPanel1.Controls.Add(textBox5, 8, 2);
            tableLayoutPanel1.Controls.Add(label8, 7, 2);
            tableLayoutPanel1.Controls.Add(label10, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox7, 4, 3);
            tableLayoutPanel1.Controls.Add(label12, 5, 3);
            tableLayoutPanel1.Controls.Add(textBox8, 6, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(7, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(83, 3);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(74, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 29);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 29);
            label4.Name = "label4";
            label4.Size = new Size(44, 30);
            label4.TabIndex = 6;
            label4.Text = "Middle Name";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(483, 29);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 8;
            label5.Text = "Suffix";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jr.", "Sr." });
            comboBox1.Location = new Point(563, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 23);
            comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(643, 29);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(723, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(74, 23);
            comboBox2.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 113);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 20;
            label11.Text = "BirthDate";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            tableLayoutPanel1.SetColumnSpan(dateTimePicker1, 2);
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(83, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 197);
            label9.Name = "label9";
            label9.Size = new Size(71, 30);
            label9.TabIndex = 16;
            label9.Text = "Parent/Guardian Name";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox6
            // 
            tableLayoutPanel1.SetColumnSpan(textBox6, 2);
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(83, 200);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(154, 23);
            textBox6.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 113);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 12;
            label7.Text = "Address";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox4
            // 
            tableLayoutPanel1.SetColumnSpan(textBox4, 3);
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(323, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            tableLayoutPanel1.SetColumnSpan(textBox5, 2);
            textBox5.Location = new Point(643, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(74, 23);
            textBox5.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(563, 113);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 14;
            label8.Text = "Contact #";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(243, 197);
            label10.Name = "label10";
            label10.Size = new Size(71, 45);
            label10.TabIndex = 18;
            label10.Text = "Parent/Guardian Contact No.";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(323, 200);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(74, 23);
            textBox7.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(403, 197);
            label12.Name = "label12";
            label12.Size = new Size(67, 30);
            label12.TabIndex = 22;
            label12.Text = "Last School Attended";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox8
            // 
            tableLayoutPanel1.SetColumnSpan(textBox8, 3);
            textBox8.Dock = DockStyle.Fill;
            textBox8.Location = new Point(483, 200);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(234, 23);
            textBox8.TabIndex = 23;
            // 
            // frmStudentReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmStudentReg";
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private TextBox textBox8;
    }
}