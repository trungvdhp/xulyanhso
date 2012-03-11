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
        #region Khai báo biến
        //Khai báo DataSet chứa dữ liệu vùng ảnh đầu vào
        DataSet dsInput = new DataSet();
        //Khai báo DataSet chứa dữ liệu vùng ảnh kết quả
        DataSet dsResult = new DataSet();
        //Khai báo DataTable chứa dữ liệu Histogram X dùng trong xử lý Matching
        DataTable histogramX = new DataTable();
        //Khai báo DataTable chứa dữ liệu Matrix bộ lọc
        DataTable filter = new DataTable();
        //Khai báo ảnh Bitmap đầu vào
        Bitmap bmpInput;
        //Khai báo ảnh Bitmap kết quả
        Bitmap bmpResult;
        //Khai báo ImageProc đầu vào
        ImageProc imgInput = new ImageProc();
        //Khai báo ImageProc kết quả
        ImageProc imgResult = new ImageProc();
        //Khai báo ImageProc chứa dữ liệu Histogram X dùng trong xử lý Matching
        ImageProc imgHistogramX = new ImageProc();
        //Khai báo ImageProc chứa dữ liệu Matrix bộ lọc
        ImageProc imgFilter = new ImageProc();
        //Khai báo kích thước của bộ lọc trung vị
        int height = 3, width = 3;
        //Khai báo số mức xám dùng trong xử lý cân bằng Histogram
        int grayLevel = 256;
        //Khai báo mảng hai chiều chứa các điểm điều khiển dùng trong dãn độ tương phản
        int[,] d = { { 0, 0 }, { 255, 255 } };
        //Khai báo biến tình trạng, nếu bằng True nghĩa là đã có sự thay đổi các dữ liệu đầu vào, ngược lại là không.
        bool modified;
        #endregion
        #region Khởi tạo các thành phần
        public frmMain()
        {
            InitializeComponent();
        }

        private void frnMain_Load(object sender, EventArgs e)
        {
            modified = false;
        }
        #endregion
        #region Các sự kiện trên DataGridView
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

        private void dgvInput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnStatus.Visible = true;
            modified = true;
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

        private void dgvInput_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Mức xám phải >= 0 và <= 255", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
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
        #endregion
        #region Mở và lưu ảnh
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All picture files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico|Bitmap Files|*.bmp|JPEG|*.jpg|PNG|*.png|GIF|*.gif|ICO|*.ico";
            op.Multiselect = false;
            op.Title = "Open an Image File";
            if (op.ShowDialog() == DialogResult.OK)
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
        #endregion
        #region Sinh và hiển thị ảnh
        private void nudWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGen.PerformClick();
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

        private void ShowInput()
        {
            if (dsInput.Tables.Count > 0)
            {
                if (btnShowInput.Text == "Xem Histogram nguồn")
                {
                    dgvInput.Columns[0].Visible = false;
                    dgvInput.DataSource = dsInput.Tables[0];
                    dgvInput.ReadOnly = false;
                }
                else if (btnShowInput.Text == "Xem vùng ảnh nguồn")
                {
                    dgvInput.Columns[0].Visible = false;
                    dgvInput.DataSource = dsInput.Tables[1];
                    dgvInput.ReadOnly = true;
                }
                else
                {
                    dgvInput.DataSource = null;
                    dgvInput.Columns[0].Visible = true;
                    dgvInput.Rows.Clear();
                    dgvInput.Rows.Add();
                    int height = dsInput.Tables[0].Rows.Count;
                    int width = dsInput.Tables[0].Columns.Count;
                    double z = Convert.ToDouble(tbrInputZoom.Value);
                    dgvInput.Rows[0].Height = (int)(height * z / 100);
                    dgvInput.Columns[0].Width = (int)(width * z / 100);
                    dgvInput.Rows[0].Cells[0].Value = bmpInput;
                    dgvInput.ReadOnly = true;
                }
            }
        }

        private void ShowResult()
        {
            if (dsInput.Tables.Count > 0 && imgResult.Matrix != null && dsResult.Tables.Count > 0)
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
                    int height = dsResult.Tables[0].Rows.Count;
                    int width = dsResult.Tables[0].Columns.Count;
                    double z = Convert.ToDouble(tbrResultZoom.Value);
                    dgvResult.Rows[0].Height = (int)(height * z / 100);
                    dgvResult.Columns[0].Width = (int)(width * z / 100);
                    dgvResult.Rows[0].Cells[0].Value = bmpResult;
                }
            }
        }

        private void PrepareInput()
        {
            if (modified == true && imgResult.Matrix != null && btnShowInput.Text == "Xem Histogram nguồn")
            {
                imgInput = new ImageProc((DataTable)dgvInput.DataSource);
                dsInput = imgInput.ToDataSet();
                bmpInput = imgInput.ToBitmap();
                modified = false;
            }
        }

        private void PrepareResult()
        {
            if (imgResult.Matrix != null)
            {
                dsResult = imgResult.ToDataSet();
                bmpResult = imgResult.ToBitmap();
                btnStatus.Visible = false;
            }
        }

        private void ChangeInputHistogram()
        {
            if (dsInput.Tables.Count > 0)
            {
                dsInput.Tables.RemoveAt(1);
                dsInput.Tables.Add(imgInput.ToHistogramTable());
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
        #endregion
        #region Các nút xử lý ảnh
        private void btnTaoAnhAmBan_Click(object sender, EventArgs e)
        {
            PrepareInput();
            imgResult = imgInput.GetNegativeImage();
            ChangeInputHistogram();
            PrepareResult();
            ShowResult();
            lblInput.Text = "Tạo ảnh âm bản";
        }

        private void btnDanDoTuongPhan_Click(object sender, EventArgs e)
        {
            frmInputDirectPoint frm = new frmInputDirectPoint(d);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrepareInput();
                d = frm.GetOutput();
                imgResult = imgInput.ContrastStretching(d);
                ChangeInputHistogram();
                PrepareResult();
                ShowResult();
                lblInput.Text = "Dãn độ tương phản";
            }
        }

        private void btnCanBangHistogram_Click(object sender, EventArgs e)
        {
            frmInputGrayLevel frm = new frmInputGrayLevel();
            frm.nudGrayLevel.Value = grayLevel;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrepareInput();
                grayLevel = Convert.ToInt16(frm.nudGrayLevel.Value);
                imgResult = imgInput.HistogramEqualization(grayLevel);
                ChangeInputHistogram();
                PrepareResult();
                ShowResult();
                lblInput.Text = "Cân bằng Histogram: L = " + grayLevel;
            }
        }

        private void btnHistogramSpecification_Click(object sender, EventArgs e)
        {
            if (histogramX.Rows.Count == 0)
            {
                histogramX = imgHistogramX.ToHistogramTable();
                DataRow dr = histogramX.NewRow();
                dr[0] = 0;
                dr[1] = 1;
                histogramX.Rows.Add(dr);
            }
            frmInputHistogram frm = new frmInputHistogram(histogramX.Copy());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrepareInput();
                imgHistogramX.DataTableToHistogram((DataTable)frm.dgvInputX.DataSource);
                histogramX = imgHistogramX.ToHistogramTable();
                imgResult = imgInput.HistogramSpecification(imgHistogramX);
                ChangeInputHistogram();
                PrepareResult();
                ShowResult();
                lblInput.Text = "Xử lý Matching";
            }
        }

        private void btnLocTrungVi_Click(object sender, EventArgs e)
        {
            frmInputMask frm = new frmInputMask();
            frm.nudHeight.Value = height;
            frm.nudWidth.Value = width;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrepareInput();
                width = Convert.ToInt16(frm.nudWidth.Value);
                height = Convert.ToInt16(frm.nudHeight.Value);
                imgResult = imgInput.Medfilt(width, height);
                PrepareResult();
                ShowResult();
                lblInput.Text = "Bộ lọc trung vị " + height + "x" + width;
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
                PrepareInput();
                imgFilter.DataTableToMatrix((DataTable)frm.dgvInput.DataSource);
                filter = imgFilter.ToMatrixTable(true);
                imgResult = imgInput.LowPassFilter(imgFilter);
                PrepareResult();
                ShowResult();
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
                PrepareInput();
                imgFilter.DataTableToMatrix((DataTable)frm.dgvInput.DataSource);
                filter = imgFilter.ToMatrixTable(true);
                imgResult = imgInput.SharpeningFilter(imgFilter);
                PrepareResult();
                ShowResult();
                lblInput.Text = "Bộ lọc sắc nét";
            }
        }
        #endregion
        #region Các sự kiện thay đổi kích thước vùng ảnh
        private void tbrInputZoom_ValueChanged(object sender, EventArgs e)
        {
            nudInputZoom.Value = tbrInputZoom.Value;
            if (btnShowInput.Text == "Xem ma trận nguồn")
            {
                int height = dsInput.Tables[0].Rows.Count;
                int width = dsInput.Tables[0].Columns.Count;
                if (height > 0)
                {
                    double z = Convert.ToDouble(tbrInputZoom.Value);
                    dgvInput.Rows[0].Height = (int)(height * z / 100);
                    dgvInput.Columns[0].Width = (int)(width * z / 100);
                }
            }
        }

        private void tbrResultZoom_ValueChanged(object sender, EventArgs e)
        {
            nudResultZoom.Value = tbrResultZoom.Value;
            if (btnShowResult.Text == "Xem ma trận kết quả")
            {
                int height = dsResult.Tables[0].Rows.Count;
                int width = dsResult.Tables[0].Columns.Count;
                if (height > 0)
                {
                    double z = Convert.ToDouble(tbrResultZoom.Value);
                    dgvResult.Rows[0].Height = (int)(height * z / 100);
                    dgvResult.Columns[0].Width = (int)(width * z / 100);
                }
            }
        }

        private void nudInputZoom_ValueChanged(object sender, EventArgs e)
        {
            tbrInputZoom.Value = (int)nudInputZoom.Value;
        }

        private void nudResultZoom_ValueChanged(object sender, EventArgs e)
        {
            tbrResultZoom.Value = (int)nudResultZoom.Value;
        }
        #endregion
    }
}
