using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWork
{
    class jagged
    {
        static void Main(String[] args)
        {


            int[][] arr = new int[2][];
            for (int i = 0; i <2; i++)
            {
                Console.WriteLine("enter size" + (i + 1));
                int size = int.Parse(Console.ReadLine());
                arr[i] = new int[size];
                
            }
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    arr[r][c] = int.Parse(Console.ReadLine());
                   
                }
                
            }

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    Console.Write(" " + arr[r][c]);

                }
                Console.WriteLine();
            }
            
            int sum = 0;

            for(int k=0;k<=2;k++)
            {
                for (int c = 0; c <=arr[k].Length; c++)
                {
                    if (arr[k][c] == arr[k + 1][c + 1])
                    {
                        sum = sum + arr[k][c];
                    }
                    else
                        Console.WriteLine("no common elements found");
                }


            }
            Console.WriteLine(sum);



            Console.ReadKey();

        }

    }
}
