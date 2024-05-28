using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lv2
{
    public partial class Form1 : Form
    {
        Point mStartPoint, mCurrPoint;
        bool bMouseDown;
        Graphics mGraphicsHelper;
        Color color = Color.Empty;

        private const int PEN_WIDTH = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bMouseDown = false;
            this.mCurrPoint = Point.Empty;
            mGraphicsHelper = this.CreateGraphics();
            //mDrawPen = new Pen(Color.Red, PEN_WIDTH);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mStartPoint = e.Location;
            this.bMouseDown = true;
            this.mCurrPoint = Point.Empty;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.bMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.bMouseDown)
            {
                this.mCurrPoint = e.Location;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (radioBtnDrawLine.Checked)
            {
                using (Pen draw_pen = new Pen(color, PEN_WIDTH)) {
                    mGraphicsHelper.DrawLine(draw_pen, this.mStartPoint, this.mCurrPoint);
                }
                    
            }
            else if (radioBtnDrawRectangle.Checked)
            {
                using (Pen draw_pen = new Pen(color, PEN_WIDTH))
                {
                    mGraphicsHelper.DrawRectangle(draw_pen, this.mStartPoint.X, this.mStartPoint.Y, this.mCurrPoint.X - this.mStartPoint.X, this.mCurrPoint.Y - this.mStartPoint.Y);
                }
                    
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void radioBtnBlackColor_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void radioBtnRedColor_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
