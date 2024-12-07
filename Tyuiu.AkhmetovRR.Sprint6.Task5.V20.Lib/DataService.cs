using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task5.V20.Lib
{
    public class DataService : ISprint6Task5V20
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] text = File.ReadAllLines(path);
            double[] result = Array.ConvertAll(text, str => Convert.ToDouble(str));
            List<double> myList = new List<double>();
            int count = 0;
            foreach (double d in result)
            {
                if (d % 2 == 0)
                {
                    count++;
                    myList.Add(d);
                }
            }
            double[] doubles = new double[count];
            for (int i = 0; i < doubles.Length; i++)
            {
                doubles[i] = Math.Round(myList[i],3);
            }
            return doubles;
        }
    }
}