using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVehicleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //vehicle v = new vehicle("red");
            bus b = new bus();
            car c = new car();
           
            b.start();
            b.drive();
            b.stop();
            b.fillfuel();
            c.start();
            c.run();
            c.fillfuel();
            c.stop();
            Console.ReadKey();


        }
    }   
 }
