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
        public int num1 = 0;
        public int num2 = 0;
        public int num3 = 0;
        public int num4 = 0;
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
                    num1++;
                    shape = new Square(new Point(0, 0), g, 'B', "Квадрат" + num1.ToString());
                    break;
                case 'C':
                    num2++;
                    shape = new CCIrcle(new Point(0,0), g, 'B', "Круг" + num2.ToString());
                    break;
                case 'T':
                    num3++;
                    shape = new Triangle(new Point(0, 0), g, 'B', "Треугольник" + num3.ToString());
                    break;
                case 'G':
                    num4++;
                    shape = new CGroup(g, "Группа" + num4.ToString());
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
