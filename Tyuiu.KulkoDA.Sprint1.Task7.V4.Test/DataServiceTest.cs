using Tyuiu.KulkoDA.Sprint1.Task7.V4.Lib;

namespace Tyuiu.KulkoDA.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.51,res);
        }
    }
}