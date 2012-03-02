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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPixcelCount = new System.Windows.Forms.NumericUpDown();
            this.nudGrayLevel = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInputX = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPixcelCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrayLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputX)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudPixcelCount);
            this.panel1.Controls.Add(this.nudGrayLevel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 103);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số pixel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mức xám:";
            // 
            // nudPixcelCount
            // 
            this.nudPixcelCount.Location = new System.Drawing.Point(92, 42);
            this.nudPixcelCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPixcelCount.Maximum = new decimal(new int[] {
            65535,
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
            this.nudPixcelCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudPixcelCount_MouseClick);
            this.nudPixcelCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGrayLevel_KeyDown);
            // 
            // nudGrayLevel
            // 
            this.nudGrayLevel.Location = new System.Drawing.Point(92, 15);
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
            this.nudGrayLevel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudGrayLevel_MouseClick);
            this.nudGrayLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudGrayLevel_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(92, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 22);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(93, 12);
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
            this.btnSave.Location = new System.Drawing.Point(23, 12);
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
            this.dgvInputX.Location = new System.Drawing.Point(0, 102);
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
            this.dgvInputX.Size = new System.Drawing.Size(173, 249);
            this.dgvInputX.TabIndex = 9;
            this.dgvInputX.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvInputX_UserDeletingRow);
            this.dgvInputX.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvInputX_RowsAdded);
            this.dgvInputX.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvInputX_RowsRemoved);
            this.dgvInputX.SelectionChanged += new System.EventHandler(this.dgvInputX_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 43);
            this.panel2.TabIndex = 10;
            // 
            // frmInputHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(173, 395);
            this.Controls.Add(this.dgvInputX);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
    }
}