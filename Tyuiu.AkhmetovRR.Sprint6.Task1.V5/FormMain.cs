using System.Security.Cryptography.X509Certificates;
using Tyuiu.AkhmetovRR.Sprint6.Task1.V5.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            double[] x = ds.GetMassFunction(-5,5);
            string y = string.Join(" ", x);
            textBox1.Text = y;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
