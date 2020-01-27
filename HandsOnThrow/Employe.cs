using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnThrow
{
    class idException:Exception
    {
        public  idException(string s):base(s)
        {

        }
    }
    class Employe:Exception
    {
        public Employe(string s) : base(s)
        {

        }
        string name;
        int id;
     public   void show()
        {
            try
            {
                name = Console.ReadLine();
                id = int.Parse(Console.ReadLine());
                if (id < 5)
                {
                    throw new Employe("cant allow less than five");
                }
            }
            catch (Employe e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
