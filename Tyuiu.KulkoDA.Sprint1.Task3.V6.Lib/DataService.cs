
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KulkoDA.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            double x = (gasFlow * distance) / 100;
            double y = x * gasPrice * 2;
            return Math.Round(y,2);
        }
    }
}
