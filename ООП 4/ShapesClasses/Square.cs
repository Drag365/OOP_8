using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4
{
    public class Square : Shape
    {
        public Square(Point click, Graphics graphics, char Colored, string Name)
        {
            p = click;
            g = graphics;
            this.Colored = Colored;
            this.Name = Name;
        }
        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("S");
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
            pen.Width = 4;
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
            g.DrawRectangle(pen, p.X - R / 2, p.Y - R / 2, R, R);
        }
    }
}
