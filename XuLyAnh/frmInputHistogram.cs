using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmInputHistogram : Form
    {
        DataTable dtHistogram = new DataTable();
        public frmInputHistogram()
        {
            InitializeComponent();
        }

        public frmInputHistogram(DataTable h)
        {
            InitializeComponent();
            dtHistogram = h;
            dtHistogram.DefaultView.Sort = "Mức xám";
        }

        private void dgvInputX_SelectionChanged(object sender, EventArgs e)
        {
            nudGrayLevel.Value = Convert.ToDecimal(dgvInputX.Rows[dgvInputX.CurrentCell.RowIndex].Cells[0].Value);
            nudPixcelCount.Value = Convert.ToDecimal(dgvInputX.Rows[dgvInputX.CurrentCell.RowIndex].Cells[1].Value);
            nudGrayLevel.Select(0, 3);
        }

        private void frmInputHistogram_Load(object sender, EventArgs e)
        {
            dgvInputX.DataSource = dtHistogram;
            for (int i = 2; i < dgvInputX.ColumnCount; ++i)
                dgvInputX.Columns[i].Visible = false;
            dgvInputX.Columns[0].SortMode = dgvInputX.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            for (int i = 1; i <= dgvInputX.RowCount; ++i)
                dgvInputX.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void dgvInputX_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvInputX.RowCount == 1)
            {
                e.Cancel = true;
            }
        }

        private void dgvInputX_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 1; i <= dgvInputX.RowCount; ++i)
                dgvInputX.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void dgvInputX_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 1; i <= dgvInputX.RowCount; ++i)
                dgvInputX.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void nudGrayLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i, k;
            for (i = 0; i < dgvInputX.RowCount; ++i)
            {
                if (nudGrayLevel.Value.ToString() == dgvInputX.Rows[i].Cells[0].Value.ToString())
                {
                    DialogResult rs = MessageBox.Show("Mức xám " + nudGrayLevel.Value + " trùng với mức xám tại hàng " + i + " có số pixel là " + dgvInputX.Rows[i].Cells[1].Value.ToString() +
                        "\nBạn có muốn cộng thêm " + nudPixcelCount.Value + " pixel vào mức xám này không?", "Xác nhận thêm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        k = Convert.ToInt32(dgvInputX.Rows[i].Cells[1].Value) + Convert.ToInt32(nudPixcelCount.Value);
                        if (k > (int)nudPixcelCount.Maximum) k = (int)nudPixcelCount.Maximum;
                        if (k == 0) k = 1;
                        dgvInputX.Rows[i].Cells[1].Value = k;
                    }
                    else if (rs == DialogResult.No)
                    {
                        dgvInputX.Rows[i].Cells[1].Value = Convert.ToInt32(nudPixcelCount.Value);
                    }
                    else return;
                    break;
                }
            }
            if (i == dgvInputX.RowCount)
            {
                DataRow dr = dtHistogram.NewRow();
                dr[0] = nudGrayLevel.Value;
                dr[1] = nudPixcelCount.Value;
                dtHistogram.Rows.Add(dr);
            }
            dgvInputX_SelectionChanged(sender, e);
        }

        private void nudGrayLevel_MouseClick(object sender, MouseEventArgs e)
        {
            nudGrayLevel.Select(0, 3);
        }

        private void nudPixcelCount_MouseClick(object sender, MouseEventArgs e)
        {
            nudPixcelCount.Select(0, 5);
        }
    }
}
