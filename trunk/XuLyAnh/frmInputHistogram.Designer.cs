namespace XuLyAnh
{
    partial class frmInputHistogram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPixcelCount = new System.Windows.Forms.NumericUpDown();
            this.nudGrayLevel = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInputX = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixcelCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrayLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudPixcelCount);
            this.panel1.Controls.Add(this.nudGrayLevel);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 134);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhập mức xám và số pixel\r\nNhấn Enter để thêm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số pixel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mức xám:";
            // 
            // nudPixcelCount
            // 
            this.nudPixcelCount.Location = new System.Drawing.Point(92, 70);
            this.nudPixcelCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPixcelCount.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.nudPixcelCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPixcelCount.Name = "nudPixcelCount";
            this.nudPixcelCount.Size = new System.Drawing.Size(60, 22);
            this.nudPixcelCount.TabIndex = 5;
            this.nudPixcelCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPixcelCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPixcelCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGrayLevel_KeyDown);
            // 
            // nudGrayLevel
            // 
            this.nudGrayLevel.Location = new System.Drawing.Point(92, 43);
            this.nudGrayLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudGrayLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGrayLevel.Name = "nudGrayLevel";
            this.nudGrayLevel.Size = new System.Drawing.Size(60, 22);
            this.nudGrayLevel.TabIndex = 4;
            this.nudGrayLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGrayLevel.ValueChanged += new System.EventHandler(this.nudGrayLevel_ValueChanged);
            this.nudGrayLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGrayLevel_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(92, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 22);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(22, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.TabIndex = 8;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInputX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInputX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInputX.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInputX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputX.Location = new System.Drawing.Point(0, 134);
            this.dgvInputX.Name = "dgvInputX";
            this.dgvInputX.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInputX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInputX.RowHeadersWidth = 50;
            this.dgvInputX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInputX.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInputX.RowTemplate.Height = 32;
            this.dgvInputX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInputX.Size = new System.Drawing.Size(173, 375);
            this.dgvInputX.TabIndex = 9;
            this.dgvInputX.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvInputX_UserDeletingRow);
            this.dgvInputX.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvInputX_RowsAdded);
            this.dgvInputX.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvInputX_RowsRemoved);
            this.dgvInputX.SelectionChanged += new System.EventHandler(this.dgvInputX_SelectionChanged);
            // 
            // frmInputHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(173, 509);
            this.Controls.Add(this.dgvInputX);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputHistogram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHẬP HISTOGRAM X";
            this.Load += new System.EventHandler(this.frmInputHistogram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixcelCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrayLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudGrayLevel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nudPixcelCount;
        public System.Windows.Forms.DataGridView dgvInputX;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}