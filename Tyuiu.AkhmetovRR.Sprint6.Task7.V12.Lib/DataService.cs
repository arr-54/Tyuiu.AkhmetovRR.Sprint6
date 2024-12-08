using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(int[,] matrix)
        {
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
