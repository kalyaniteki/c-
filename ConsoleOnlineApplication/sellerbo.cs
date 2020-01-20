using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class sellerbo
    {

        public void additem()
        {
            Console.WriteLine("enter num of products:");
            int n = int.Parse(Console.ReadLine());
            itembo ibo = new itembo();
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter Category id:");
                int cid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category Name:");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter Category Details:");
                string cdetails = Console.ReadLine();
                Console.WriteLine("Enter Sub Category id:");
                int subid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubCategory Name:");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter SubCategory Details:");
                string sdetails = Console.ReadLine();
                Console.WriteLine("Enter Item id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Item Name:");

                string itemname = Console.ReadLine();
                Console.WriteLine("Enter item price");
                int price = int.Parse(Console.ReadLine());

                subcatergory sc = new subcatergory(cid, cname, cdetails, subid, sname, sdetails);

                ibo.additem(cid, cname, cdetails, subid, sname, sdetails, id, price, itemname, sc);
            }
            


        }
    }
}
