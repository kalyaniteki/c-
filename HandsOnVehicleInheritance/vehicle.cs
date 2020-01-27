using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVehicleInheritance
{
     abstract class vehicle
    {
       protected string color;
        public vehicle()
        {
            this.color = "black";
            Console.WriteLine("constructor from vehicle");
        }
        public vehicle(string clr)
        {
            this.color = clr;
            Console.WriteLine("parameterized");
        }

        public abstract void fillfuel();
        public virtual void start()
        {
            Console.WriteLine("strated");

        }
        public void stop()
        {
            Console.WriteLine("stopped");

        }

    }
    class bus : vehicle
    {
        int seating;
        int speed;
        
        public bus():base("pink")
        {
            this.seating = 20;
            this.speed = 10;
            
            Console.WriteLine("constructor from bus");
        }

        public override void fillfuel()
        {
            Console.WriteLine("desil is filled");
        }
        public virtual void start()
        {
            Console.WriteLine(" bus strated");

        }

        public void drive()
        {
            Console.WriteLine(color+"bus is running at speed "+speed+"with passengers"+seating);
        }

    }
    class car : vehicle
    {
       
        int speed;
        public car()
        {
            
            this.speed = 11;
            Console.WriteLine("constructor from car");
        }
        public virtual void start()
        {
            Console.WriteLine("car strated");

        }
        public override void fillfuel()
        {
            Console.WriteLine("petrol is filled");
        }
        public void run()
        {
            Console.WriteLine(color + "car is running at speed " + speed );
        }

    }
}
