using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmInputDirectPoint : Form
    {
        DataTable dtDirectPoint;
        public frmInputDirectPoint()
        {
            InitializeComponent();
        }

        public frmInputDirectPoint(int[,] d)
        {
            InitializeComponent();
            dtDirectPoint = new DataTable();
            dtDirectPoint.Columns.Add("R");
            dtDirectPoint.Columns["R"].DataType = Type.GetType("System.Byte");
            dtDirectPoint.Columns.Add("S");
            int n = d.GetLength(0);
            for (int i = 0; i < n; ++i)
            {
                DataRow dr = dtDirectPoint.NewRow();
                dr[0] = d[i, 0];
                dr[1] = d[i, 1];
                dtDirectPoint.Rows.Add(dr);
            }
            dtDirectPoint.DefaultView.Sort = "R";
        }

        private void dgvInput_SelectionChanged(object sender, EventArgs e)
        {
            nudR.Value = Convert.ToDecimal(dgvInput.Rows[dgvInput.CurrentCell.RowIndex].Cells[0].Value);
            nudS.Value = Convert.ToDecimal(dgvInput.Rows[dgvInput.CurrentCell.RowIndex].Cells[1].Value);
            nudR.Select(0, 3);
        }

        private void frmInputDirectPoint_Load(object sender, EventArgs e)
        {
            dgvInput.DataSource = dtDirectPoint;
            dgvInput.Columns[0].SortMode = dgvInput.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            dtDirectPoint.DefaultView.Sort = "R";
            for (int i = 1; i <= dgvInput.RowCount; ++i)
                dgvInput.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void dgvInput_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvInput.RowCount == 2)
            {
                e.Cancel = true;
            }
        }

        private void dgvInput_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 1; i <= dgvInput.RowCount; ++i)
                dgvInput.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void dgvInput_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 1; i <= dgvInput.RowCount; ++i)
                dgvInput.Rows[i - 1].HeaderCell.Value = i.ToString();
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
            for (i = 0; i < dgvInput.RowCount; ++i)
            {
                if (nudR.Value.ToString() == dgvInput.Rows[i].Cells[0].Value.ToString())
                {
                    DialogResult rs = MessageBox.Show("Đầu vào " + nudR.Value + " trùng với đầu vào R tại hàng " + i + " có đáp ứng S là " + dgvInput.Rows[i].Cells[1].Value.ToString() +
                        "\nBạn có muốn cộng thêm " + nudS.Value + " pixel  vào đáp ứng S này không?", "Xác nhận thêm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        k = Convert.ToInt32(dgvInput.Rows[i].Cells[1].Value) + Convert.ToInt32(nudS.Value);
                        if (k > (int)nudS.Maximum) k = (int)nudS.Maximum;
                        dgvInput.Rows[i].Cells[1].Value = k;
                    }
                    else if (rs == DialogResult.No)
                    {
                        dgvInput.Rows[i].Cells[1].Value = Convert.ToInt32(nudS.Value);
                    }
                    else return;
                    break;
                }
            }
            if (i == dgvInput.RowCount)
            {
                DataRow dr = dtDirectPoint.NewRow();
                dr[0] = nudR.Value;
                dr[1] = nudS.Value;
                dtDirectPoint.Rows.Add(dr);
            }
            dgvInput_SelectionChanged(sender, e);
        }

        private void nudR_MouseClick(object sender, MouseEventArgs e)
        {
            nudR.Select(0, 3);
        }

        private void nudS_MouseClick(object sender, MouseEventArgs e)
        {
            nudS.Select(0, 3);
        }

        public int[,] GetOutput()
        {
            int n = dgvInput.Rows.Count;
            int[,] d = new int[n,2];
            for(int i=0; i<n; ++i)
            {
                d[i, 0] = Convert.ToInt16(dgvInput.Rows[i].Cells[0].Value);
                d[i, 1] = Convert.ToInt16(dgvInput.Rows[i].Cells[1].Value);
            }
            return d;
        }
    }
}
