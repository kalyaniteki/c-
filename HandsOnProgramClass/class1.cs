using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgramClass
{
    class class1
    {
        int rollno;
        string name;
        int sem;
        string branch;
        int marks;
        public void AcceptStudentDetails()
        {
            Console.WriteLine("enter rollno");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter sem");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
            branch = Console.ReadLine();
            Console.WriteLine("enter marks");
            marks = int.Parse(Console.ReadLine());
            Console.WriteLine("student details are accepted");
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine(this.rollno+"\n"+this.name+"\n"+this.sem+"\n"+this.branch+"\n"+this.marks+"\n");
           
            Console.WriteLine("student details are displayed");
        }
        
    }
}
