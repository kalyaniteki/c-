using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDeligate
{
    class Program
    {
        public delegate void delegatepointer();
        public delegate double calAreapointer(double x);
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Program p = new Program();
            delegatepointer mydelegate = p.print;
            mydelegate();
            mydelegate += p.display;
            // mydelegate();
            mydelegate -= p.print;
            mydelegate();


            calAreapointer c = calculate.calArea;
            double area = c(56);
            Console.WriteLine(area);
            c += calculate.calArea1;
            double area1 = c(56);
            Console.WriteLine(area1);
            Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("welcome to delegate");
        }
        public void display()
        {
            Console.WriteLine("multicast delegate");
        }
    }
}
