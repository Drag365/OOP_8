using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Laba4OOP.src;
using System.Windows.Forms;
using System.IO;

namespace ООП_4
{
    public class CCIrcle : Shape
    {
        public CCIrcle(Point click, Graphics graphics, char Colored)
        {
            p = click;
            g = graphics;
            this.Colored = Colored;
        }

        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("C");
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
            pen.Width = 4;
            g.DrawEllipse(pen, p.X - R / 2, p.Y - R / 2, R, R);
        }


    }
}
