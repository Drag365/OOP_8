using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ООП_4.ShapesClasses;

namespace ООП_4
{
    class ShapeCreation
    {
        private Graphics g;
        public ShapeCreation(Graphics graphics)
        {
            g = graphics;
        }

        public CCIrcle createCCircle(Point click, char Colored)
        {
            return new CCIrcle(click, g, Colored);
        }

        public CGroup createCGroup()
        {
            return new CGroup(g);
        }

        public Square createSquare(Point click, char Colored)
        {
            return new Square(click, g, Colored);
        }

        public Triangle createTriangle(Point click, char Colored)
        {
            return new Triangle(click, g, Colored);
        }
    }
}
