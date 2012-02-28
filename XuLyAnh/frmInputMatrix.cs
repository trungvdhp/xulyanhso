using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XuLyAnh
{
    public partial class frmInputMatrix : Form
    {
        DataTable matrix;
        bool flag;
        public frmInputMatrix()
        {
            InitializeComponent();
            flag = false;
        }

        public frmInputMatrix(bool f)
        {
            InitializeComponent();
            flag = f;
        }

        public void init()
        {
            matrix = new DataTable();
            int height = Convert.ToInt16(nudHeight.Value);
            int width = Convert.ToInt16(nudWidth.Value);

            for (int i = 1; i <= width; ++i)
            {
                matrix.Columns.Add("" + i);
                matrix.Columns[i-1].DefaultValue = 1;
                matrix.Columns[i - 1].DataType = Type.GetType("System.Int16");
            }

            for (int i = 0; i < height; ++i)
            {
                matrix.Rows.Add();
            }

            dgvInput.DataSource = matrix;
        }
        private void frmInputMatrix_Load(object sender, EventArgs e)
        {
            matrix = (DataTable)dgvInput.DataSource;
            dgvInput.DataSource = matrix;
            if (dgvInput.Rows.Count == 0)
            {
                init();
            }
        }

        private void dgvInput_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInput.ColumnCount; ++i)
            {
                dgvInput.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 1; i <= dgvInput.RowCount; ++i)
                dgvInput.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void nudWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int height = Convert.ToInt16(nudHeight.Value);
                int width = Convert.ToInt16(nudWidth.Value);

                if ((height & 1)==0)
                {
                    MessageBox.Show("Số hàng phải lẻ");
                    nudHeight.Focus();
                    return;
                }

                if ((width & 1)==0)
                {
                    MessageBox.Show("Số cột phải lẻ");
                    nudWidth.Focus();
                    return;
                }

                init();
                dgvInput.Focus();
            }
        }

        private void dgvInput_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                if (matrix.Rows[matrix.Rows.Count / 2][matrix.Columns.Count / 2].ToString()== "0")
                {
                    MessageBox.Show("Tâm phải khác 0");
                    dgvInput.Focus();
                    dgvInput.Rows[matrix.Rows.Count / 2].Cells[matrix.Columns.Count / 2].Selected = true;
                    return;
                }
                int sum = 0;
                for(int i = 0; i < matrix.Columns.Count; ++i)
                {
                    for (int j = 0; j < matrix.Rows.Count; ++j)
                    {
                        sum += Convert.ToInt16(matrix.Rows[i][j]);
                    }
                }
                if (sum != 0)
                {
                    MessageBox.Show("Tổng các hệ số phải bằng 0");
                    dgvInput.Focus();
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
