using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmInputContrast : Form
    {
        public frmInputContrast()
        {
            InitializeComponent();
        }

        private void nudS1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnOk.PerformClick();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (nudR1.Value != nudR2.Value)
                this.DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Vui lòng nhập R1 khác R2!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
