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
        private double[,] histogram;
        private int[] lookup = new int[256];

        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public double[,] Histogram
        {
            get { return histogram; }
            set { histogram = value; }
        }

        public ImageProc()
        {
            matrix = new int[0, 0];
            histogram = new double[256,5];
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
                if(histogram[i, 0] > 0)
                {
                    histogram[i, 1] = histogram[i, 0] * 1.0 / pixelCount;
                    histogram[i, 3] = histogram[i, 2] * 1.0 / pixelCount;
                }
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

        public double[,] GetHistogram(int height, int width)
        {
            double[, ] d = new double[256, 5];
            int pixelCount = height * width;
            double p = 0;
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    d[matrix[i,j], 0]++;
                }
            }
            for (int i = 0; i < 256; ++i)
            {
                if (d[i, 0] != 0)
                {
                    d[i, 1] = d[i, 0] * 1.0 / pixelCount;
                    p += d[i, 0];
                    d[i, 2] = p;
                    d[i, 3] = p * 1.0 / pixelCount;
                    d[i, 4] = i;
                }
            }
            return d;
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

        /*public int Find(object level)
        {
            for (int i = 0; i < histogram.Count; ++i)
            {
                if ((int)level == (int)histogram[i][0])
                    return i;
            }
            return -1;
        }*/

        public ImageProc GetNegativeImage()
        {
            ImageProc imgResult = this.Clone();
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            lookup = new int[256];
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
                    histogram[matrix[i + h1, j + w1], 4] = ls[m];
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
                    histogram[matrix[i,j], 4] = k;
                    imgResult.matrix[i,j] = k;
                }
            }
            imgResult.Histogram = imgResult.GetHistogram(height, width);
            return imgResult;
        }

        public ImageProc HistogramEqualization(int L)
        {
            ImageProc imgResult = this.Clone();
            int width = matrix.GetLength(1);

            for (int i = 0; i < 256; ++i)
            {
                if(histogram[i, 0] != 0)
                    histogram[i, 4] = (int)Math.Round(histogram[i, 3]* (L - 1));
            }

            int height = matrix.GetLength(0);
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
            double min, y, rs=0;
            for (int i = 0; i < 256; ++i)
            {
                if (histogram[i, 0] != 0)
                {
                    min = 1;
                    for (int j = 0; j < 256; ++j)
                    {
                        if(h.histogram[j, 0] != 0)
                        {
                            if ((y = Math.Abs(histogram[i, 3] - h.histogram[i, 3])) < min)
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
                    if (histogram[matrix[i,j], 0] != 0)
                        imgResult.matrix[i,j] = (int)histogram[matrix[i, j], 4];
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
                            t += m.matrix[u, v] * matrix[u + i, v + j];
                        }
                    }
                    t /= sum;
                    t = Math.Round(t);
                    if (t < 0 || t > 255) t = matrix[i + h1, j + w1];
                    histogram[matrix[i + h1, j + w1], 4] = t;
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
                            t += m.matrix[u, v] * matrix[u + i, v + j];
                        }
                    }
                    if (t < 0 || t > 255) t = 0;
                    if (m.matrix[h1,w1]< 0)
                        t = matrix[i + h1, j + w1] - t;
                    else
                        t += matrix[i + h1, j + w1];
                    if (t < 0 || t > 255) t = matrix[i + h1, j + w1];
                    histogram[matrix[i + h1, j + w1], 4] = t;
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

        public DataSet ToDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(this.ToMatrixTable(false));
            ds.Tables.Add(this.ToHistogramTable());
            return ds;
        }
    }
}
