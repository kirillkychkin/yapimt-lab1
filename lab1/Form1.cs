namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private GeometryCalculations geom = new GeometryCalculations();

        private string getAboutText()
        {
            return "Программа разработана в 2025 году в рамках каурса 'Языки программирования и методы трансляции' в качестве первой лабораторной работы." + Environment.NewLine + Environment.NewLine + "Программа умеет: " + Environment.NewLine + "1. Находить сумму чисел кратных семи от нуля до тысячи" + Environment.NewLine + "2. По заданным координатам треугольника и точки вычислить, находится ли точка внутри треугольника" + Environment.NewLine + "3. Не понял что должна делать";
        }

        private int countMultiplesOfSeven()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i += 7)
            {
                sum += i;
            }
            return sum;
        }

        private void выйтиИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getAboutText());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Сумма чисел кратных семи от нуля до тысячи: " + countMultiplesOfSeven());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geom.getPointTriangleAnswer(triangleAX.Value, triangleAY.Value, triangleBX.Value, triangleBY.Value, triangleCX.Value, triangleCY.Value, pointX.Value, pointY.Value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click buton");
        }
    }
}
