using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            for(int r=0;r<5;r++)
            {
                for(int c=0;c<3;c++)
                {
                    marks[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(" "+marks[r, c]);
                }
            }
            int high = 0;

            for (int c=0;c<3;c++)
            {
                
                for (int r = 0; r < 5; r++)
                {
                    if (r == 0)
                        high = marks[r, c];
                    else if(marks[r,c] > high)
                        high = marks[r,c];

                }

                Console.WriteLine(high);
            }
           
            Console.ReadKey();
            /* foreach(int x in marks)
             {
                 Console.WriteLine(x);

             }*/



        }
    }
}
