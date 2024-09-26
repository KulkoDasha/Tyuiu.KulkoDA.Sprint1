using Tyuiu.KulkoDA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.KulkoDA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string t = "HelloSdf";
            bool res = ds.CheckHello(t);
            Assert.AreEqual(true, res);
        }
    }
}