namespace XuLyAnh
{
    partial class frmInputContrast
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudS1 = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudS2 = new System.Windows.Forms.NumericUpDown();
            this.nudR1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudR2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudS1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "S2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "S1:";
            // 
            // nudS1
            // 
            this.nudS1.Location = new System.Drawing.Point(53, 12);
            this.nudS1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudS1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudS1.Name = "nudS1";
            this.nudS1.Size = new System.Drawing.Size(90, 22);
            this.nudS1.TabIndex = 0;
            this.nudS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudS1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudS1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudS1_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(237, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Location = new System.Drawing.Point(167, 6);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(64, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 40);
            this.panel1.TabIndex = 6;
            // 
            // nudS2
            // 
            this.nudS2.Location = new System.Drawing.Point(53, 41);
            this.nudS2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudS2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudS2.Name = "nudS2";
            this.nudS2.Size = new System.Drawing.Size(90, 22);
            this.nudS2.TabIndex = 2;
            this.nudS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudS2.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.nudS2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudS1_KeyDown);
            // 
            // nudR1
            // 
            this.nudR1.Location = new System.Drawing.Point(212, 12);
            this.nudR1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudR1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR1.Name = "nudR1";
            this.nudR1.Size = new System.Drawing.Size(90, 22);
            this.nudR1.TabIndex = 1;
            this.nudR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudR1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudR1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudS1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "R1:";
            // 
            // nudR2
            // 
            this.nudR2.Location = new System.Drawing.Point(212, 41);
            this.nudR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudR2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR2.Name = "nudR2";
            this.nudR2.Size = new System.Drawing.Size(90, 22);
            this.nudR2.TabIndex = 3;
            this.nudR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudR2.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.nudR2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudS1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "R2:";
            // 
            // frmInputContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(325, 110);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudR1);
            this.Controls.Add(this.nudR2);
            this.Controls.Add(this.nudS2);
            this.Controls.Add(this.nudS1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputContrast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHẬP HAI ĐIỂM ĐIỀU KHIỂN";
            ((System.ComponentModel.ISupportInitialize)(this.nudS1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudS1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown nudS2;
        public System.Windows.Forms.NumericUpDown nudR1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown nudR2;
        private System.Windows.Forms.Label label4;
    }
}