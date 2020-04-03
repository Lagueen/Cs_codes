using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void draw_Click_1(object sender, EventArgs e)
        {
            setValue();
            if (graphics == null)
                graphics = this.CreateGraphics();
            drawCayleyTree(n, 230, 350, leng,-Math.PI/2 );
            
        }

        private Graphics graphics;
        int n;
        double leng;
        double per1;
        double per2;
        double th1;
        double th2;
        void setValue()
        {
            n = int.Parse(n_value.Text);
            leng = double.Parse(leng_value.Text);
            per1 = double.Parse(per1_value.Text);
            per2 = double.Parse(per2_value.Text);
            th1 = double.Parse(th1_value.Text) * Math.PI / 180;
            th2 = double.Parse(th2_value.Text) * Math.PI / 180;
        }
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            Pen pen;
            switch (pens_value.Text)
            {
                case "Blue":pen = Pens.Blue;break;
                case "Red": pen = Pens.Red; break;
                case "Green": pen = Pens.Green; break;
                case "Yellow": pen = Pens.Yellow; break;
                default:pen = null;break;
            }
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

    }
}
