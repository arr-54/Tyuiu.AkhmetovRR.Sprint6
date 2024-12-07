using Tyuiu.AkhmetovRR.Sprint6.Task5.V20.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task5.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public string Delitshana2(double[] result)
        {
            string text = "";
            foreach (double d in result)
            {
                if (d % 2 == 0)
                {
                    double z = Math.Round(d, 3);
                    text += z.ToString() + " ";
                }

            }
            return text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string path = @"D:\программирование C # 2024-2025\Tyuiu.AkhmetovRR.Sprint6\Sprint6Task5\InPutDataFileTask5V20.txt";
            double[] data = ds.LoadFromDataFile(path);
            dataGridView1.ColumnCount = data.Length;
            for (int i = 0; i < data.Length; i++)
            {
                dataGridView1.Rows.Add(data[i]);

            }
            string text = Delitshana2(data);
            textBox1.Text = text;
        }
    }
}