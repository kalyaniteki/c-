using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton s1 = new singleton();
            singleton s1 = singleton.GetInstance;
            s1.display("s1 object");
            // singleton s2 = new singleton();
            singleton s2= singleton.GetInstance;
            s2.display("s2 object");

        }
    }
}
