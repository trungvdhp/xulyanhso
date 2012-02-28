using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace XuLyAnh
{
    public partial class frmMain : Form
    {
        DataSet dsInput = new DataSet();
        DataSet dsResult = new DataSet();
        DataTable histogramX = new DataTable();
        DataTable filter = new DataTable();

        Bitmap bmpInput;
        Bitmap bmpResult;
        ImageProc imgInput = new ImageProc();
        ImageProc imgResult = new ImageProc();
        ImageProc imgHistogramX = new ImageProc();
        ImageProc imgFilter = new ImageProc();

        int height=3, width=3;
        int s1=80, r1=80, s2=125, r2=125;
        int grayLevel = 256;
        bool modified = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frnMain_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowInput()
        {
            if (dsInput.Tables.Count > 0)
            {
                if (modified == true)
                {
                    imgInput = new ImageProc((DataTable)dgvInput.DataSource);
                    dsInput = imgInput.ToDataSet();
                    bmpInput = imgInput.ToBitmap();
                }
                if (btnShowInput.Text == "Xem Histogram nguồn")
                {
                    dgvInput.Columns[0].Visible = false;
                    dgvInput.DataSource = dsInput.Tables[0];
                }
                else if (btnShowInput.Text == "Xem vùng ảnh nguồn")
                {
                    dgvInput.Columns[0].Visible = false;
                    dgvInput.DataSource = dsInput.Tables[1];
                }
                else
                {
                    dgvInput.DataSource = null;
                    dgvInput.Columns[0].Visible = true;
                    dgvInput.Rows.Clear();
                    dgvInput.Rows.Add();
                    dgvInput.Rows[0].Height = dsInput.Tables[0].Rows.Count;
                    dgvInput.Columns[0].Width = dsInput.Tables[0].Columns.Count;
                    dgvInput.Rows[0].Cells[0].Value = bmpInput;
                }
            }
            modified = false;
        }

        private void Calc()
        {
            if (dsInput.Tables.Count > 0 && imgResult.Matrix != null)
            {
                dsInput.Tables.RemoveAt(1);
                dsInput.Tables.Add(imgInput.ToHistogramTable());
                dsResult = imgResult.ToDataSet();
                bmpResult = imgResult.ToBitmap();
            }
        }

        private void ShowResult()
        {
            if (dsInput.Tables.Count > 0 && imgResult.Matrix != null && dsResult.Tables.Count>0)
            {
                if (btnShowInput.Text == "Xem vùng ảnh nguồn")
                {
                    dgvInput.Columns[0].Visible = false;
                    dgvInput.DataSource = dsInput.Tables[1];
                }

                if (btnShowResult.Text == "Xem Histogram kết quả")
                {
                    dgvResult.Columns[0].Visible = false;
                    dgvResult.DataSource = dsResult.Tables[0];
                }
                else if (btnShowResult.Text == "Xem vùng ảnh kết quả")
                {
                    dgvResult.Columns[0].Visible = false;
                    dgvResult.DataSource = dsResult.Tables[1];
                }
                else
                {
                    dgvResult.DataSource = null;
                    dgvResult.Columns[0].Visible = true;
                    dgvResult.Rows.Clear();
                    dgvResult.Rows.Add();
                    dgvResult.Rows[0].Height = dsResult.Tables[0].Rows.Count;
                    dgvResult.Columns[0].Width = dsResult.Tables[0].Columns.Count;
                    dgvResult.Rows[0].Cells[0].Value = bmpResult;
                }
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt16(nudWidth.Value);
            int height = Convert.ToInt16(nudHeight.Value);
            imgInput = new ImageProc(height, width);
            dsInput = imgInput.ToDataSet();
            bmpInput = imgInput.ToBitmap();
            modified = false;
            ShowInput();
        }

        private void btnTaoAnhAmBan_Click(object sender, EventArgs e)
        {
            imgResult = imgInput.GetNegativeImage();
            Calc();
            ShowResult();
            btnStatus.Visible = false;
            lblInput.Text = "Tạo ảnh xám";
        }

        private void btnLocTrungVi_Click(object sender, EventArgs e)
        {
            frmInputMask frm = new frmInputMask();
            frm.nudHeight.Value = height;
            frm.nudWidth.Value = width;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                width = Convert.ToInt16(frm.nudWidth.Value);
                height = Convert.ToInt16(frm.nudHeight.Value);
                imgResult = imgInput.Medfilt(width, height);
                Calc();
                ShowResult();
                btnStatus.Visible = false;
                lblInput.Text = "Bộ lọc trung vị " + height + "x" + width;
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
            modified = false;
        }

        private void dgvResult_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvResult.ColumnCount; ++i)
            {
                dgvResult.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 1; i <= dgvResult.RowCount; ++i)
                dgvResult.Rows[i - 1].HeaderCell.Value = i.ToString();
        }

        private void dgvInput_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                dgvResult.CurrentCell = dgvResult.Rows[dgvInput.CurrentCell.RowIndex].Cells[dgvInput.CurrentCell.ColumnIndex];
            }
            catch
            {
            }
        }

        private void nudWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGen.PerformClick();
        }

        private void btnDanDoTuongPhan_Click(object sender, EventArgs e)
        {
            frmInputContrast frm = new frmInputContrast();
            frm.nudS1.Value = s1;
            frm.nudS2.Value = s2;
            frm.nudR1.Value = r1;
            frm.nudR2.Value = r2;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                s1 = Convert.ToInt16(frm.nudS1.Value);
                r1 = Convert.ToInt16(frm.nudR1.Value);
                s2 = Convert.ToInt16(frm.nudS2.Value);
                r2 = Convert.ToInt16(frm.nudR2.Value);
                imgResult = imgInput.ContrastStretching(s1, r1, s2, r2);
                Calc();
                ShowResult();
                btnStatus.Visible = false;
                lblInput.Text = "Dãn độ tương phản: (S1 ; R1) = (" + s1 + " ; " + r1 + ") ; (S2 ; R2) = (" + s2 + " ; " + r2 + ")";
            }
        }

        private void btnCanBangHistogram_Click(object sender, EventArgs e)
        {
            frmInputGrayLevel frm = new frmInputGrayLevel();
            frm.nudGrayLevel.Value = grayLevel;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                grayLevel = Convert.ToInt16(frm.nudGrayLevel.Value);
                imgResult = imgInput.HistogramEqualization(grayLevel);
                Calc();
                ShowResult();
                btnStatus.Visible = false;
                lblInput.Text = "Cân bằng Histogram: L = " + grayLevel;
            }
        }

        private void btnShowInput_Click(object sender, EventArgs e)
        {
            bool c = btnStatus.Visible;
            if (btnShowInput.Text == "Xem Histogram nguồn")
            {
                btnShowInput.Text = "Xem vùng ảnh nguồn";
            }
            else if (btnShowInput.Text == "Xem ma trận nguồn")
            {
                btnShowInput.Text = "Xem Histogram nguồn";
            }
            else
            {
                btnShowInput.Text = "Xem ma trận nguồn";
            }
            ShowInput();
            btnStatus.Visible = c;
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            if (btnShowResult.Text == "Xem Histogram kết quả")
            {
                btnShowResult.Text = "Xem vùng ảnh kết quả";
            }
            else if (btnShowResult.Text == "Xem ma trận kết quả")
            {
                btnShowResult.Text = "Xem Histogram kết quả";
            }
            else
            {
                btnShowResult.Text = "Xem ma trận kết quả";
            }
            ShowResult();
        }

        private void btnShowHistogramX_Click(object sender, EventArgs e)
        {
            frmShowHistogram frm = new frmShowHistogram();
            frm.dgvHistogram.DataSource = histogramX;
            frm.Text += " X";
            frm.ShowDialog();
        }

        private void btnHistogramSpecification_Click(object sender, EventArgs e)
        {
            frmInputHistogram frm = new frmInputHistogram();
            if(histogramX.Rows.Count == 0)
            {
                histogramX = imgHistogramX.ToHistogramTable();
                DataRow dr = histogramX.NewRow();
                dr[0] = 0;
                dr[1] = 1;
                histogramX.Rows.Add(dr);
            }
            frm.dgvInputX.DataSource = histogramX.Copy();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                imgHistogramX.DataTableToHistogram((DataTable)frm.dgvInputX.DataSource);
                histogramX = imgHistogramX.ToHistogramTable();
                imgResult = imgInput.HistogramSpecification(imgHistogramX);
                Calc();
                ShowResult();
                btnStatus.Visible = false;
                lblInput.Text = "Xử lý Matching";
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
        }

        private void dgvInput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnStatus.Visible = true;
            modified = true;//đã có sự thay đổi trên datagridview do đó phải chuyển từ datagridview vào matrix
        }

        private void rdbMatrix_CheckedChanged(object sender, EventArgs e)
        {
            dgvInput.Columns[0].Visible = false;
        }

        private void dgvResult_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                dgvInput.CurrentCell = dgvInput.Rows[dgvResult.CurrentCell.RowIndex].Cells[dgvResult.CurrentCell.ColumnIndex];
            }
            catch
            {
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All picture files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico|Bitmap Files|*.bmp|JPEG|*.jpg|PNG|*.png|GIF|*.gif|ICO|*.ico";
            op.Multiselect = false;
            op.Title = "Open an Image File";
            if(op.ShowDialog()==DialogResult.OK)
            {
                imgInput = new ImageProc(op.FileName);
                nudHeight.Value = imgInput.Matrix.GetLength(0);
                nudWidth.Value = imgInput.Matrix.GetLength(1);
                dsInput = imgInput.ToDataSet();
                bmpInput = imgInput.ToBitmap();
                modified = false;
                ShowInput();
            }
        }

        private void btnLocThongThap_Click(object sender, EventArgs e)
        {
            frmInputMatrix frm = new frmInputMatrix();
            if (filter.Rows.Count == 0)
            {
                filter = imgFilter.ToMatrixTable(true);
            }
            frm.dgvInput.DataSource = filter.Copy();
            frm.Text += " THÔNG THẤP";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                imgFilter.DataTableToMatrix((DataTable)frm.dgvInput.DataSource);
                filter = imgFilter.ToMatrixTable(true);
                imgResult = imgInput.LowPassFilter(imgFilter);
                Calc();
                ShowResult();
                btnStatus.Visible = false;
                lblInput.Text = "Bộ lọc thông thấp";
            }
        }

        private void btnLocSacNet_Click(object sender, EventArgs e)
        {
            frmInputMatrix frm = new frmInputMatrix(true);
            if (filter.Rows.Count == 0)
            {
                filter = imgFilter.ToMatrixTable(true);
            }
            frm.dgvInput.DataSource = filter.Copy();
            frm.Text += " SẮC NÉT";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                imgFilter.DataTableToMatrix((DataTable)frm.dgvInput.DataSource);
                filter = imgFilter.ToMatrixTable(true);
                imgResult = imgInput.SharpeningFilter(imgFilter);
                Calc();
                ShowResult();
                btnStatus.Visible = false;
                lblInput.Text = "Bộ lọc sắc nét";
            }
        }

        private void btnDaySang_Click(object sender, EventArgs e)
        {
            if (dgvResult.Rows.Count > 0)
            {
                imgInput = imgResult.Copy();
                btnStatus.Visible = true;
                dsInput = dsResult.Copy();
                bmpInput = bmpResult;
                modified = false;
                ShowInput();
            }
        }

        private void SaveImage(Bitmap bmp)
        {
            if (bmp != null)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Bitmap Files|*.bmp|JPEG|*.jpg|PNG|*.png|GIF|*.gif|ICO|*.ico";
                sv.FileName = "image.bmp";
                sv.Title = "Save an Image File";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    switch (sv.FilterIndex)
                    {
                        case 1:
                            {
                                bmp.Save(sv.FileName, ImageFormat.Bmp);
                                break;
                            }
                        case 2:
                            {
                                bmp.Save(sv.FileName, ImageFormat.Jpeg);
                                break;
                            }
                        case 3:
                            {
                                bmp.Save(sv.FileName, ImageFormat.Png);
                                break;
                            }
                        case 4:
                            {
                                bmp.Save(sv.FileName, ImageFormat.Gif);
                                break;
                            }
                        case 5:
                            {
                                bmp.Save(sv.FileName, ImageFormat.Icon);
                                break;
                            }
                        default:
                            bmp.Save(sv.FileName, ImageFormat.Bmp);
                            break;
                    }
                }
            }
        }

        private void btnLuuAnhNguon_Click(object sender, EventArgs e)
        {
            SaveImage(bmpInput);
        }

        private void btnLuuAnhKetQua_Click(object sender, EventArgs e)
        {
            SaveImage(bmpResult);
        }

        private void dgvInput_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (btnShowInput.Text == "Xem vùng ảnh nguồn")
            {
                e.Column.Width = 65;
            }
            else if (btnShowInput.Text == "Xem Histogram nguồn")
            {
                e.Column.Width = 40;
            }
        }

        private void dgvResult_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (btnShowResult.Text == "Xem vùng ảnh kết quả")
            {
                e.Column.Width = 65;
            }
            else if (btnShowResult.Text == "Xem Histogram kết quả")
            {
                e.Column.Width = 40;
            }
        }
    }
}
