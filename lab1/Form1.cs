namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getAboutText()
        {
            return "��������� ����������� � 2025 ���� � ������ ������ '����� ���������������� � ������ ����������' � �������� ������ ������������ ������." + Environment.NewLine + Environment.NewLine + "��������� �����: " + Environment.NewLine + "1. �������� ����� ����� ������� ���� �� ���� �� ������" + Environment.NewLine + "2. �� �������� ����������� ������������ � ����� ���������, ��������� �� ����� ������ ������������" + Environment.NewLine + "3. �� ����� ��� ������ ������";
        }

        private int countMultiplesOfSeven()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i+=7)
            {
                sum += i;
            }
            return sum;
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getAboutText());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("����� ����� ������� ���� �� ���� �� ������: " + countMultiplesOfSeven());
        }
    }
}
