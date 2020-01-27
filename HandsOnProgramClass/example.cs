using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProgramClass
{
    class example
    {
        private int roll=5;
        private string name;
        private int sem = 1;
        private int marks = 50;
        public int Rollno
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Sem { get; set; }
         public int Marks
        {
            get
            {
                return  marks;
            }
        }
        public example()//default constructor
        {
           this.roll= 3;
            this.name = "kalyani";
            this.sem = 1;
            
            
        }
        public example(int roll,string name,int sem)
        {

            this.roll = roll;
            this.name = name;
            this.sem = sem;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine(this.roll+ "\n" + this.name + "\n" + this.sem);

            Console.WriteLine("student details are displayed");
        }
        

    }
}
