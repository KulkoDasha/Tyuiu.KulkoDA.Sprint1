using Tyuiu.KulkoDA.Sprint1.Task3.V6.Lib;


namespace Tyuiu.KulkoDA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            var res = ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(74.04, res);
        }
    }
}