namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            выйтиИзПрограммыToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            triangleAX = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            triangleAY = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            triangleBX = new NumericUpDown();
            label8 = new Label();
            triangleBY = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            triangleCX = new NumericUpDown();
            label11 = new Label();
            triangleCY = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            pointX = new NumericUpDown();
            label14 = new Label();
            pointY = new NumericUpDown();
            button2 = new Button();
            label15 = new Label();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)triangleAX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triangleAY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triangleBX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triangleBY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triangleCX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)triangleCY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointY).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выйтиИзПрограммыToolStripMenuItem });
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // выйтиИзПрограммыToolStripMenuItem
            // 
            выйтиИзПрограммыToolStripMenuItem.Name = "выйтиИзПрограммыToolStripMenuItem";
            выйтиИзПрограммыToolStripMenuItem.Size = new Size(193, 22);
            выйтиИзПрограммыToolStripMenuItem.Text = "Выйти из программы";
            выйтиИзПрограммыToolStripMenuItem.Click += выйтиИзПрограммыToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(311, 15);
            label1.TabIndex = 1;
            label1.Text = "1. Найти сумму чисел кратных семи от нуля до тысячи";
            // 
            // button1
            // 
            button1.Location = new Point(369, 39);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 2;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(587, 15);
            label2.TabIndex = 3;
            label2.Text = "2. По заданным координатам треугольника и точки вычислить, находится ли точка внутри треугольника";
            // 
            // triangleAX
            // 
            triangleAX.Location = new Point(48, 123);
            triangleAX.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            triangleAX.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            triangleAX.Name = "triangleAX";
            triangleAX.Size = new Size(120, 23);
            triangleAX.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 105);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 5;
            label3.Text = "Точка A треугольника";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 125);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 6;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 125);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 7;
            label5.Text = "Y:";
            // 
            // triangleAY
            // 
            triangleAY.Location = new Point(215, 123);
            triangleAY.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            triangleAY.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            triangleAY.Name = "triangleAY";
            triangleAY.Size = new Size(120, 23);
            triangleAY.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 159);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 9;
            label6.Text = "Точка B треугольника";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 187);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 10;
            label7.Text = "X:";
            // 
            // triangleBX
            // 
            triangleBX.Location = new Point(48, 185);
            triangleBX.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            triangleBX.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            triangleBX.Name = "triangleBX";
            triangleBX.Size = new Size(120, 23);
            triangleBX.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 187);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 12;
            label8.Text = "Y:";
            // 
            // triangleBY
            // 
            triangleBY.Location = new Point(215, 185);
            triangleBY.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            triangleBY.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            triangleBY.Name = "triangleBY";
            triangleBY.Size = new Size(120, 23);
            triangleBY.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 223);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 14;
            label9.Text = "Точка C треугольника";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 251);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 15;
            label10.Text = "X:";
            // 
            // triangleCX
            // 
            triangleCX.Location = new Point(48, 249);
            triangleCX.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            triangleCX.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            triangleCX.Name = "triangleCX";
            triangleCX.Size = new Size(120, 23);
            triangleCX.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(186, 251);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 17;
            label11.Text = "Y:";
            // 
            // triangleCY
            // 
            triangleCY.Location = new Point(215, 249);
            triangleCY.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            triangleCY.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            triangleCY.Name = "triangleCY";
            triangleCY.Size = new Size(120, 23);
            triangleCY.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 286);
            label12.Name = "label12";
            label12.Size = new Size(110, 15);
            label12.TabIndex = 19;
            label12.Text = "Координаты точки";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 313);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 20;
            label13.Text = "X:";
            // 
            // pointX
            // 
            pointX.Location = new Point(48, 311);
            pointX.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            pointX.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            pointX.Name = "pointX";
            pointX.Size = new Size(120, 23);
            pointX.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(186, 313);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 22;
            label14.Text = "Y:";
            // 
            // pointY
            // 
            pointY.Location = new Point(215, 311);
            pointY.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            pointY.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            pointY.Name = "pointY";
            pointY.Size = new Size(120, 23);
            pointY.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(25, 340);
            button2.Name = "button2";
            button2.Size = new Size(79, 23);
            button2.TabIndex = 24;
            button2.Text = "Вычислить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 378);
            label15.Name = "label15";
            label15.Size = new Size(298, 15);
            label15.TabIndex = 25;
            label15.Text = "3.  Найти и вывести максимальное количество тезок";
            // 
            // button3
            // 
            button3.Location = new Point(29, 405);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 26;
            button3.Text = "Найти тезок";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label15);
            Controls.Add(button2);
            Controls.Add(pointY);
            Controls.Add(label14);
            Controls.Add(pointX);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(triangleCY);
            Controls.Add(label11);
            Controls.Add(triangleCX);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(triangleBY);
            Controls.Add(label8);
            Controls.Add(triangleBX);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(triangleAY);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(triangleAX);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Лабораторная 1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)triangleAX).EndInit();
            ((System.ComponentModel.ISupportInitialize)triangleAY).EndInit();
            ((System.ComponentModel.ISupportInitialize)triangleBX).EndInit();
            ((System.ComponentModel.ISupportInitialize)triangleBY).EndInit();
            ((System.ComponentModel.ISupportInitialize)triangleCX).EndInit();
            ((System.ComponentModel.ISupportInitialize)triangleCY).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem выйтиИзПрограммыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label label1;
        private Button button1;
        private Label label2;
        private NumericUpDown triangleAX;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown triangleAY;
        private Label label6;
        private Label label7;
        private NumericUpDown triangleBX;
        private Label label8;
        private NumericUpDown triangleBY;
        private Label label9;
        private Label label10;
        private NumericUpDown triangleCX;
        private Label label11;
        private NumericUpDown triangleCY;
        private Label label12;
        private Label label13;
        private NumericUpDown pointX;
        private Label label14;
        private NumericUpDown pointY;
        private Button button2;
        private Label label15;
        private Button button3;
    }
}
