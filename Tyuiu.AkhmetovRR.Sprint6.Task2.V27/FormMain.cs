using Tyuiu.AkhmetovRR.Sprint6.Task2.V27.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            double[] x = ds.GetMassFunction(-5, 5);
            foreach (double x2 in x)
            {
                dataGridView1.Rows.Add(x2);
            }
        }
    }
}