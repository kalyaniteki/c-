using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgramClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* class1 student = new class1();
             student.AcceptStudentDetails();
             student.DisplayStudentDetails();
            Console.ReadKey();
            example stu1 = new example();
             Console.WriteLine(stu1.Rollno);
             stu1.Rollno = 23;
             Console.WriteLine(stu1.Rollno);
             Console.WriteLine(stu1.Sem);
             stu1.Sem = 23;
             Console.WriteLine(stu1.Sem);
             Console.ReadKey();
             example stu1 = new example();
             Console.WriteLine(stu1.Marks);*/
            example stu1 = new example();
            stu1.DisplayStudentDetails();
            example stu2 = new example(456,"kkkk",34);
            stu2.DisplayStudentDetails();
            example stu3 = new example(45678890, "aaaaaa", 777);
            stu3.DisplayStudentDetails();
            Console.ReadKey();

            
        }
    }
}
