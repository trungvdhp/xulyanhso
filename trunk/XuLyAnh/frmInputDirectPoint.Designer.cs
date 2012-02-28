namespace XuLyAnh
{
    partial class frmInputDirectPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudS = new System.Windows.Forms.NumericUpDown();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInputX = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudMin);
            this.panel1.Controls.Add(this.nudMax);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudS);
            this.panel1.Controls.Add(this.nudR);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 119);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cận dưới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cận trên:";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(86, 12);
            this.nudMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(59, 22);
            this.nudMin.TabIndex = 12;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(248, 12);
            this.nudMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(59, 22);
            this.nudMax.TabIndex = 12;
            this.nudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đáp ứng S:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đầu vào R:";
            // 
            // nudS
            // 
            this.nudS.Location = new System.Drawing.Point(248, 42);
            this.nudS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudS.Name = "nudS";
            this.nudS.Size = new System.Drawing.Size(59, 22);
            this.nudS.TabIndex = 3;
            this.nudS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGrayLevel_KeyDown);
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(85, 42);
            this.nudR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(60, 22);
            this.nudR.TabIndex = 2;
            this.nudR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudR.ValueChanged += new System.EventHandler(this.nudGrayLevel_ValueChanged);
            this.nudR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGrayLevel_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(194, 79);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 22);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThem.Location = new System.Drawing.Point(62, 79);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 22);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(128, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvInputX
            // 
            this.dgvInputX.AllowUserToAddRows = false;
            this.dgvInputX.AllowUserToResizeColumns = false;
            this.dgvInputX.AllowUserToResizeRows = false;
            this.dgvInputX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInputX.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInputX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInputX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInputX.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInputX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputX.Location = new System.Drawing.Point(0, 119);
            this.dgvInputX.Name = "dgvInputX";
            this.dgvInputX.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInputX.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInputX.RowHeadersWidth = 50;
            this.dgvInputX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInputX.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInputX.RowTemplate.Height = 32;
            this.dgvInputX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInputX.Size = new System.Drawing.Size(323, 253);
            this.dgvInputX.TabIndex = 7;
            this.dgvInputX.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvInputX_UserDeletingRow);
            this.dgvInputX.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvInputX_RowsAdded);
            this.dgvInputX.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvInputX_RowsRemoved);
            this.dgvInputX.SelectionChanged += new System.EventHandler(this.dgvInputX_SelectionChanged);
            // 
            // frmInputDirectPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(323, 372);
            this.Controls.Add(this.dgvInputX);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputDirectPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHẬP ĐIỂM ĐIỀU KHIỂN";
            this.Load += new System.EventHandler(this.frmInputDirectPoint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvInputX;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.NumericUpDown nudS;
    }
}