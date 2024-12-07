using Tyuiu.AkhmetovRR.Sprint6.Task5.V20.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] array = { -17, 0, 12, -14.32, 5, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 35, -9, 13.83, 12.76, 8.86, 0, -1.49, -7 };
            string path = @"D:\программирование C # 2024-2025\Tyuiu.AkhmetovRR.Sprint6\Sprint6Task5\InPutDataFileTask5V20.txt";
            double[] array2 = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(array, array2);
        }
    }
}