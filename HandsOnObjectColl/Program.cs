using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnObjectColl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> li = new List<employee>();
            li.Add(new employee("divya","123",8768));
            li.Add(new employee("nskj","76",6979));
            li.Add(new employee("kalyani","234",97856));
            li.Add(new employee("hamsi","675",74342));
            List<employee> highpay = li.FindAll(e => e.salary > 70000);
            foreach (employee e1 in highpay)
                Console.WriteLine(e1.ToString());
            Console.ReadLine();
        }
    }
}
