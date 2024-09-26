using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KulkoDA.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            string c = value;
            bool k = c.Contains("Hello");
            return k;
           
        }
    }
}
