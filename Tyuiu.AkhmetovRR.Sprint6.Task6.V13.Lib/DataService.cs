using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] lines = str.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string result = "";
            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length > 1)
                {
                    result += words[words.Length - 2] + Environment.NewLine;
                }
            }
            return result;
        }
    }
}