using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int high = arr[0];
            int low = arr[0];

            for(int j=0;j<arr.Length;j++)
            {
                if(arr[j]>high)
                {
                    high = arr[j];
                }
                if(arr[j]<low)
                {
                    low = arr[j];
                }
            }
            Console.WriteLine("maximum num is" + high);
            Console.WriteLine("minimum num is" + low);

            Console.ReadKey();
        }
    }
}
