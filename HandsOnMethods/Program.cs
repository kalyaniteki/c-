using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike Enfield = new Bike();
            Enfield.StartEngine();
            Enfield.FillGas(10);
            Enfield.Travel(100,50);
            Console.ReadLine();

        }
    }
}
