using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCallBy
{
    class Calculator
    {
        int val1;
        int val2;

        public int Val1 { get => val1; set => val1 = value; }
        public int Val2 { get => val2; set => val2 = value; }

        public Calculator()
        {
            
        }
        public Calculator(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public int Add(int n1,int n2)
        {
            return n1 + n2;
            //Console.WriteLine(n1 + n2);
        }
        /* public void Swap(int v1,int v2)
         {
             int temp;
             temp = v1;
             v1 = v2;
             v2 = temp;
             Console.WriteLine(v1+" "+v2);
             Console.ReadKey();

         }*/
        public void Swap(ref int v1,ref int v2)
        {
            int temp;
            temp = v1;
            v1 = v2;
            v2 = temp;
            Console.WriteLine( v1 +" "+v2);
            Console.ReadKey();

        }
        public int Substract(int a,int b,out int res)
        {
            res= a-b;
            return res;
        }
    }
}
