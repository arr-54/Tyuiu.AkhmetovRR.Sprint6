using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            
            int[][] rows = new int[matrix.GetLength(0)][];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rows[i] = new int[matrix.GetLength(0)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rows[i][j] = matrix[i, j];

                }
            }
            Array.Sort(rows, (a, b) => a[2].CompareTo(b[2]));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[i][j];

                }
            }
            return matrix;
        }
    }
}