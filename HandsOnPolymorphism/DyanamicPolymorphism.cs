using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPolymorphism
{
  abstract  class A
    {
        //public virtual void display()
        //{
        //    Console.WriteLine("display A Class details");
        //}
        public abstract void display();
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display B Class details");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("display C Class details");
        }
    }
}
