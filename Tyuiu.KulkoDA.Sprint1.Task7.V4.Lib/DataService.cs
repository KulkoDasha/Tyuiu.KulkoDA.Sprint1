using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KulkoDA.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double one = x + (x * x) / 4;
            double two = x - y / one;
            double three = Math.Abs((y - Math.Sqrt(Math.Abs(x))) * two);
            return Math.Round(Math.Log(three, Math.E),2);
        }
    }
}
