using System.Numerics;
using Tyuiu.AkhmetovRR.Sprint6.Task7.V12.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Âûבונטעו פאיכ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(path);
                if (lines.Length == 0)
                {
                    MessageBox.Show("Îרטבךא");
                    return;
                }
                dataGridViewIn.Rows.Clear();
                dataGridViewIn.Columns.Clear();
                string[] firstrow = lines[0].Split(';');
                for (int i = 0; i < firstrow.Length; i++)
                {
                    dataGridViewIn.Columns.Add($"Column{i + 1}", $"Column{i + 1}");
                }
                foreach (string line in lines)
                {
                    string[] row = line.Split(';');
                    dataGridViewIn.Rows.Add(row);
                }
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = openFileDialog.FileName;
            DataService ds = new DataService();
            int[,] matrix = ds.GetMatrix(path);
            int rowcount = 10;
            int columncount = 10;
            for (int i = 0; i < columncount; i++)
            {
                dataGridViewOut.Columns.Add($"Column{i + 1}", $"Column{i + 1}");
            }
            for (int i = 0;i < rowcount ; i++) 
            {
                object[] newmatrix = new object[columncount];
                for (int j = 0;j < columncount; j++) 
                {
                    newmatrix[j] = matrix[i, j];
                }
                dataGridViewOut.Rows.Add(newmatrix);
            }
        }
    }
}