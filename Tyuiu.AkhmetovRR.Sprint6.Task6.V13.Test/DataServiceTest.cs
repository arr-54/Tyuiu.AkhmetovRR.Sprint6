using Tyuiu.AkhmetovRR.Sprint6.Task6.V13.Lib;

namespace Tyuiu.AkhmetovRR.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = "EovFJ da WLCdQb mGVUEyeWqYrqAOaI\r\nVud ijiH W ehWGn qqAAJvRJjfODPAeE\r\nRgdW M QIK HDDYrXH McJC DBjgLMGsdo\r\nKwQBrOM upBSzre lhTKeblSG PbHxb\r\nEwyq YGVyY viZ FKxGs lLZdQ dXbj ERKy";
            string y = "WLCdQb\r\nehWGn\r\nMcJC\r\nlhTKeblSG\r\ndXbj\r\n";
            string z = ds.CollectTextFromFile(x,x);
            Assert.AreEqual(y, z);
        }
    }
}