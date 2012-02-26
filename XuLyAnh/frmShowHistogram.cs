using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmShowHistogram : Form
    {
        public frmShowHistogram()
        {
            InitializeComponent();
        }

        private void frmShowHistogram_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= dgvHistogram.RowCount; ++i)
                dgvHistogram.Rows[i - 1].HeaderCell.Value = i.ToString();
        }
    }
}
