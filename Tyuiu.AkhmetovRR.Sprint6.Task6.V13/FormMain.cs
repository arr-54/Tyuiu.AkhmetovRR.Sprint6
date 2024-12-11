using Tyuiu.AkhmetovRR.Sprint6.Task6.V13.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                DataService ds = new DataService();
                TextBoxOut.Text = ds.CollectTextFromFile(path);
            }
        }

        private void TextBoxOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
