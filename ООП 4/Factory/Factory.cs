using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП_4.ShapesClasses;

namespace ООП_4
{
    public abstract class CShapeFactory
    {
        
        public abstract Shape CreateShape(char code);

    }

    public class CMyShapeFactory : CShapeFactory
    {
        public Graphics g;
        public CMyShapeFactory(Graphics g)
        {
            this.g = g;
        }
        public override Shape CreateShape(char code)
        {
            Shape shape = null;
            switch (code)
            {
                case 'S':
                    shape = new Square(new Point(0, 0), g, 'B');
                    break;
                case 'C':
                    shape = new CCIrcle(new Point(0,0), g, 'B');
                    break;
                case 'T':
                    shape = new Triangle(new Point(0, 0), g, 'B');
                    break;
                case 'G':
                    shape = new CGroup(g);
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
