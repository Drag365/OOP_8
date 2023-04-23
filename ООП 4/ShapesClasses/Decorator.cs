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
    public class Decorator : Shape
    {
        public Shape shape;
        private Graphics g;
        public Decorator(Shape shape)
        {
            g = shape.getG();
            this.shape = shape;

        }

        public override string Who()
        {
            return shape.Who();
        }
        public override void Save(StreamWriter stream)
        {
            shape.Save(stream);
        }

        public override void Load(StreamReader stream)
        {
            shape.Load(stream); 
        }
        override public void Draw()
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (shape is CGroup group)
            {
                foreach (Shape innerShape in group.getShapes())
                {
                    Decorator decorator = new Decorator(innerShape);
                    decorator.Draw();
                }
            }
            else
            {
                g.DrawRectangle(pen, shape.getPosition().X - (shape.getRadius() + 8) / 2, shape.getPosition().Y - (shape.getRadius() + 8) / 2, shape.getRadius() + 8, shape.getRadius() + 8);
                shape.Draw();
            }
         }

        override public bool canMove(int x, int y, int width, int height)
        {
            if (shape is CGroup group)
                return group.canMove(x, y, width, height);
            else if (shape.getPosition().X + shape.getRadius() / 2 + x < width &&
                shape.getPosition().X - shape.getRadius() / 2 + x > 0 &&
                shape.getPosition().Y + shape.getRadius() / 2 + y < height &&
                shape.getPosition().Y - shape.getRadius() / 2 + y > 0)
                return true;
            else
                return false;
        }
        override public bool checkPointPosition(Point point)
        {
            return shape.checkPointPosition(point);
        }

        override public Point getPosition()
        {
            return shape.getPosition();
        }

        override public int getRadius()
        {
            return shape.getRadius();
        }

        override public void move(int x, int y)
        {
            shape.move(x, y);
        }

        override public void upSize(int s)
        {
            shape.upSize(s);
        }

        override public void changeColor(char Color)
        {
            shape.changeColor(Color);
        }
    }
}
