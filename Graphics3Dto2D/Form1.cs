using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics3Dto2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void MainForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            double neg = -20;
            double pov = 20;
            double near = 100;
            double far = 140;
            Projection proc;
            proc = new Projection();

            //create a graphics object from the form
            Graphics g = this.CreateGraphics();
            // Create font and brush.
            Pen blackPen = new Pen(Color.Black);
            Font drawFont = new Font("Arial", 16);
            Pen p = new Pen(Color.Red, 1);
            Pen boder = new Pen(Color.Black, 4);

            //draw boder for window
            g.DrawLine(boder, 320, 20, 1120, 20);
            g.DrawLine(boder, 320, 680, 1120, 680);
            g.DrawLine(boder, 320, 20, 320, 680);
            g.DrawLine(boder, 1120, 20, 1120, 680);

            //59 68 65

            _3Dpoint Dpoint1, Dpoint2, Dpoint3, Dpoint4, Dpoint5, Dpoint6, Dpoint7, Dpoint8;

            //draw front
            Dpoint1 = new _3Dpoint(neg, near, pov);
            Dpoint2 = new _3Dpoint(pov, near, pov);
            Dpoint3 = new _3Dpoint(pov, near, pov);
            Dpoint4 = new _3Dpoint(pov, near, neg);
            Dpoint5 = new _3Dpoint(pov, near, neg);
            Dpoint6 = new _3Dpoint(neg, near, neg);
            Dpoint7 = new _3Dpoint(neg, near, neg);
            Dpoint8 = new _3Dpoint(neg, near, pov);

            proc.Trans_Line(Dpoint1, Dpoint2);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint3, Dpoint4);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint5, Dpoint6);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint7, Dpoint8);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);



            //draw back
            Dpoint1 = new _3Dpoint(neg + 20, far, pov + 20);
            Dpoint2 = new _3Dpoint(pov + 20, far, pov + 20);
            Dpoint3 = new _3Dpoint(pov + 20, far, pov + 20);
            Dpoint4 = new _3Dpoint(pov + 20, far, neg + 20);
            Dpoint5 = new _3Dpoint(pov + 20, far, neg + 20);
            Dpoint6 = new _3Dpoint(neg + 20, far, neg + 20);
            Dpoint7 = new _3Dpoint(neg + 20, far, neg + 20);
            Dpoint8 = new _3Dpoint(neg + 20, far, pov + 20);

            proc.Trans_Line(Dpoint1, Dpoint2);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint3, Dpoint4);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint5, Dpoint6);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint7, Dpoint8);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);


            //draw left side
            Dpoint1 = new _3Dpoint(neg, near, pov);
            Dpoint2 = new _3Dpoint(neg + 20, far, pov + 20);
            Dpoint3 = new _3Dpoint(neg + 20, far, pov + 20);
            Dpoint4 = new _3Dpoint(neg + 20, far, -pov + 20);
            Dpoint5 = new _3Dpoint(neg + 20, far, -pov + 20);
            Dpoint6 = new _3Dpoint(neg + 20, near, -pov + 20);
            Dpoint7 = new _3Dpoint(neg + 20, near, -pov + 20);
            Dpoint8 = new _3Dpoint(neg, near, -pov);

            proc.Trans_Line(Dpoint1, Dpoint2);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint3, Dpoint4);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint5, Dpoint6);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint7, Dpoint8);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);



            //draw right side
            Dpoint1 = new _3Dpoint(pov, near, pov);
            Dpoint2 = new _3Dpoint(pov + 20, far, pov + 20);
            Dpoint3 = new _3Dpoint(pov + 20, far, pov + 20);
            Dpoint4 = new _3Dpoint(pov + 20, far, -pov + 20);
            Dpoint5 = new _3Dpoint(pov + 20, far, -pov + 20);
            Dpoint6 = new _3Dpoint(pov, near, -pov);
            Dpoint7 = new _3Dpoint(pov, near, -pov);
            Dpoint8 = new _3Dpoint(pov, near, -pov);

            proc.Trans_Line(Dpoint1, Dpoint2);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint3, Dpoint4);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint5, Dpoint6);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

            proc.Trans_Line(Dpoint7, Dpoint8);
            g.DrawLine(p, proc.p1.h, proc.p1.v, proc.p2.h, proc.p2.v);

        }


    }
}
