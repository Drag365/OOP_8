using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП_4.Observer;

namespace ООП_4.ShapesClasses
{
    public class Pointer : Shape
    {
        Point p1;
        Point p2;
        Shape shape1;
        Shape shape2;
        public Pointer(Point click, Graphics graphics, string Name)
        {
            p = new Point(0,0);
            g = graphics;
            this.Colored = 'B';
            this.Name = Name;
        }

        public void addShapes(Shape s1, Shape s2)
        {
            shape1 = s1;
            shape2 = s2;
            shape2.AddObserver(shape1);
        }

        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("P");
            stream.WriteLine("{0} {1} {2} {3}", p.X, p.Y, R, Colored);
        }

        public override void Load(StreamReader stream)
        {
            string[] values = stream.ReadLine().Split(' ');
            p.X = int.Parse(values[0]);
            p.Y = int.Parse(values[1]);
            R = int.Parse(values[2]);
            Colored = char.Parse(values[3]);
        }
        override public void Draw()
        {
            //Point startPoint = new Point(10, 10);
            //Point endPoint = new Point(100, 100);

            //// Создаем объект Pen для рисования линии
            //Pen pen = new Pen(Color.Black);

            //// Рисуем линию между начальной и конечной точками
            //g.DrawLine(pen, startPoint, endPoint);
            return;
        }

        public void Del()
        {
            shape1.RemoveObserver();
            shape2.RemoveObserver();
        }
    }
}
