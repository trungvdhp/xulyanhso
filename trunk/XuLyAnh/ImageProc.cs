using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;

namespace XuLyAnh
{
    class ImageProc
    {
        #region Khai báo biến
        private int[,] matrix;
        private double[,] histogram;
        #endregion
        #region Các thuộc tính
        /// <summary>
        /// Ma trận mức xám của vùng ảnh
        /// </summary>
        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        /// <summary>
        /// Histogram của vùng ảnh
        /// </summary>
        public double[,] Histogram
        {
            get { return histogram; }
            set { histogram = value; }
        }
        #endregion
        #region Các hàm cấu tử
        /// <summary>
        /// Khởi tạo một ImageProc mặc định
        /// </summary>
        public ImageProc()
        {
            matrix = new int[0, 0];
            histogram = new double[256, 5];
        }
        /// <summary>
        /// Khởi tạo một ImageProc với các mức xám sinh ngẫu nhiên
        /// </summary>
        /// <param name="height">Số pixel chiều cao của bức ảnh</param>
        /// <param name="width">Số pixel chiều rộng của bức ảnh</param>
        public ImageProc(int height, int width)
        {
            matrix = new int[height, width];
            Random r = new Random();
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    matrix[i, j] = r.Next(0, 256);
                }
            }
            CalHistogram();

        }
        /// <summary>
        /// Khởi tạo một ImageProc từ DataTable
        /// </summary>
        /// <param name="dt">Một DataTable lưu ma trận mức xám của vùng ảnh</param>
        public ImageProc(DataTable dt)
        {
            int height = dt.Rows.Count;
            int width = dt.Columns.Count;
            matrix = new int[height, width];
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    matrix[i, j] = Convert.ToInt16(dt.Rows[i][j]);
                }
            }
            CalHistogram();
        }
        /// <summary>
        /// Khởi tạo một ImageProc từ một file ảnh
        /// </summary>
        /// <param name="bitmapFilePath">Đường dẫn file ảnh</param>
        public ImageProc(string bitmapFilePath)
        {
            Bitmap b = new Bitmap(bitmapFilePath);
            int height = Math.Min(b.Height, 768);
            int width = Math.Min(b.Width, 654);
            matrix = new int[height, width];
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    matrix[i, j] = (int)Math.Round(b.GetPixel(j, i).GetBrightness() * 255);
                }
            }
            CalHistogram();
        }
        #endregion
        #region Các phương thức chuyển đổi và tính toán lại dữ liệu
        /// <summary>
        /// Chuyển đổi dữ liệu từ một Histogram DataTable sang Histogram của ImageProc
        /// </summary>
        /// <param name="h">Một DataTable chứa nội dung Histogram của 1 vùng ảnh nào đó</param>
        public void DataTableToHistogram(DataTable h)
        {
            DataView dv = h.DefaultView;
            h = dv.ToTable();
            double pixelCount = 0;
            double p = 0;
            int k;
            histogram = new double[256, 5];
            for (int i = 0; i < h.Rows.Count; ++i)
            {
                k = Convert.ToInt16(h.Rows[i][0]);
                histogram[k, 0] = Convert.ToDouble(h.Rows[i][1]);
                p = histogram[k, 0] + p;
                histogram[k, 2] = p;
                histogram[k, 4] = k;
                pixelCount += histogram[k, 0];
            }
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] > 0)
                {
                    histogram[i, 1] = histogram[i, 0] * 1.0 / pixelCount;
                    histogram[i, 3] = histogram[i, 2] * 1.0 / pixelCount;
                }
            }
        }
        /// <summary>
        /// Chuyển đổi dữ liệu từ một Matrix DataTable sang Matrix của ImageProc
        /// </summary>
        /// <param name="m">Một DataTable chứa nội dung ma trận điểm ảnh của 1 vùng ảnh nào đó</param>
        public void DataTableToMatrix(DataTable m)
        {
            int height = m.Rows.Count;
            int width = m.Columns.Count;
            matrix = new int[height, width];
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    matrix[i, j] = Convert.ToInt16(m.Rows[i][j]);
                }
            }
        }
        /// <summary>
        /// Tính toán Histogram của một vùng ảnh
        /// </summary>
        public void CalHistogram()
        {
            histogram = new double[256, 5];
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int pixelCount = height * width;
            double p = 0;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    histogram[matrix[i, j], 0]++;
                }
            }
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                {
                    histogram[i, 1] = histogram[i, 0] * 1.0 / pixelCount;
                    p += histogram[i, 0];
                    histogram[i, 2] = p;
                    histogram[i, 3] = p * 1.0 / pixelCount;
                    //histogram[i, 4] = i;
                }
            }
        }
        /// <summary>
        /// Tính toán lại Histogram của một vùng ảnh
        /// </summary>
        public void ReCalHistogram()
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int pixelCount = height * width;
            double p = 0;
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                {
                    histogram[i, 1] = histogram[i, 0] * 1.0 / pixelCount;
                    p += histogram[i, 0];
                    histogram[i, 2] = p;
                    histogram[i, 3] = p * 1.0 / pixelCount;
                    //histogram[i, 4] = i;
                }
            }
        }
        #endregion
        #region Các hàm sao chép
        /// <summary>
        /// Sao chép cấu trúc của một ImageProc
        /// </summary>
        /// <returns>Một ImageProc</returns>
        public ImageProc Clone()
        {
            ImageProc img = new ImageProc();
            img.matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            return img;
        }
        /// <summary>
        /// Sao chép cấu trúc và dữ liệu của một ImageProc
        /// </summary>
        /// <returns>Một ImageProc</returns>
        public ImageProc Copy()
        {
            ImageProc img = new ImageProc();
            int height = this.matrix.GetLength(0);
            int width = this.matrix.GetLength(1);
            img.matrix = new int[height, width];
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    img.matrix[i, j] = matrix[i, j];
                }
            }
            for (int i = 0; i < 256; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    img.histogram[i, j] = histogram[i, j];
                }
            }
            return img;
        }
        #endregion
        #region Các hàm xử lý ảnh
        /// <summary>
        /// Trả về ảnh âm bản của một vùng ảnh
        /// </summary>
        /// <returns>Một ImageProc</returns>
        public ImageProc GetNegativeImage()
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                    histogram[i, 4] = 255 - i;
            }
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    imgResult.matrix[i, j] = (int)histogram[matrix[i, j], 4];
                }
            }
            imgResult.CalHistogram();
            return imgResult;
        }
        /// <summary>
        /// Trả về vùng ảnh sau khi lọc trung vị
        /// </summary>
        /// <param name="width">Chiều rộng bộ lọc trung vị</param>
        /// <param name="height">Chiều cao bộ lọc trung vị</param>
        /// <returns>Một ImageProc</returns>
        public ImageProc Medfilt(int width, int height)
        {
            ImageProc imgResult = this.Clone();
            int Height = matrix.GetLength(0);
            int Width = matrix.GetLength(1);
            int h = Height - height + 1;
            int w = Width - width + 1;
            int h1 = height / 2;
            int w1 = width / 2;
            int m = height * width / 2;

            for (int i = 0; i < h1; ++i)
            {
                for (int j = 0; j < Width; ++j)
                {
                    imgResult.matrix[i, j] = matrix[i, j];
                    imgResult.matrix[Height - i - 1, j] = matrix[Height - i - 1, j];
                }
            }

            for (int i = h1; i < Height - h1; ++i)
            {
                for (int j = 0; j < w1; ++j)
                {
                    imgResult.matrix[i, j] = matrix[i, j];
                    imgResult.matrix[i, Width - j - 1] = matrix[i, Width - j - 1];
                }
            }

            for (int i = 0; i < h; ++i)
            {
                for (int j = 0; j < w; ++j)
                {
                    List<int> ls = new List<int>();
                    for (int u = 0; u < height; ++u)
                    {
                        for (int v = 0; v < width; ++v)
                        {
                            ls.Add(matrix[u + i, v + j]);
                        }
                    }
                    ls.Sort();
                    //histogram[matrix[i + h1, j + w1], 4] = ls[m];
                    imgResult.matrix[i + h1, j + w1] = ls[m];
                }
            }
            imgResult.CalHistogram();
            return imgResult;
        }
        /// <summary>
        /// Trả về vùng ảnh sau khi giãn độ tương phản
        /// </summary>
        /// <param name="d">Mảng hai chiều các điểm điều khiển: (đầu vào ri, đáp ứng si)</param>
        /// <returns>Một ImageProc</returns>
        public ImageProc ContrastStretching(int[,] d)
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int n = d.GetLength(0);
            int[] c = new int[256];
            int[] dr = new int[n - 1];
            int[] ds = new int[n - 1];
            for (int i = 1; i < n; ++i)
            {
                dr[i - 1] = d[i, 0] - d[i - 1, 0];
                ds[i - 1] = d[i, 1] - d[i - 1, 1];
            }
            for (int i = 0; i < 256; ++i)
            {
                for (int j = 1; j < n; ++j)
                {
                    if (i <= d[j, 0])
                    {
                        c[i] = (int)(Math.Round((i - d[j - 1, 0]) * ds[j - 1] * 1.0 / dr[j - 1] + d[j - 1, 1]));
                        histogram[i, 4] = c[i];
                        break;
                    }
                }
            }
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    imgResult.matrix[i, j] = c[matrix[i, j]];
                }
            }
            imgResult.CalHistogram();
            return imgResult;
        }
        /// <summary>
        /// Trả về vùng ảnh sau khi cân bằng Histogram
        /// </summary>
        /// <param name="L">Số mức xám</param>
        /// <returns>Một ImageProc</returns>
        public ImageProc HistogramEqualization(int L)
        {
            ImageProc imgResult = this.Clone();
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);

            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                    histogram[i, 4] = (int)Math.Round(histogram[i, 3] * (L - 1));
            }

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (matrix[i, j] < L)
                    {
                        imgResult.matrix[i, j] = (int)histogram[matrix[i, j], 4];
                    }
                    else
                    {
                        imgResult.matrix[i, j] = matrix[i, j];
                    }
                }
            }
            imgResult.CalHistogram();
            return imgResult;
        }
        /// <summary>
        /// Trả về vùng ảnh sau khi xử lý Matching
        /// </summary>
        /// <param name="h">Một ImageProc có Histogram cho trước</param>
        /// <returns>Một ImageProc</returns>
        public ImageProc HistogramSpecification(ImageProc h)
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            if (height == 0) return imgResult;
            int width = matrix.GetLength(1);
            double min, y, rs = 0;
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                {
                    min = 1;
                    for (int j = 0; j < 256; ++j)
                    {
                        if (h.histogram[j, 0] != 0)
                        {
                            if ((y = Math.Abs(histogram[i, 3] - h.histogram[j, 3])) < min)
                            {
                                min = y;
                                rs = j;
                            }
                        }
                    }
                    histogram[i, 4] = rs;
                }
            }

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (histogram[matrix[i, j], 0] != 0)
                        imgResult.matrix[i, j] = (int)histogram[matrix[i, j], 4];
                }
            }

            imgResult.CalHistogram();
            return imgResult;
        }
        /// <summary>
        /// Trả về vùng ảnh sau khi lọc thông thấp
        /// </summary>
        /// <param name="m">Một ImageProc có Matrix là bộ lọc thông thấp</param>
        /// <returns>Một ImageProc</returns>
        public ImageProc LowPassFilter(ImageProc m)
        {
            ImageProc imgResult = this.Clone();
            int Height = matrix.GetLength(0);
            int Width = matrix.GetLength(1);
            if (Height == 0) return imgResult;
            int height = m.matrix.GetLength(0);
            int width = m.matrix.GetLength(1);
            int h = Height - height + 1;
            int w = Width - width + 1;
            int h1 = height / 2;
            int w1 = width / 2;

            for (int i = 0; i < h1; ++i)
            {
                for (int j = 0; j < Width; ++j)
                {
                    imgResult.matrix[i, j] = matrix[i, j];
                    imgResult.matrix[Height - i - 1, j] = matrix[Height - i - 1, j];
                }
            }

            for (int i = h1; i < Height - h1; ++i)
            {
                for (int j = 0; j < w1; ++j)
                {
                    imgResult.matrix[i, j] = matrix[i, j];
                    imgResult.matrix[i, Width - j - 1] = matrix[i, Width - j - 1];
                }
            }

            int sum = 0;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    sum += m.matrix[i, j];
                }
            }

            if (sum == 0) sum = 1;
            for (int i = 0; i < h; ++i)
            {
                for (int j = 0; j < w; ++j)
                {
                    double t = 0;
                    for (int u = 0; u < height; ++u)
                    {
                        for (int v = 0; v < width; ++v)
                        {
                            t += m.matrix[u, v] * matrix[u + i, v + j];
                        }
                    }
                    t /= sum;
                    t = Math.Round(t);
                    if (t < 0 || t > 255) t = matrix[i + h1, j + w1];
                    //histogram[matrix[i + h1, j + w1], 4] = t;
                    imgResult.matrix[i + h1, j + w1] = (int)t;
                }
            }
            imgResult.CalHistogram();
            return imgResult;
        }
        /// <summary>
        /// Trả về vùng ảnh sau khi lọc sắc nét
        /// </summary>
        /// <param name="m">Một ImageProc có Matrix là bộ lọc sắc nét</param>
        /// <returns>Một ImageProc</returns>
        public ImageProc SharpeningFilter(ImageProc m)
        {
            ImageProc imgResult = this.Clone();
            int Height = matrix.GetLength(0);
            int Width = matrix.GetLength(1);
            if (Height == 0) return imgResult;
            int height = m.matrix.GetLength(0);
            int width = m.matrix.GetLength(1);
            int h = Height - height + 1;
            int w = Width - width + 1;
            int h1 = height / 2;
            int w1 = width / 2;

            //Các phần biên không xử lý
            for (int i = 0; i < h1; ++i)
            {
                for (int j = 0; j < Width; ++j)
                {
                    imgResult.matrix[i, j] = matrix[i, j];
                    imgResult.matrix[Height - i - 1, j] = matrix[Height - i - 1, j];
                }
            }

            for (int i = h1; i < Height - h1; ++i)
            {
                for (int j = 0; j < w1; ++j)
                {
                    imgResult.matrix[i, j] = matrix[i, j];
                    imgResult.matrix[i, Width - j - 1] = matrix[i, Width - j - 1];
                }
            }

            //Tính toán đáp ứng
            for (int i = 0; i < h; ++i)
            {
                for (int j = 0; j < w; ++j)
                {
                    int t = 0;
                    for (int u = 0; u < height; ++u)
                    {
                        for (int v = 0; v < width; ++v)
                        {
                            t += m.matrix[u, v] * matrix[u + i, v + j];
                        }
                    }
                    if (t < 0 || t > 255) t = 0;
                    if (m.matrix[h1, w1] < 0)
                        t = matrix[i + h1, j + w1] - t;
                    else
                        t += matrix[i + h1, j + w1];
                    if (t < 0 || t > 255) t = matrix[i + h1, j + w1];
                    //histogram[matrix[i + h1, j + w1], 4] = t;
                    imgResult.matrix[i + h1, j + w1] = t;
                }
            }
            imgResult.CalHistogram();
            return imgResult;
        }
        #endregion
        #region Các hàm chuyển đổi dữ liệu
        /// <summary>
        /// Chuyển đổi dữ liệu Matrix của ImageProc thành dữ liệu ảnh Bitmap 
        /// </summary>
        /// <returns>Một ảnh Bitmap</returns>
        public Bitmap ToBitmap()
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            if (height == 0) return null;
            Bitmap newBitmap = new Bitmap(width, height);
            Color newColor;
            int k;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    k = this.matrix[i, j];
                    newColor = Color.FromArgb(k, k, k);
                    newBitmap.SetPixel(j, i, newColor);
                }
            }
            return newBitmap;
        }
        /// <summary>
        /// Chuyển đổi dữ liệu Matrix của ImageProc sang dữ liệu DataTable
        /// </summary>
        /// <param name="flag">flag=True:dữ liệu DataTable trả về là kiểu Int16; ngược lại là kiểu Byte</param>
        /// <returns>Một DataTable</returns>
        public DataTable ToMatrixTable(bool flag)
        {
            DataTable dt = new DataTable();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            for (int i = 1; i <= width; ++i)
            {
                dt.Columns.Add("" + i);
                dt.Columns[i - 1].DefaultValue = 1;
                if (flag)
                    dt.Columns[i - 1].DataType = Type.GetType("System.Int16");
                else
                    dt.Columns[i - 1].DataType = Type.GetType("System.Byte");
            }

            for (int i = 0; i < height; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < width; ++j)
                {
                    dr[j] = matrix[i, j];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        /// <summary>
        /// Chuyển đổi dữ liệu Histogram của ImageProc sang dữ liệu DataTable
        /// </summary>
        /// <returns>Một DataTable</returns>
        public DataTable ToHistogramTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mức xám");
            dt.Columns[0].DataType = Type.GetType("System.Int16");
            dt.Columns.Add("Số pixel");
            dt.Columns.Add("Tần suất");
            dt.Columns.Add("Tổng số pixel");
            dt.Columns.Add("Tổng tần suất");
            dt.Columns.Add("Ánh xạ");
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = histogram[i, 0];
                    dr[2] = String.Format("{0:0.000000}", histogram[i, 1]);
                    dr[3] = histogram[i, 2];
                    dr[4] = String.Format("{0:0.000000}", histogram[i, 3]);
                    dr[5] = histogram[i, 4];
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        /// <summary>
        /// Chuyển đổi dữ liệu của ImageProc sang dữ liệu DataSet chứa Matrix DataTable và Histogram DataTable
        /// </summary>
        /// <returns>Một DataSet</returns>
        public DataSet ToDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(this.ToMatrixTable(false));
            ds.Tables.Add(this.ToHistogramTable());
            return ds;
        }
        #endregion
    }
}
