using Tyuiu.AkhmetovRR.Sprint6.Task4.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task4.V24
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
            textBox1.Text = string.Join(",", x);
            string path = "OutPutDataFileTask4V24.txt";
            File.WriteAllText(path, textBox1.Text);
        }
    }
}
