using Tyuiu.AkhmetovRR.Sprint6.Task1.V5.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task1.V5.Test
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

            array[0] = 8.04;
            array[1] = 6.68;
            array[2] = 4.84;
            array[3] = 1.76;
            array[4] = 0.45;
            array[5] = 0.5;
            array[6] = -0.87;
            array[7] = -2.41;
            array[8] = -3.88;
            array[9] = -6.83;
            array[10] = -8.88;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array, res);
        }
    }
}