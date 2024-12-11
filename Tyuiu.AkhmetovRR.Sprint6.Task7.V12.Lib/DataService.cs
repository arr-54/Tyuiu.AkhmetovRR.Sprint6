using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = 10;
            int columns = 10;

            int[,] matrix = new int[rows, columns];
            for (int i  = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i,j] = int.Parse(values[j]);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++) 
            { 
                if (matrix[i,8] != 10)
                {
                    matrix[i, 8] = 0; 
                }
            }
            return matrix;
        }
    }
}
