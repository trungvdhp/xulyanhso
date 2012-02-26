using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmInputMask : Form
    {
        public frmInputMask()
        {
            InitializeComponent();
        }

        private void frmInputMask_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            checkOdd();
        }

        private void checkOdd()
        {
            int height = Convert.ToInt16(nudHeight.Value);
            int width = Convert.ToInt16(nudWidth.Value);

            if ((height & 1) == 0)
            {
                MessageBox.Show("Số hàng phải lẻ");
                nudHeight.Focus();
                return;
            }

            if ((width & 1) == 0)
            {
                MessageBox.Show("Số cột phải lẻ");
                nudWidth.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void nudN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkOdd();
            }
        }
    }
}
