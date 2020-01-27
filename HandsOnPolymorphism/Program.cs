using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //s.draw();
            //s.draw(10);
            //s.draw(10, 20);
            //s.draw(10, 20, "deepu");
            A obj;
            obj = new C();
            // obj = new B();
            B obj1 = new B();
            obj = obj1; 
                objN.display();
            obj = new C();
            obj.display();
            //obj = new C();
            //obj.display();

        }
    }
}
