using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPartial
{
    partial class ClassA
      
        {

        
        partial void setdata();
        public void print()
        {
            Console.WriteLine("class A printing");
            setdata();
        }

    }
    partial class ClassB

    {


        partial void setdata1();
        public void print1()
        {
            Console.WriteLine("class B printing");
            setdata1();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.print();
            ClassB b = new ClassB();
            b.print1();
        }
    }
}
