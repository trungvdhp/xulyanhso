using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace XuLyAnh
{
    class HistogramT:DataTable
    {
        int pixelCount;
        public int PixelCount
        {
            get {return pixelCount;}
        }

        private void InitializeComponent()
        {
            pixelCount = 0;
            this.Columns.Add("Mức xám");
            this.Columns[0].DataType = Type.GetType("System.Int16");
            this.Columns.Add("Số pixel");
            this.Columns.Add("Tần suất");
            this.Columns.Add("Tổng số pixel");
            this.Columns.Add("Tổng tần suất");
            this.Columns.Add("Ánh xạ");
        }

        public HistogramT()
        {
            InitializeComponent();
        }

        public HistogramT(DataTable h)
        {
            InitializeComponent();
            DataView dv = h.DefaultView;
            h = dv.ToTable();
            pixelCount = 0;
            int p = 0;
            int[] d = new int[145];
            int[] m = new int[256];
            for (int i = 0; i < h.Rows.Count; ++i)
            {
                m[i] = Convert.ToInt16(h.Rows[i][0]);
                d[i] = Convert.ToInt16(h.Rows[i][1]);
                DataRow dr = this.NewRow();
                dr[0] = m[i];
                dr[1] = d[i];
                pixelCount += d[i];
                this.Rows.Add(dr);
            }
            for (int i = 0; i < h.Rows.Count; ++i)
            {
                this.Rows[i][2] = d[i] *1.0 / pixelCount;
                p += d[i];
                this.Rows[i][3] = p;
                this.Rows[i][4] = p * 1.0 / pixelCount;
                this.Rows[i][5] = m[i];
            }
        }
        public HistogramT(ImageProc img)
        {
            InitializeComponent();
            int height = 0;
            int width = 0;
            pixelCount = height * width;
            int[] d = new int[256];
            int p = 0;

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    d[Convert.ToInt16(img.Matrix[i,j])]++;
                }
            }

            for (int i = 0; i < 256; ++i)
            {
                if (d[i] != 0)
                {
                    DataRow dr = this.NewRow();
                    dr[0] = i;
                    dr[1] = d[i];
                    dr[2] = d[i] *1.0 / pixelCount;
                    p += d[i];
                    dr[3] = p;
                    dr[4] = p*1.0 / pixelCount;
                    dr[5] = i;
                    this.Rows.Add(dr);
                }
            }
        }

        public int Find(object level)
        {
            for (int i = 0; i < this.Rows.Count; ++i)
                if (level.ToString() == this.Rows[i][0].ToString())
                    return i;
            return -1;
        }
    }
}
