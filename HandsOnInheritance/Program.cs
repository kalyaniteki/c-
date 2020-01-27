using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent pa = new Parent();
            Child ch = new Child();
            grandchild gc = new grandchild();
            demoprotected.Exchild ex = new demoprotected.Exchild();
            


            pa.getvalues(12, "c#");
            pa.display();
            ch.getvalues(11, "java");
            ch.display();
            ch.cal(23);
            gc.getvalues(10, "html");
            gc.display();
            gc.cal(12);
            gc.mul(2);
            ex.getvalues(666, "hjh");
            ex.Exdisplay();
            Console.ReadKey();

        }
    }
}
