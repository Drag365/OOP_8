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

        private String name1 = "Круг ";
        private String name2 = "Квадрат ";
        private String name3 = "Треугольник ";
        private String name4 = "Группа ";
        private String name5 = "Стрелка ";
        private int num1 = 0;
        private int num2 = 0;
        private int num3 = 0;
        private int num4 = 0;
        private int num5 = 0;
        public ShapeCreation(Graphics graphics)
        {
            g = graphics;
        }

        public CCIrcle createCCircle(Point click, char Colored)
        {
            num1++;
            return new CCIrcle(click, g, Colored, name1 + num1.ToString());
        }

        public CGroup createCGroup()
        {
            num4++;
            return new CGroup(g, name4 + num4.ToString());
        }

        public Square createSquare(Point click, char Colored)
        {
            num2++;
            return new Square(click, g, Colored, name2 + num2.ToString());
        }

        public Triangle createTriangle(Point click, char Colored)
        {
            num3++;
            return new Triangle(click, g, Colored, name3 + num3.ToString());
        }

        public Pointer createPointer(Point click)
        {
            num5++;
            return new Pointer(click, g, name5 + num5.ToString());
        }
    }
}
