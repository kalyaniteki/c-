using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractAssignment
{
  abstract  class Student
    {
        protected string name;
        protected int StudentId;
        protected float grade;
      public abstract Boolean Ispassed(float grade);

    }
    class Undergrade : Student
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade >= 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class Graduate : Student
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade >= 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
