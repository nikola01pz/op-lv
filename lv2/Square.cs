using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2
{
    class Square: Line
    {
        public Square(GrafObject grafobject, Point c) : base(grafobject, c)
        {
            this.endCoordinate = c;
        }

        public override void DrawGrafObject(Graphics g)
        {
            g.DrawRectangle(new Pen(GetColor()),
                            Math.Min(Coordinate.X, endCoordinate.X),
                            Math.Min(Coordinate.Y, endCoordinate.Y),
                            Math.Abs(endCoordinate.X - Coordinate.X),
                            Math.Abs(endCoordinate.Y - Coordinate.Y));
        }
    }
}
