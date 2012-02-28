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
        DataTable histogram;
        public frmInputDirectPoint()
        {
            InitializeComponent();
        }

        private void nudGrayLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvInputX_SelectionChanged(object sender, EventArgs e)
        {
            nudR.Value = Convert.ToDecimal(dgvInputX.Rows[dgvInputX.CurrentCell.RowIndex].Cells[0].Value);
            //nudPixcelCount.Value = Convert.ToDecimal(dgvInputX.Rows[dgvInputX.CurrentCell.RowIndex].Cells[1].Value);
        }

        private void frmInputDirectPoint_Load(object sender, EventArgs e)
        {
            histogram = (DataTable)dgvInputX.DataSource;
            dgvInputX.DataSource = histogram;
            histogram.DefaultView.Sort = "Mức xám";
            for (int i = 2; i < dgvInputX.ColumnCount; ++i)
                dgvInputX.Columns[i].Visible = false;
            for (int i = 0; i < dgvInputX.ColumnCount; ++i)
            {
                dgvInputX.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
            }
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
                int i;
                for (i = 0; i < dgvInputX.RowCount; ++i)
                {
                    if (nudR.Value.ToString() == dgvInputX.Rows[i].Cells[0].Value.ToString())
                    {
                        //DialogResult rs = MessageBox.Show("Mức xám " + nudR.Value + " trùng với mức xám tại hàng " + i + " có số pixel là " + dgvInputX.Rows[i].Cells[1].Value.ToString() +
                            //"\nBạn có muốn cộng thêm " + nudPixcelCount.Value + " pixel vào mức xám này không?", "Xác nhận thêm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        /*if (rs == DialogResult.Yes)
                        {
                            dgvInputX.Rows[i].Cells[1].Value = Convert.ToInt16(dgvInputX.Rows[i].Cells[1].Value) + Convert.ToInt16(nudPixcelCount.Value);
                        }
                        else if (rs == DialogResult.No)
                        {
                            //dgvInputX.Rows[i].Cells[1].Value = Convert.ToInt16(nudPixcelCount.Value);
                        }
                        else return;*/
                        break;
                    }
                }
                if (i == dgvInputX.RowCount)
                {
                    DataRow dr = histogram.NewRow();
                    dr[0] = nudR.Value; ;
                    //dr[1] = nudPixcelCount.Value;
                    histogram.Rows.Add(dr);
                }
                dgvInputX_SelectionChanged(sender, e);
            }
        }
    }
}
