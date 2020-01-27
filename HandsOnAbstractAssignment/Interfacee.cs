using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractAssignment
{
    interface Istudent
    {
      // public int studentId;
     //public   string name;
       int StudentId { get; set; }
        string Name { get; set; }
        void showdetails();
    }
    class Dayscholar : Istudent
    {
        int StudentId;
        string Name;
         //int Istudent.StudentId { get; set; }
         //string Istudent.Name { get; set; }
        int Istudent.StudentId { get { return StudentId; } set { StudentId = value; } }
        string Istudent.Name { get { return Name; } set { Name = value; } }
       // string Name { get; set; }
        public  virtual void  showdetails()
        {
            Console.WriteLine(this.StudentId+this.Name);
        }
    }
    class Resident : Istudent
    {
        int StudentId;
        string Name;
        int Istudent.StudentId { get; set; }
        string Istudent.Name { get; set; }
        public virtual void showdetails()
        {
            Console.WriteLine(this.StudentId+this.Name);
        }
    }


}
