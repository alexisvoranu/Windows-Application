using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectNou2
{
    public partial class FormGrafic : Form
    {
        int nrobs;
        string[] x;
        int[] y;
        int pagcurenta;


        public FormGrafic()
        {
            InitializeComponent();
            nrobs = 5;
            x = new string[] { "Portocale", "Banane", "Kiwi", "Mere", "Morcovi" };
            y = new int[] { 45, 56, 75, 36, 65 };
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle zonaClient = e.ClipRectangle;

            Brush fundal = new SolidBrush(Color.White);

            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20; zonaClient.Y += 20;
            zonaClient.Height -= 40; zonaClient.Width -= 40;

            int vl = zonaClient.Left, vr = zonaClient.Right,
                vt = zonaClient.Top, vb = zonaClient.Bottom, i;

            Pen creionRosu = new Pen(Color.Red, 2);
            g.DrawRectangle(creionRosu, zonaClient);

            int lat, dist;
            string denx = "";
            float rap_dis_lat = 0.2f, max;

            SolidBrush[] pensule = new SolidBrush[]
            {
            new SolidBrush(Color.DeepPink),
            new SolidBrush(Color.LightSeaGreen),
            new SolidBrush(Color.MediumPurple),
            new SolidBrush(Color.DeepSkyBlue),
            new SolidBrush(Color.Orange),
            new SolidBrush(Color.Moccasin)
            };

            Pen[] creioane = new Pen[]
            {
            new Pen(Color.Moccasin),
            new Pen(Color.Yellow),
            new Pen(Color.Blue),
            new Pen(Color.HotPink),
            new Pen(Color.DarkGreen),
            new Pen(Color.LightPink),
            };

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            lat = (int)((vr - vl) / (int)((nrobs + 1) * rap_dis_lat + nrobs) * 0.95);
            dist = (int)(lat * rap_dis_lat);

            for (max = y[0], i = 1; i < nrobs; i++)
            {
                if (max < y[i])
                    max = y[i];
            }

            creionCurent = creioane[0];

            g.DrawLine(creionCurent, vl, vt, vl, vb);
            g.DrawLine(creionCurent, vl, vb, vr, vb);

            Font font = new Font("Arial", 8, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Near;

            for (i = 0; i < nrobs; i++)
            {
                pensulaCurenta = pensule[i % pensule.Length];
                PointF pnt = new PointF(vl + i * (lat + dist) + rap_dis_lat + dist, vb - 0.95f * y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, 0.95f * y[i] * (vb - vt) / max);

                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

                denx = "" + x[i];
                g.DrawString(denx, font, pensulaCurenta, vl + dist + lat / 2 + i * (lat + dist), vb + 5, format);
                g.DrawString(y[i].ToString("F2") + " kg", font, Brushes.Black, vl + dist + lat / 2 + i * (lat + dist), vb - 15, format);
            }
        }

        private void FormGrafic_Load(object sender, EventArgs e)
        {
            
        }

    }
}
