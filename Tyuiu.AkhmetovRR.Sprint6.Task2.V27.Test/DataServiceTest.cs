using Tyuiu.AkhmetovRR.Sprint6.Task2.V27.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = 11;
            double[] array;
            array = new double[len];

            array[0] = -27.22;
            array[1] = -22.25;
            array[2] = -16.66;
            array[3] = -11.04;
            array[4] = -6.13;
            array[5] = -3.0;
            array[6] = 4.84;
            array[7] = 8.86;
            array[8] = 14.43;
            array[9] = 20.18;
            array[10] = 25.24;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array, res);
        }
    }
}