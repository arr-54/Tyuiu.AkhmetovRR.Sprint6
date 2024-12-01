using Tyuiu.AkhmetovRR.Sprint6.Task4.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task4.V24.Test
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

            array[0] = 7.83;
            array[1] = 6.22;
            array[2] = 6.36;
            array[3] = 6.96;
            array[4] = -0.52;
            array[5] = 0;
            array[6] = -3.3;
            array[7] = -5.53;
            array[8] = -6.25;
            array[9] = -6.63;
            array[10] = -8.24;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array, res);
        }
    }
}