using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class vehicle
    {
        string color;
        public void strat()
        {
            Console.WriteLine("vehicle strated");

        }
        public void stop()
        {
            Console.WriteLine("vehicle stopped");

        }

    }
    class bus:vehicle
    {
        int seating;
        int speed;
        public void run()
        {
            Console.WriteLine("bus is running");
        }

    }
    class car:vehicle
    {
        int seating;
        int speed;
        public void run()
        {
            Console.WriteLine("car is running");
        }

    }
}
