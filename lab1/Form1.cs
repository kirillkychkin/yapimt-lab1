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
            return "Программа разработана в 2025 году в рамках каурса 'Языки программирования и методы трансляции' в качестве первой лабораторной работы." + Environment.NewLine + Environment.NewLine + "Программа умеет: " + Environment.NewLine + "1. Находить сумму чисел кратных семи от нуля до тысячи" + Environment.NewLine + "2. По заданным координатам треугольника и точки вычислить, находится ли точка внутри треугольника" + Environment.NewLine + "3. 3.По заданному списку группы из текстового файла найти максимальное количество тезок";
        }

        private List<String> getGroupList()
        {
            List<String> groupList = new List<String>();

            StreamReader sr = new StreamReader("C:\\list.txt"); 
            String line = sr.ReadLine();
            while (line != null)
            {
                groupList.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return groupList;
        }

        private String getNamesakes()
        {
            List<String> groupList = getGroupList();
            Dictionary<string, int> namesakes = new Dictionary<string, int>();
            foreach (var item in groupList)
            {
                try
                {
                    namesakes.Add(item.Split(' ')[1],1);
                }
                catch (ArgumentException)
                {
                    namesakes[item.Split(' ')[1]] += 1;
                }
            }
            String res = "Самое часто встречающееся имя: \n";
            int maxMetName = 0;
            foreach (var item in namesakes)
               if(item.Value > maxMetName)
                    maxMetName = item.Value;
            foreach (var item in namesakes)
                if (item.Value == maxMetName)
                    res += "Имя: " + item.Key + " Раз: " + item.Value + "\n";
            return res;
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
            MessageBox.Show(getNamesakes());
        }
    }
}
