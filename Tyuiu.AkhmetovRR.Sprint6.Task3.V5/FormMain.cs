using System.Drawing.Text;
using Tyuiu.AkhmetovRR.Sprint6.Task3.V5.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task3.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int[,] matrix = {{ 30, -20, 7, -8, 9 },
                                   { 32, 17, -14, -7, 33 },
                                   { 19, -19, -13, 14, -20 },
                                   { 11, 30, -1, 26, 6 },
                                   { 30, -15, -20, -5, 15 }};

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            
            int[,] result = ds.Calculate(matrix);
            LoadDateGrid(result);
        }
        private void LoadDateGrid(int [,] matrix)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}