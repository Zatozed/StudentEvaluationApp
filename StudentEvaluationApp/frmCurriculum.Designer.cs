namespace StudentEvaluationApp
{
    partial class frmCurriculum
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
            tbCurricuVer = new TextBox();
            label1 = new Label();
            bSave = new Button();
            dgvCurricuVer = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colCurricuDes = new DataGridViewTextBoxColumn();
            colManage = new DataGridViewImageColumn();
            colEdit = new DataGridViewImageColumn();
            colDel = new DataGridViewImageColumn();
            lbGotID = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurricuVer).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(tbCurricuVer, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(bSave, 2, 1);
            tableLayoutPanel1.Controls.Add(dgvCurricuVer, 0, 3);
            tableLayoutPanel1.Controls.Add(lbGotID, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tbCurricuVer
            // 
            tbCurricuVer.Dock = DockStyle.Fill;
            tbCurricuVer.Location = new Point(3, 18);
            tbCurricuVer.Name = "tbCurricuVer";
            tbCurricuVer.Size = new Size(260, 23);
            tbCurricuVer.TabIndex = 0;
            tbCurricuVer.TextChanged += tbCurricuVer_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Curriculum Version";
            // 
            // bSave
            // 
            bSave.AutoSize = true;
            bSave.BackColor = Color.ForestGreen;
            bSave.FlatStyle = FlatStyle.Flat;
            bSave.ForeColor = Color.White;
            bSave.Location = new Point(535, 18);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 27);
            bSave.TabIndex = 2;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = false;
            bSave.Click += button1_Click;
            // 
            // dgvCurricuVer
            // 
            dgvCurricuVer.AllowUserToAddRows = false;
            dgvCurricuVer.AllowUserToDeleteRows = false;
            dgvCurricuVer.AllowUserToOrderColumns = true;
            dgvCurricuVer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurricuVer.BackgroundColor = Color.White;
            dgvCurricuVer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurricuVer.Columns.AddRange(new DataGridViewColumn[] { colID, colCurricuDes, colManage, colEdit, colDel });
            tableLayoutPanel1.SetColumnSpan(dgvCurricuVer, 3);
            dgvCurricuVer.Dock = DockStyle.Fill;
            dgvCurricuVer.Location = new Point(3, 82);
            dgvCurricuVer.Name = "dgvCurricuVer";
            dgvCurricuVer.ReadOnly = true;
            dgvCurricuVer.RowTemplate.Height = 25;
            dgvCurricuVer.Size = new Size(794, 365);
            dgvCurricuVer.TabIndex = 3;
            dgvCurricuVer.CellContentClick += dgvCurricuVer_CellContentClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "curricuVerID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colCurricuDes
            // 
            colCurricuDes.DataPropertyName = "curricuDescription";
            colCurricuDes.HeaderText = "Curriculum Version";
            colCurricuDes.Name = "colCurricuDes";
            colCurricuDes.ReadOnly = true;
            // 
            // colManage
            // 
            colManage.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colManage.HeaderText = "";
            colManage.Image = R_icons1.icons8_configure_64;
            colManage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colManage.Name = "colManage";
            colManage.ReadOnly = true;
            colManage.Width = 5;
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
            colDel.Width = 5;
            // 
            // lbGotID
            // 
            lbGotID.AutoSize = true;
            lbGotID.Location = new Point(535, 0);
            lbGotID.Name = "lbGotID";
            lbGotID.Size = new Size(47, 15);
            lbGotID.TabIndex = 4;
            lbGotID.Text = "hidden ";
            // 
            // button1
            // 
            button1.BackgroundImage = R_icons1.icons8_search_50;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(269, 51);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 6;
            // 
            // frmCurriculum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCurriculum";
            SizeGripStyle = SizeGripStyle.Hide;
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurricuVer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbCurricuVer;
        private Label label1;
        private Button bSave;
        private DataGridView dgvCurricuVer;
        private Label lbGotID;
        private Button button1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colCurricuDes;
        private DataGridViewImageColumn colManage;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDel;
    }
}