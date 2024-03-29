﻿namespace StudentEvaluationApp
{
    partial class frmEvaluateOptions
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
            btnEvNewStud = new Button();
            label1 = new Label();
            btnEvExStudent = new Button();
            btnEvTransfeeStud = new Button();
            SuspendLayout();
            // 
            // btnEvNewStud
            // 
            btnEvNewStud.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEvNewStud.BackColor = Color.ForestGreen;
            btnEvNewStud.FlatStyle = FlatStyle.Flat;
            btnEvNewStud.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvNewStud.ForeColor = Color.White;
            btnEvNewStud.Location = new Point(289, 140);
            btnEvNewStud.Name = "btnEvNewStud";
            btnEvNewStud.Size = new Size(254, 50);
            btnEvNewStud.TabIndex = 0;
            btnEvNewStud.Text = "New Student";
            btnEvNewStud.UseVisualStyleBackColor = false;
            btnEvNewStud.Click += btnEvNewStud_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(324, 49);
            label1.Name = "label1";
            label1.Size = new Size(184, 48);
            label1.TabIndex = 3;
            label1.Text = "Evaluate";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEvExStudent
            // 
            btnEvExStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEvExStudent.BackColor = Color.SteelBlue;
            btnEvExStudent.FlatStyle = FlatStyle.Flat;
            btnEvExStudent.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvExStudent.ForeColor = Color.White;
            btnEvExStudent.Location = new Point(289, 196);
            btnEvExStudent.Name = "btnEvExStudent";
            btnEvExStudent.Size = new Size(254, 50);
            btnEvExStudent.TabIndex = 4;
            btnEvExStudent.Text = "Existing Student";
            btnEvExStudent.UseVisualStyleBackColor = false;
            // 
            // btnEvTransfeeStud
            // 
            btnEvTransfeeStud.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEvTransfeeStud.BackColor = Color.DarkOrange;
            btnEvTransfeeStud.FlatStyle = FlatStyle.Flat;
            btnEvTransfeeStud.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvTransfeeStud.ForeColor = Color.White;
            btnEvTransfeeStud.Location = new Point(289, 252);
            btnEvTransfeeStud.Name = "btnEvTransfeeStud";
            btnEvTransfeeStud.Size = new Size(254, 50);
            btnEvTransfeeStud.TabIndex = 5;
            btnEvTransfeeStud.Text = "Transferee Student";
            btnEvTransfeeStud.UseVisualStyleBackColor = false;
            // 
            // frmEvaluateOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(830, 460);
            ControlBox = false;
            Controls.Add(btnEvTransfeeStud);
            Controls.Add(btnEvExStudent);
            Controls.Add(label1);
            Controls.Add(btnEvNewStud);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(830, 460);
            Name = "frmEvaluateOptions";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "frmEvaluateOptions";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEvNewStud;
        private Label label1;
        private Button btnEvExStudent;
        private Button btnEvTransfeeStud;
    }
}