using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ООП_4.Factory;
using ООП_4.Observer;
using ООП_4.ShapesClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ООП_4
{
  
    public partial class Form1 : Form
    {
        // создаем контейнер хранящий круги
        public Graphics g;// создаем объект графики
        ShapeCreation Creation;// создаем объект-конвеер кругов
        Bitmap map;// создаем битмап "мап"
        Boolean ctrlpress = false;// флажок зажатия контрола
        int typeOfShape = 0;
        char Colored = 'B';
        const string filename = "D:/data.txt";
        Container container;
        TreeViewObserver observer;
        int razWidth;
        int razHeight;



        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(1920, 1080);// определяем битмап
            paintField.Image = map;
            Creation = new ShapeCreation(Graphics.FromImage(paintField.Image));// определяем конвеер кругов
            observer = new TreeViewObserver(shapeTree);
            container = new Container(observer);
            razWidth = this.Width - paintField.Width;
            razHeight = this.Height - paintField.Height;   

        }

        protected void paintField_Paint(object sender, PaintEventArgs e)// функция отрисовки кругов
        {
            Graphics.FromImage(map).Clear(Color.LightGray);
            container.Draw();
            paintField.Image = map;
            toolStrip1.Refresh();
        }

        private void paintField_MouseClick(object sender, MouseEventArgs e)//функция нажатия мышкой для добавления на поле круга или его выделения
        {
            if (container.CheckPosition(e.Location) == false && ctrlpress == false)
            {
                if (typeOfShape == 0)
                {
                    container.Add(Creation.createCCircle(e.Location, Colored));

                }
                else if (typeOfShape == 1)
                {
                    container.Add(Creation.createSquare(e.Location, Colored));
                }
                else if (typeOfShape == 2)
                {
                    container.Add(Creation.createTriangle(e.Location, Colored));
                }

                
            }
            else if (typeOfShape == 3 && container.countSelected() == 2)
            {
                container.AddPointer(Creation.createPointer(e.Location));
            }
            paintField.Invalidate();
             razWidth = this.Width - paintField.Width;
            razHeight = this.Height - paintField.Height;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)//функция нажатия клавиши контрол или делит
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)// определяем зажатие клавиши контрол
            {
                ctrlpress = true;
                container.ctrlChange();
            }
            if (e.KeyCode == Keys.Delete)
            {
                Graphics.FromImage(map).Clear(Color.LightGray);
                container.delSelected();
            }
            if (e.KeyCode == Keys.A)
            {
                
                container.Move(-5, 0, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.S)
            {
                container.Move(0, 5, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.D)
            {
                container.Move(5, 0, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.W)
            {
                container.Move(0, -5, panel1.Width, panel1.Height);
            }

            if (e.KeyCode == Keys.E)
            {
                container.upSize(1, panel1.Width, panel1.Height);
            }

            if (e.KeyCode == Keys.Q)
            {
                container.upSize(-1, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.G)
            {
                container.Compose(Creation.createCGroup());
            }
            if (e.KeyCode == Keys.R)
            {
                container.unCompose();
            }
        }

        private void CtrlCheck_CheckedChanged(object sender, EventArgs e)//если мы выделели чекбокс "контрол зажат", то меняем значение флажка 
        {
            container.ctrlPressed = !container.ctrlPressed;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)// отжатие контрола, меняем флажок
        {
            
            if ((Control.ModifierKeys & Keys.Control) != Keys.Control && ctrlpress == true)
            {
                container.ctrlPressed = !container.ctrlPressed;
                ctrlpress = !ctrlpress;
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)// функция нажатия на кнопку "Удалить все"
        {
            Graphics.FromImage(map).Clear(Color.LightGray);
            container.delshapes();
        }

        private void selectAll_CheckedChanged(object sender, EventArgs e)
        {
            container.selectMany = !container.selectMany;
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfShape = 0;
            toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Circle;
            toolStrip1.Refresh();
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfShape = 1;
            toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Square;
            toolStrip1.Refresh();
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeOfShape = 2;
            toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Triangle;
            toolStrip1.Refresh();
        }

        private void GreenOption_Click(object sender, EventArgs e)
        {
            container.changeColor('G');
            Colored = 'G';
        }

        private void BlackOption_Click(object sender, EventArgs e)
        {
            container.changeColor('B');
            Colored = 'B';
        }

        private void PurpleOption_Click(object sender, EventArgs e)
        {
            container.changeColor('P');
            Colored = 'P';
        }

        private void BrownOption_Click(object sender, EventArgs e)
        {
            container.changeColor('R');
            Colored = 'R';
        }

        private void BlueOption_Click(object sender, EventArgs e)
        {
            container.changeColor('V');
            Colored = 'V';
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            container.Save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            CShapeArray array = new CShapeArray(Graphics.FromImage(map));
            container.Load(array);
            container.NotifyEveryone();
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            container.Compose(Creation.createCGroup());
        }

        private void unGroupButton_Click(object sender, EventArgs e)
        {
            container.unCompose();
        }

        


        private void shapeTree_MouseDown(object sender, MouseEventArgs e)
        {
            //observer.NotifyEveryone();
        }

        private void shapeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // observer.NotifyEveryone();
           
        }

        private void shapeTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            observer.NotifyEveryone();
            if (ctrlpress == false)
                observer.whiteColor();
            e.Node.BackColor = Color.Gray;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width - razWidth;
            panel1.Height = this.Height - razHeight;
            paintField.Width = this.Width - razWidth;
            paintField.Height = this.Height - razHeight;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            typeOfShape = 3;
        }
    }
    
}
