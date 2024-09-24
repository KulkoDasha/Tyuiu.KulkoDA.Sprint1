using Tyuiu.KulkoDA.Sprint1.Task4.V5.Lib;

namespace Tyuiu.KulkoDA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}