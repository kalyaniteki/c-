using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnFactory
{
    class Program
    {  
    interface Ifactory
    {
        void manufacture(int cnt);
    }
    class Bike : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("bike manufacturing no: " + cnt);
        }
    }
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Car manufacturing no: " + cnt);
        }
    }
     abstract class VehicleFactory
        {
        public abstract Ifactory generateVehicles(string type);
        }
    class ConcreteVehicleFactory:VehicleFactory
    {
        public override Ifactory generateVehicles(string type)
        {
           
            if(type== "Bike")
            {
                return new Bike();
                
            }
            else
                return new Car(); 
               
               // default:return Console.WriteLine("canot produce this product");
            
            //throw new NotImplementedException();
        }
    }
    
        static void Main(string[] args)
        {
        VehicleFactory v1 = new ConcreteVehicleFactory();
        Ifactory myveh = v1.generateVehicles("bike");
        myveh.manufacture(10);
        myveh = v1.generateVehicles("car");
        myveh.manufacture(20);
        }
    }
}
