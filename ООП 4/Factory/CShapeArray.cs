using Laba4OOP.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ООП_4.Factory
{
    public class CShapeArray
    {
        Graphics g;
        private List<Shape> shapes;

        public CShapeArray(Graphics g)
        {
            shapes = new List<Shape>();
            this.g = g;
        }
        public virtual Shape CreateShape(char code)
        {
            return null;
        }

        public List<Shape> getList() { return shapes; }
        public void LoadShapes(string filename)
        {
            CMyShapeFactory factory = new CMyShapeFactory(g);
            StreamReader stream = null;
            int count;
            Shape shape;
            try
            {
                stream = new StreamReader(filename);
                count = int.Parse(stream.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    char code = char.Parse(stream.ReadLine());
                    shape = factory.CreateShape(code);

                    if (shape is CGroup group)
                    {
                        stream = LoadGroup(filename, stream, factory, group);
                        shapes.Add(group);
                    }
                    else if (shape != null)
                    {
                        shape.Load(stream);
                        shapes.Add(shape);
                    }
                }
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

        }

        public StreamReader LoadGroup(string filename, StreamReader stream, CMyShapeFactory factory, CGroup group)
        {
            int gCount = int.Parse(stream.ReadLine());
            Shape shape;
            for (int j = 0; j < gCount; j++)
            {
                char code = char.Parse(stream.ReadLine());
                shape = factory.CreateShape(code);
                if (shape is CGroup _group)
                    stream = LoadGroup(filename, stream, factory, _group);
                shape.Load(stream);
                group.addShape(shape);
            }
            return stream;
        }

    }
}
