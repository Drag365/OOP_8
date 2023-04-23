
using System.Windows.Forms;

namespace ООП_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CtrlCheck = new System.Windows.Forms.CheckBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paintField = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.loadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.GreenOption = new System.Windows.Forms.ToolStripMenuItem();
            this.BlackOption = new System.Windows.Forms.ToolStripMenuItem();
            this.PurpleOption = new System.Windows.Forms.ToolStripMenuItem();
            this.BrownOption = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueOption = new System.Windows.Forms.ToolStripMenuItem();
            this.groupButton = new System.Windows.Forms.ToolStripButton();
            this.unGroupButton = new System.Windows.Forms.ToolStripButton();
            this.shapeTree = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintField)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlCheck
            // 
            this.CtrlCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlCheck.AutoSize = true;
            this.CtrlCheck.Location = new System.Drawing.Point(601, 12);
            this.CtrlCheck.Name = "CtrlCheck";
            this.CtrlCheck.Size = new System.Drawing.Size(75, 17);
            this.CtrlCheck.TabIndex = 0;
            this.CtrlCheck.TabStop = false;
            this.CtrlCheck.Text = "Ctrl зажат";
            this.CtrlCheck.UseVisualStyleBackColor = true;
            this.CtrlCheck.CheckedChanged += new System.EventHandler(this.CtrlCheck_CheckedChanged);
            // 
            // deleteAll
            // 
            this.deleteAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteAll.Location = new System.Drawing.Point(296, 392);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(186, 29);
            this.deleteAll.TabIndex = 1;
            this.deleteAll.Text = "Удалить все";
            this.deleteAll.UseCompatibleTextRendering = true;
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // selectAll
            // 
            this.selectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAll.AutoSize = true;
            this.selectAll.Location = new System.Drawing.Point(601, 39);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(178, 17);
            this.selectAll.TabIndex = 2;
            this.selectAll.Text = "Выдеять несколько объектов";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.CheckedChanged += new System.EventHandler(this.selectAll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.paintField);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 324);
            this.panel1.TabIndex = 3;
            // 
            // paintField
            // 
            this.paintField.BackColor = System.Drawing.Color.LightGray;
            this.paintField.Location = new System.Drawing.Point(0, 0);
            this.paintField.Name = "paintField";
            this.paintField.Size = new System.Drawing.Size(550, 322);
            this.paintField.TabIndex = 0;
            this.paintField.TabStop = false;
            this.paintField.Paint += new System.Windows.Forms.PaintEventHandler(this.paintField_Paint);
            this.paintField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintField_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(8, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 64);
            this.panel2.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.loadButton,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.groupButton,
            this.unGroupButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(378, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::ООП_4.Properties.Resources.Сохранить;
            this.saveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(54, 54);
            this.saveButton.Text = "toolStripButton1";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadButton.Image = global::ООП_4.Properties.Resources.Загрузить;
            this.loadButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(54, 54);
            this.loadButton.Text = "toolStripButton2";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кругToolStripMenuItem,
            this.квадратToolStripMenuItem,
            this.треугольникToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Circle;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 54);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            this.треугольникToolStripMenuItem.Click += new System.EventHandler(this.треугольникToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GreenOption,
            this.BlackOption,
            this.PurpleOption,
            this.BrownOption,
            this.BlueOption});
            this.toolStripDropDownButton2.Image = global::ООП_4.Properties.Resources.Fill;
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(63, 54);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // GreenOption
            // 
            this.GreenOption.Name = "GreenOption";
            this.GreenOption.Size = new System.Drawing.Size(144, 22);
            this.GreenOption.Text = "Зеленый";
            this.GreenOption.Click += new System.EventHandler(this.GreenOption_Click);
            // 
            // BlackOption
            // 
            this.BlackOption.Name = "BlackOption";
            this.BlackOption.Size = new System.Drawing.Size(144, 22);
            this.BlackOption.Text = "Черный";
            this.BlackOption.Click += new System.EventHandler(this.BlackOption_Click);
            // 
            // PurpleOption
            // 
            this.PurpleOption.Name = "PurpleOption";
            this.PurpleOption.Size = new System.Drawing.Size(144, 22);
            this.PurpleOption.Text = "Фиолетовый";
            this.PurpleOption.Click += new System.EventHandler(this.PurpleOption_Click);
            // 
            // BrownOption
            // 
            this.BrownOption.Name = "BrownOption";
            this.BrownOption.Size = new System.Drawing.Size(144, 22);
            this.BrownOption.Text = "Красный";
            this.BrownOption.Click += new System.EventHandler(this.BrownOption_Click);
            // 
            // BlueOption
            // 
            this.BlueOption.Name = "BlueOption";
            this.BlueOption.Size = new System.Drawing.Size(144, 22);
            this.BlueOption.Text = "Синий";
            this.BlueOption.Click += new System.EventHandler(this.BlueOption_Click);
            // 
            // groupButton
            // 
            this.groupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupButton.Image = global::ООП_4.Properties.Resources.Сгруппировать;
            this.groupButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.groupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(54, 54);
            this.groupButton.Text = "toolStripButton3";
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // unGroupButton
            // 
            this.unGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unGroupButton.Image = global::ООП_4.Properties.Resources.Разгруппировать;
            this.unGroupButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unGroupButton.Name = "unGroupButton";
            this.unGroupButton.Size = new System.Drawing.Size(54, 54);
            this.unGroupButton.Text = "toolStripButton4";
            this.unGroupButton.Click += new System.EventHandler(this.unGroupButton_Click);
            // 
            // shapeTree
            // 
            this.shapeTree.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shapeTree.Location = new System.Drawing.Point(585, 63);
            this.shapeTree.Name = "shapeTree";
            this.shapeTree.Size = new System.Drawing.Size(203, 322);
            this.shapeTree.TabIndex = 5;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shapeTree);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.CtrlCheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paintField)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paintField;
        private System.Windows.Forms.CheckBox CtrlCheck;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.CheckBox selectAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem GreenOption;
        private System.Windows.Forms.ToolStripMenuItem BlackOption;
        private System.Windows.Forms.ToolStripMenuItem PurpleOption;
        private System.Windows.Forms.ToolStripMenuItem BrownOption;
        private System.Windows.Forms.ToolStripMenuItem BlueOption;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton loadButton;
        private System.Windows.Forms.ToolStripButton groupButton;
        private System.Windows.Forms.ToolStripButton unGroupButton;
        private TreeView shapeTree;
    }
}

