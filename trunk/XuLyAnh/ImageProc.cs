using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace XuLyAnh
{
    class ImageProc
    {
        private int[,] matrix;
        private List<double[]> histogram;

        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public List<double[]> Histogram
        {
            get { return histogram; }
            set { histogram = value; }
        }
        public ImageProc()
        {
            matrix = new int[0, 0];
            histogram = new List<double[]>();
        }

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
            histogram = GetHistogram(height, width);

        }

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
            histogram = GetHistogram(height, width);
        }

        public ImageProc(string bitmapFilePath)
        {
            Bitmap b = new Bitmap(bitmapFilePath);
            int height = Math.Min(b.Height, 768);
            int width = Math.Min(b.Width, 654);
            matrix = new int[height, width];
            for (int i = 0; i <height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    matrix[i, j] = (int)Math.Round(b.GetPixel(j, i).GetBrightness()*255);
                }
            }
            histogram = GetHistogram(height, width);
        }

        public void DataTableToHistogram(DataTable h)
        {
            DataView dv = h.DefaultView;
            h = dv.ToTable();
            double pixelCount = 0;
            double p = 0;
            histogram = new List<double[]>();
            for (int i = 0; i < h.Rows.Count; ++i)
            {
                double[] it = new double[6];
                it[0] = Convert.ToDouble(h.Rows[i][0]);
                it[1] = Convert.ToDouble(h.Rows[i][1]);
                pixelCount += it[1];
                histogram.Add(it);
            }
            for (int i = 0; i < h.Rows.Count; ++i)
            {
                histogram[i][2] = histogram[i][1]/ pixelCount;
                p += histogram[i][1];
                histogram[i][3] = p;
                histogram[i][4] = p/ pixelCount;
                histogram[i][5] = histogram[i][0];
            }
        }

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

        public List<double[]> GetHistogram(int height, int width)
        {
            List<double[]> ls = new List<double[]>();
            int pixelCount = height * width;
            int[] d = new int[256];
            int p = 0;

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    d[matrix[i,j]]++;
                }
            }
            for (int i = 0; i < 256; ++i)
            {
                if (d[i] != 0)
                {
                    double[] h = new double[6];
                    h[0] = i;
                    h[1] = d[i];
                    h[2] = d[i] * 1.0 / pixelCount;
                    p += d[i];
                    h[3] = p;
                    h[4] = p * 1.0 / pixelCount;
                    h[5] = i;
                    ls.Add(h);
                }
            }
            return ls;
        }

        public ImageProc Clone()
        {
            ImageProc img = new ImageProc();
            img.matrix = new int[this.matrix.GetLength(0), this.matrix.GetLength(1)];
            return img;
        }

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
            img.histogram = img.GetHistogram(height, width);
            return img;
        }

        public int Find(object level)
        {
            for (int i = 0; i < histogram.Count; ++i)
            {
                if ((int)level == (int)histogram[i][0])
                    return i;
            }
            return -1;
        }

        public ImageProc GetNegativeImage()
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    imgResult.matrix[i, j] = 255 - matrix[i, j];
                    this.histogram[Find(matrix[i, j])][5] = imgResult.matrix[i, j];
                }
            }
            imgResult.histogram = imgResult.GetHistogram(height, width);
            return imgResult;
        }

        public ImageProc Medfilt(int width, int height)
        {
            ImageProc imgResult = this.Clone();
            int Height = matrix.GetLength(0);
            int Width = matrix.GetLength(1);
            int h = Height - height + 1;
            int w = Width - width + 1;
            int h1 = height/2;
            int w1 = width/2;
            int m = height * width/2;

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
                            ls.Add(this.matrix[u + i, v + j]);
                        }
                    }
                    ls.Sort();
                    this.histogram[Find(matrix[i + h1, j + w1])][5] = ls[m];
                    imgResult.matrix[i + h1, j + w1] = ls[m];
                }
            }
            imgResult.Histogram = imgResult.GetHistogram(Height, Width);
            return imgResult;
        }

        private int GetS(int s1, int r1, int s2, int r2, int r)
        {
            if (r <= r1)
                return (int)Math.Round(r * s1 * 1.0 / r1);
            else if (r <= r2)
                return (int)Math.Round(((s1 * r2 - s2 * r1) + (s2 - s1) * r) * 1.0 / (r2 - r1));
            else
                return (int)Math.Round(((s2 * 255 - 255 * r2) + (255 - s2) * r) * 1.0/ (255 - r2));
        }

        public ImageProc ContrastStretching(int s1, int r1, int s2, int r2)
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int k;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    k = GetS(s1, r1, s2, r2, matrix[i,j]);
                    histogram[Find(matrix[i,j])][5] = k;
                    imgResult.matrix[i,j] = k;
                }
            }
            imgResult.Histogram = imgResult.GetHistogram(height, width);
            return imgResult;
        }

        public ImageProc HistogramEqualization(int L)
        {
            ImageProc imgResult = this.Clone();
            int height = histogram.Count;
            int width = matrix.GetLength(1);
            int k;

            for (int i = 0; i < height; ++i)
            {
                this.histogram[i][5] = (int)Math.Round(Convert.ToDouble(this.histogram[i][4])* (L - 1));
            }

            height = matrix.GetLength(0);
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (matrix[i, j] < L)
                    {
                        if ((k = Find(matrix[i, j])) != -1)
                            imgResult.matrix[i, j] = (int)this.histogram[k][5];
                    }
                    else
                    {
                        imgResult.matrix[i, j] = matrix[i,j];
                    }
                }
            }
            imgResult.histogram = GetHistogram(height, width);
            return imgResult;
        }

        public ImageProc HistogramSpecification(ImageProc h)
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int L = histogram.Count;
            int k;
            double min, x, y, rs=0;
            for (int i = 0; i < L; ++i)
            {
                x = histogram[i][4];
                min = 1;
                for (int j = 0; j < h.histogram.Count; ++j)
                {
                    y = h.histogram[j][4];
                    if((y=Math.Abs(x-y)) < min)
                    {
                        min = y;
                        rs = (int)h.histogram[j][0];
                    }
                }
                histogram[i][5] = rs;
            }

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if ((k = Find(matrix[i,j])) != -1)
                        imgResult.matrix[i,j] = (int)this.histogram[k][5];
                }
            }

            imgResult.Histogram = imgResult.GetHistogram(height, width);
            return imgResult;
        }

        public ImageProc LowPassFilter(ImageProc m)
        {
            ImageProc imgResult = this.Clone();
            int Height = matrix.GetLength(0);
            int Width = matrix.GetLength(1);
            if (Height == 0 || Width == 0) return imgResult;
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
                            t += m.matrix[u, v] * this.matrix[u + i, v + j];
                        }
                    }
                    t /= sum;
                    t = Math.Round(t);
                    if (t < 0 || t > 255) t = matrix[i + h1, j + w1];
                    this.histogram[Find(matrix[i + h1, j + w1])][5] = t;
                    imgResult.matrix[i + h1, j + w1] = (int)t;
                }
            }
            imgResult.Histogram = imgResult.GetHistogram(Height, Width);
            return imgResult;
        }

        public ImageProc SharpeningFilter(ImageProc m)
        {
            ImageProc imgResult = this.Clone();
            int Height = matrix.GetLength(0);
            int Width = matrix.GetLength(1);
            if (Height == 0 || Width == 0) return imgResult;
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
                            t += m.matrix[u, v] * this.matrix[u + i, v + j];
                        }
                    }
                    if (t < 0 || t > 255) t = 0;
                    if (m.matrix[h1,w1]< 0)
                        t = matrix[i + h1, j + w1] - t;
                    else
                        t += matrix[i + h1, j + w1];
                    if (t < 0 || t > 255) t = matrix[i + h1, j + w1];
                    this.histogram[Find(matrix[i + h1, j + w1])][5] = t;
                    imgResult.matrix[i + h1, j + w1] = t;
                }
            }
            imgResult.Histogram = imgResult.GetHistogram(Height, Width);
            return imgResult;
        }

        public Bitmap ToBitmap()
        {
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            Bitmap newBitmap = new Bitmap(width, height);
            Color newColor;
            int k;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    k = this.matrix[i,j];
                    newColor = Color.FromArgb(k, k, k);
                    newBitmap.SetPixel(j, i, newColor);
                }
            }
            return newBitmap;
        }

        public DataTable ToMatrixTable(bool flag)
        {
            DataTable dt = new DataTable();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            for (int i = 1; i <= width; ++i)
            {
                dt.Columns.Add("" + i);
                dt.Columns[i - 1].DefaultValue = 1;
                if(flag)
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

        public DataTable ToHistogramTable()
        {
            int height = histogram.Count;
            int width = 6;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mức xám");
            dt.Columns[0].DataType = Type.GetType("System.Int16");
            dt.Columns.Add("Số pixel");
            dt.Columns.Add("Tần suất");
            dt.Columns.Add("Tổng số pixel");
            dt.Columns.Add("Tổng tần suất");
            dt.Columns.Add("Ánh xạ");
            for (int i = 0; i < height; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < width; ++j)
                {
                    dr[j] = histogram[i][j];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataSet ToDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(this.ToMatrixTable(false));
            ds.Tables.Add(this.ToHistogramTable());
            return ds;
        }
    }
}
