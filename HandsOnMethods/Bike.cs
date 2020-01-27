using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Bike
    {
        string name;
        string color;
        public void StartEngine()
        {
            Console.WriteLine("Bike Started at " + DateTime.Now.Hour);
        }
        public void FillGas(int litre)
        {
            Console.WriteLine("bike filled with " + litre + "litre");
        }
        public int Travel(int distance,int speed)
        {
            int time = (int)(distance / speed);
            Console.WriteLine("you will reach your destination in " + time);
            return time;
        }
    }
}
