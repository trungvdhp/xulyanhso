namespace XuLyAnh
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.colAnhNguon = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.colAnhKetQua = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowHistogramX = new System.Windows.Forms.Button();
            this.btnShowInput = new System.Windows.Forms.Button();
            this.btnHistogramSpecification = new System.Windows.Forms.Button();
            this.btnLocSacNet = new System.Windows.Forms.Button();
            this.btnLocThongThap = new System.Windows.Forms.Button();
            this.btnLocTrungVi = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.btnCanBangHistogram = new System.Windows.Forms.Button();
            this.btnDanDoTuongPhan = new System.Windows.Forms.Button();
            this.btnDaySang = new System.Windows.Forms.Button();
            this.btnTaoAnhAmBan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLuuAnhNguon = new System.Windows.Forms.Button();
            this.btnLuuAnhKetQua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnGen);
            this.panel1.Controls.Add(this.nudHeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudWidth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpen.Location = new System.Drawing.Point(355, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(47, 20);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Mở...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGen
            // 
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGen.Location = new System.Drawing.Point(265, 8);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(84, 20);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Ngẫu nhiên";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(189, 8);
            this.nudHeight.Maximum = new decimal(new int[] {
            768,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(58, 22);
            this.nudHeight.TabIndex = 1;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudWidth_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cao:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(65, 8);
            this.nudWidth.Maximum = new decimal(new int[] {
            654,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(58, 22);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudWidth_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rộng:";
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.AllowUserToResizeColumns = false;
            this.dgvInput.AllowUserToResizeRows = false;
            this.dgvInput.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnhNguon});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInput.Location = new System.Drawing.Point(12, 54);
            this.dgvInput.Name = "dgvInput";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInput.RowHeadersWidth = 60;
            this.dgvInput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInput.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInput.RowTemplate.Height = 32;
            this.dgvInput.Size = new System.Drawing.Size(426, 579);
            this.dgvInput.TabIndex = 10;
            this.dgvInput.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellValueChanged);
            this.dgvInput.CurrentCellChanged += new System.EventHandler(this.dgvInput_CurrentCellChanged);
            this.dgvInput.DataSourceChanged += new System.EventHandler(this.dgvInput_DataSourceChanged);
            this.dgvInput.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvInput_ColumnAdded);
            // 
            // colAnhNguon
            // 
            this.colAnhNguon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAnhNguon.HeaderText = "Ảnh nguồn";
            this.colAnhNguon.Name = "colAnhNguon";
            this.colAnhNguon.Visible = false;
            this.colAnhNguon.Width = 364;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnhKetQua});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResult.Location = new System.Drawing.Point(565, 54);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResult.RowHeadersWidth = 60;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResult.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvResult.RowTemplate.Height = 32;
            this.dgvResult.Size = new System.Drawing.Size(426, 578);
            this.dgvResult.TabIndex = 14;
            this.dgvResult.CurrentCellChanged += new System.EventHandler(this.dgvResult_CurrentCellChanged);
            this.dgvResult.DataSourceChanged += new System.EventHandler(this.dgvResult_DataSourceChanged);
            this.dgvResult.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvResult_ColumnAdded);
            // 
            // colAnhKetQua
            // 
            this.colAnhKetQua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAnhKetQua.HeaderText = "Ảnh kết quả";
            this.colAnhKetQua.Name = "colAnhKetQua";
            this.colAnhKetQua.ReadOnly = true;
            this.colAnhKetQua.ToolTipText = "Ảnh kết quả";
            this.colAnhKetQua.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnShowHistogramX);
            this.panel2.Controls.Add(this.btnShowInput);
            this.panel2.Controls.Add(this.btnHistogramSpecification);
            this.panel2.Controls.Add(this.btnLocSacNet);
            this.panel2.Controls.Add(this.btnLocThongThap);
            this.panel2.Controls.Add(this.btnLocTrungVi);
            this.panel2.Controls.Add(this.btnShowResult);
            this.panel2.Controls.Add(this.btnCanBangHistogram);
            this.panel2.Controls.Add(this.btnDanDoTuongPhan);
            this.panel2.Controls.Add(this.btnDaySang);
            this.panel2.Controls.Add(this.btnTaoAnhAmBan);
            this.panel2.Location = new System.Drawing.Point(444, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 579);
            this.panel2.TabIndex = 2;
            // 
            // btnShowHistogramX
            // 
            this.btnShowHistogramX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowHistogramX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowHistogramX.Location = new System.Drawing.Point(4, 407);
            this.btnShowHistogramX.Name = "btnShowHistogramX";
            this.btnShowHistogramX.Size = new System.Drawing.Size(104, 35);
            this.btnShowHistogramX.TabIndex = 12;
            this.btnShowHistogramX.Text = "Xem Histogram X";
            this.btnShowHistogramX.UseVisualStyleBackColor = true;
            this.btnShowHistogramX.Click += new System.EventHandler(this.btnShowHistogramX_Click);
            // 
            // btnShowInput
            // 
            this.btnShowInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowInput.Location = new System.Drawing.Point(4, 326);
            this.btnShowInput.Name = "btnShowInput";
            this.btnShowInput.Size = new System.Drawing.Size(104, 35);
            this.btnShowInput.TabIndex = 10;
            this.btnShowInput.Text = "Xem Histogram nguồn";
            this.btnShowInput.UseVisualStyleBackColor = true;
            this.btnShowInput.Click += new System.EventHandler(this.btnShowInput_Click);
            // 
            // btnHistogramSpecification
            // 
            this.btnHistogramSpecification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHistogramSpecification.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHistogramSpecification.Location = new System.Drawing.Point(4, 162);
            this.btnHistogramSpecification.Name = "btnHistogramSpecification";
            this.btnHistogramSpecification.Size = new System.Drawing.Size(104, 35);
            this.btnHistogramSpecification.TabIndex = 6;
            this.btnHistogramSpecification.Text = "Xử lý Matching";
            this.btnHistogramSpecification.UseVisualStyleBackColor = true;
            this.btnHistogramSpecification.Click += new System.EventHandler(this.btnHistogramSpecification_Click);
            // 
            // btnLocSacNet
            // 
            this.btnLocSacNet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLocSacNet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLocSacNet.Location = new System.Drawing.Point(4, 285);
            this.btnLocSacNet.Name = "btnLocSacNet";
            this.btnLocSacNet.Size = new System.Drawing.Size(104, 35);
            this.btnLocSacNet.TabIndex = 9;
            this.btnLocSacNet.Text = "Lọc sắc nét";
            this.btnLocSacNet.UseVisualStyleBackColor = true;
            this.btnLocSacNet.Click += new System.EventHandler(this.btnLocSacNet_Click);
            // 
            // btnLocThongThap
            // 
            this.btnLocThongThap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLocThongThap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLocThongThap.Location = new System.Drawing.Point(4, 244);
            this.btnLocThongThap.Name = "btnLocThongThap";
            this.btnLocThongThap.Size = new System.Drawing.Size(104, 35);
            this.btnLocThongThap.TabIndex = 8;
            this.btnLocThongThap.Text = "Lọc thông thấp";
            this.btnLocThongThap.UseVisualStyleBackColor = true;
            this.btnLocThongThap.Click += new System.EventHandler(this.btnLocThongThap_Click);
            // 
            // btnLocTrungVi
            // 
            this.btnLocTrungVi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLocTrungVi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLocTrungVi.Location = new System.Drawing.Point(4, 203);
            this.btnLocTrungVi.Name = "btnLocTrungVi";
            this.btnLocTrungVi.Size = new System.Drawing.Size(104, 35);
            this.btnLocTrungVi.TabIndex = 7;
            this.btnLocTrungVi.Text = "Lọc trung vị";
            this.btnLocTrungVi.UseVisualStyleBackColor = true;
            this.btnLocTrungVi.Click += new System.EventHandler(this.btnLocTrungVi_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowResult.Location = new System.Drawing.Point(4, 366);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(104, 35);
            this.btnShowResult.TabIndex = 11;
            this.btnShowResult.Text = "Xem Histogram kết quả";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // btnCanBangHistogram
            // 
            this.btnCanBangHistogram.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCanBangHistogram.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCanBangHistogram.Location = new System.Drawing.Point(4, 121);
            this.btnCanBangHistogram.Name = "btnCanBangHistogram";
            this.btnCanBangHistogram.Size = new System.Drawing.Size(104, 35);
            this.btnCanBangHistogram.TabIndex = 5;
            this.btnCanBangHistogram.Text = "Cân bằng Histogram";
            this.btnCanBangHistogram.UseVisualStyleBackColor = true;
            this.btnCanBangHistogram.Click += new System.EventHandler(this.btnCanBangHistogram_Click);
            // 
            // btnDanDoTuongPhan
            // 
            this.btnDanDoTuongPhan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDanDoTuongPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanDoTuongPhan.Location = new System.Drawing.Point(4, 80);
            this.btnDanDoTuongPhan.Name = "btnDanDoTuongPhan";
            this.btnDanDoTuongPhan.Size = new System.Drawing.Size(104, 35);
            this.btnDanDoTuongPhan.TabIndex = 4;
            this.btnDanDoTuongPhan.Text = "Dãn độ tương phản";
            this.btnDanDoTuongPhan.UseVisualStyleBackColor = true;
            this.btnDanDoTuongPhan.Click += new System.EventHandler(this.btnDanDoTuongPhan_Click);
            // 
            // btnDaySang
            // 
            this.btnDaySang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDaySang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDaySang.Location = new System.Drawing.Point(4, 7);
            this.btnDaySang.Name = "btnDaySang";
            this.btnDaySang.Size = new System.Drawing.Size(104, 26);
            this.btnDaySang.TabIndex = 3;
            this.btnDaySang.Text = "<< Đẩy sang";
            this.btnDaySang.UseVisualStyleBackColor = true;
            this.btnDaySang.Click += new System.EventHandler(this.btnDaySang_Click);
            // 
            // btnTaoAnhAmBan
            // 
            this.btnTaoAnhAmBan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTaoAnhAmBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoAnhAmBan.Location = new System.Drawing.Point(4, 39);
            this.btnTaoAnhAmBan.Name = "btnTaoAnhAmBan";
            this.btnTaoAnhAmBan.Size = new System.Drawing.Size(104, 35);
            this.btnTaoAnhAmBan.TabIndex = 3;
            this.btnTaoAnhAmBan.Text = "Tạo ảnh âm bản";
            this.btnTaoAnhAmBan.UseVisualStyleBackColor = true;
            this.btnTaoAnhAmBan.Click += new System.EventHandler(this.btnTaoAnhAmBan_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblInput);
            this.panel3.Location = new System.Drawing.Point(565, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 39);
            this.panel3.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInput.ForeColor = System.Drawing.Color.Blue;
            this.lblInput.Location = new System.Drawing.Point(0, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(424, 37);
            this.lblInput.TabIndex = 0;
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStatus
            // 
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStatus.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStatus.Location = new System.Drawing.Point(41, 7);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(33, 20);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.TabStop = false;
            this.btnStatus.Text = "*";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Visible = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnStatus);
            this.panel4.Location = new System.Drawing.Point(444, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 39);
            this.panel4.TabIndex = 11;
            // 
            // btnLuuAnhNguon
            // 
            this.btnLuuAnhNguon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLuuAnhNguon.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLuuAnhNguon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuuAnhNguon.Location = new System.Drawing.Point(25, 57);
            this.btnLuuAnhNguon.Name = "btnLuuAnhNguon";
            this.btnLuuAnhNguon.Size = new System.Drawing.Size(35, 18);
            this.btnLuuAnhNguon.TabIndex = 2;
            this.btnLuuAnhNguon.Text = "Lưu";
            this.btnLuuAnhNguon.UseVisualStyleBackColor = true;
            this.btnLuuAnhNguon.Click += new System.EventHandler(this.btnLuuAnhNguon_Click);
            // 
            // btnLuuAnhKetQua
            // 
            this.btnLuuAnhKetQua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLuuAnhKetQua.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLuuAnhKetQua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuuAnhKetQua.Location = new System.Drawing.Point(578, 57);
            this.btnLuuAnhKetQua.Name = "btnLuuAnhKetQua";
            this.btnLuuAnhKetQua.Size = new System.Drawing.Size(35, 18);
            this.btnLuuAnhKetQua.TabIndex = 13;
            this.btnLuuAnhKetQua.Text = "Lưu";
            this.btnLuuAnhKetQua.UseVisualStyleBackColor = true;
            this.btnLuuAnhKetQua.Click += new System.EventHandler(this.btnLuuAnhKetQua_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(999, 643);
            this.Controls.Add(this.btnLuuAnhKetQua);
            this.Controls.Add(this.btnLuuAnhNguon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XỬ LÝ ẢNH";
            this.Load += new System.EventHandler(this.frnMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnLocTrungVi;
        private System.Windows.Forms.Button btnCanBangHistogram;
        private System.Windows.Forms.Button btnDanDoTuongPhan;
        private System.Windows.Forms.Button btnTaoAnhAmBan;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowHistogramX;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button btnShowInput;
        private System.Windows.Forms.Button btnHistogramSpecification;
        private System.Windows.Forms.Button btnLocSacNet;
        private System.Windows.Forms.Button btnLocThongThap;
        private System.Windows.Forms.DataGridViewImageColumn colAnhNguon;
        private System.Windows.Forms.DataGridViewImageColumn colAnhKetQua;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnLuuAnhNguon;
        private System.Windows.Forms.Button btnLuuAnhKetQua;
        private System.Windows.Forms.Button btnDaySang;
    }
}

