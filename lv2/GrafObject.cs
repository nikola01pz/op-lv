using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv2
{
    class GrafObject
    {
        private Color color;
        private Point coordinate;

        public GrafObject (Color b, Point c){
            this.color = b;
            this.coordinate = c;
        }

        public GrafObject(GrafObject grafobject)
        {
            this.color = grafobject.color;
            this.coordinate = grafobject.coordinate;
        }

        public void SetColor(Color b)
        {
            this.color = b;
        }

        public Color GetColor() 
        { 
            return this.color; 
        }

        public virtual void DrawGrafObject(Graphics g) { }

        public Point Coordinate
        {
            get { return coordinate; }
            set { coordinate = value; }
        }
    }
}
