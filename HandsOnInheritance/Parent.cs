using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Parent
    {
       protected int a;
        protected string b;

        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }

        public void getvalues(int x,string y)
        {
            this.A = x;
            this.B = y;

        }
        public void display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
    class Child:Parent
    {
       protected int c;
        public void cal(int d)
        {
            c = this.A + d;
            Console.WriteLine(c);

        }
    }
    class grandchild:Child
    {
        int d;
        public void mul(int num)
        {
            this.d = num;
            Console.WriteLine(this.d * this.c * this.a);
        }

    }
}
namespace demoprotected
{
    class Exchild: HandsOnInheritance.Parent
    {
        public void Exdisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}
