using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollege
{
    class student
    {
        static string collegename;
        int rollno;
        string name;
        int cls;
        int sem;
        string branch;
        int[] markss=new int [5];
        public static void clg()
        {
            collegename = "SVEC";
        }
        public student(int rollno,string name,int cls,int sem,string branch,int[] markss)
        {
            this.rollno = rollno;
            this.name = name;
            this.cls = cls;
            this.sem = sem;
            this.branch = branch;
            this.markss = markss;
            int avg=0;
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                sum = sum + markss[j];
                avg = sum / 5;
            }
            for (int i = 0; i<= 5; i++)
            { 

                if (markss[i] < 35)
                {
                    Console.WriteLine("fail");
                    break;
                }

                else if (markss[i] > 35)
                {
                     if( avg < 50)
                    Console.WriteLine("fail");
                    break;
                }
                else if (avg > 50)
                {
                    Console.WriteLine("pass");
                    break;
                }



            }    
        }
        public void show()
        {
            Console.WriteLine("num" + this.rollno+"\n" + "name" + this.name + "\n" + "class" + cls + "\n" + "sem" + sem + "\n" + "branch" + branch + "\n");
        }

    }
}
