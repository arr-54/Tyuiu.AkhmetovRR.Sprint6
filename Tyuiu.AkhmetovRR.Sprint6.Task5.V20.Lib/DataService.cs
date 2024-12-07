using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task5.V20.Lib
{
    public class DataService : ISprint6Task5V20
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] text = File.ReadAllLines(path);
            double[] result = Array.ConvertAll(text, str => Convert.ToDouble(str));
            return result;
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
    }
}