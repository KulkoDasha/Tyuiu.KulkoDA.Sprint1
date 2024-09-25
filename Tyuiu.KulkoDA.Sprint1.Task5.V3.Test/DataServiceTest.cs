using Tyuiu.KulkoDA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.KulkoDA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int f = 123456;
            var res = ds.Calculate(f);
            Assert.AreEqual(4, res);
        }
    }
}