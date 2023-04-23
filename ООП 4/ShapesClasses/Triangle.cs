using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4.ShapesClasses
{
    public class Triangle : Shape
    {

        public Triangle(Point click, Graphics graphics, char Colored, string Name)
        {
            p = click;
            g = graphics;
            this.Colored = Colored;
            this.Name = Name;
        }
        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("T");
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
            Pen pen = new Pen(Color.Brown);
            if (Colored == 'V')
                pen.Color = Color.BlueViolet;
            else if (Colored == 'B')
                pen.Color = Color.Black;
            else if (Colored == 'R')
                pen.Color = Color.IndianRed;
            else if (Colored == 'G')
                pen.Color = Color.Green;
            else if (Colored == 'P')
                pen.Color = Color.Purple;
            double angle = Math.PI / 6;
            pen.Width = 4;
            Point[] vertices = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                double x = p.X + (R * Math.Cos(angle)) / 1.6;
                double y = p.Y + (R * Math.Sin(angle) + 9) / 1.7;
                vertices[i] = new Point((int)x, (int)y);
                angle += 2 * Math.PI / 3;
            }
            g.DrawPolygon(pen, vertices);
        }
    }
}

