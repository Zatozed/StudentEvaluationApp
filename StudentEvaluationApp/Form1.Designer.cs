namespace StudentEvaluationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            eToolStripMenuItem = new ToolStripMenuItem();
            fileMaintenanceToolStripMenuItem = new ToolStripMenuItem();
            curriculumVersionsToolStripMenuItem = new ToolStripMenuItem();
            programMasterListToolStripMenuItem = new ToolStripMenuItem();
            courseMasterListToolStripMenuItem = new ToolStripMenuItem();
            utilityToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip2 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            statusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 2);
            tableLayoutPanel1.Controls.Add(statusStrip2, 1, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.44444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(menuStrip1, 2);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eToolStripMenuItem, fileMaintenanceToolStripMenuItem, utilityToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(93, 24);
            eToolStripMenuItem.Text = "Evaluation";
            // 
            // fileMaintenanceToolStripMenuItem
            // 
            fileMaintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { curriculumVersionsToolStripMenuItem, programMasterListToolStripMenuItem, courseMasterListToolStripMenuItem });
            fileMaintenanceToolStripMenuItem.Name = "fileMaintenanceToolStripMenuItem";
            fileMaintenanceToolStripMenuItem.Size = new Size(138, 24);
            fileMaintenanceToolStripMenuItem.Text = "File Maintenance";
            // 
            // curriculumVersionsToolStripMenuItem
            // 
            curriculumVersionsToolStripMenuItem.Name = "curriculumVersionsToolStripMenuItem";
            curriculumVersionsToolStripMenuItem.Size = new Size(215, 24);
            curriculumVersionsToolStripMenuItem.Text = "Curriculum Versions";
            curriculumVersionsToolStripMenuItem.Click += curriculumVersionsToolStripMenuItem_Click;
            // 
            // programMasterListToolStripMenuItem
            // 
            programMasterListToolStripMenuItem.Name = "programMasterListToolStripMenuItem";
            programMasterListToolStripMenuItem.Size = new Size(215, 24);
            programMasterListToolStripMenuItem.Text = "Program Master List";
            programMasterListToolStripMenuItem.Click += programMasterListToolStripMenuItem_Click;
            // 
            // courseMasterListToolStripMenuItem
            // 
            courseMasterListToolStripMenuItem.Name = "courseMasterListToolStripMenuItem";
            courseMasterListToolStripMenuItem.Size = new Size(215, 24);
            courseMasterListToolStripMenuItem.Text = "Course Master List";
            // 
            // utilityToolStripMenuItem
            // 
            utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            utilityToolStripMenuItem.Size = new Size(72, 24);
            utilityToolStripMenuItem.Text = "Utilities";
            utilityToolStripMenuItem.Click += utilityToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(135, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip2
            // 
            statusStrip2.Dock = DockStyle.None;
            statusStrip2.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2 });
            statusStrip2.Location = new Point(400, 426);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(166, 22);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 392);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Panel panel1;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem fileMaintenanceToolStripMenuItem;
        private ToolStripMenuItem utilityToolStripMenuItem;
        private ToolStripMenuItem programMasterListToolStripMenuItem;
        private ToolStripMenuItem courseMasterListToolStripMenuItem;
        private ToolStripMenuItem curriculumVersionsToolStripMenuItem;
    }
}