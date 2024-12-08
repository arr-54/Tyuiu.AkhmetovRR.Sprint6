using Tyuiu.AkhmetovRR.Sprint6.Task0.V10.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task0.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = text2.Text;
            int y = int.Parse(x);
            DataService ds = new DataService();

            double result = ds.Calculate(y);
            textOutPut.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textOutPut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
