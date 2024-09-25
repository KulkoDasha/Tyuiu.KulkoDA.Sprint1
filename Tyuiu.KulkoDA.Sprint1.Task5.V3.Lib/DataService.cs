using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.KulkoDA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string c = Convert.ToString(k);
            string v = c.Substring(c.Length - 4, c.Length - 4);
            return Convert.ToInt32(v.Substring(1));
        }
    }
}
