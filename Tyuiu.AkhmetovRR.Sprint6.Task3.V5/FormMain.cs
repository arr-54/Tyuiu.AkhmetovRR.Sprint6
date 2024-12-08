using Tyuiu.AkhmetovRR.Sprint6.Task3.V5.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task3.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns.Add($"Col{i + 1}", $"Column {i + 1}");
            }
            DataService ds = new DataService();
            int[,] matrix = {{ 30, -20, 7, -8, 9 },
                                   { 32, 17, -14, -7, 33 },
                                   { 19, -19, -13, 14, -20 },
                                   { 11, 30, -1, 26, 6 },
                                   { 30, -15, -20, -5, 15 }};
            int[,] result = ds.Calculate(matrix);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                object[] row = new object[result.GetLength(1)];
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    row[j] = result[i, j];
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}