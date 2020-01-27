using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPolymorphism
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("A SHAPE CAN BE DRAWN");
        }
        public void draw(int l)
        {
            Console.WriteLine("A SQUARE CAN BE DRAWN");
        }
        public void draw(int l, int w){
            Console.WriteLine("A RECTANGLE CAN BE DRAWN");
            }
        public void draw(int l,int w,string name)
        {
            Console.WriteLine(name + "CAN BE DRAWN");
        }
    }
}
