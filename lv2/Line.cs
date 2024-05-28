using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2
{
    class Line: GrafObject
    {
        public Point endCoordinate;

        public Line(GrafObject grafobject, Point c) : base(grafobject)
        {
            this.endCoordinate = c;
        }
        public override void DrawGrafObject(Graphics g)
        {
            g.DrawLine(new Pen(this.GetColor()), Coordinate, endCoordinate);
        }
    }
}
