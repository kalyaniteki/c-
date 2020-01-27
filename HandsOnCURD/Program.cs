using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCURD
{
    class Program
    {
        static void Main(string[] args)
        {
            // employee e = new employee();
            List<employee> elist = new List<employee>();
           

           
              
        


                while (true)
                {
                Console.WriteLine("menu");
                Console.WriteLine("1.Insert employee details");
                Console.WriteLine("2.display all employee details");
                Console.WriteLine("3.update employeedetails based on id");
                Console.WriteLine("delete a specific employee whos id is given");
                Console.WriteLine("choice");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                    {
                        Console.WriteLine("empid");
                        int id = int.Parse(Console.ReadLine());


                        Console.WriteLine("empname");
                        string name = Console.ReadLine();
                        Console.WriteLine("designation");
                        string desig = Console.ReadLine();
                        elist.Add(new employee(id, name, desig));




                    }

                    else if (n == 2)
                    {
                        foreach (employee j in elist)
                        {
                            Console.WriteLine(j.ToString());
                        }
                    }
                    else if (n == 3)
                    {
                        Console.WriteLine("empid");
                        int id = int.Parse(Console.ReadLine());

                        foreach (employee f in elist)
                        {
                            if (f.empid == id)
                            {

                                string name = Console.ReadLine();
                                string desig = Console.ReadLine();
                                f.name = name;
                                f.desig = desig;
                            }
                           
                        }
                    foreach (employee j in elist)
                    {
                        Console.WriteLine(j.ToString());
                    }

                  }
                    else if (n == 4)
                    {
                        Console.WriteLine("empid");
                        int d = int.Parse(Console.ReadLine());
                        foreach (employee l in elist)
                        {
                            if (l.empid == d)
                            {
                                Console.WriteLine(elist.Remove(l));
                            }
                        }
                        //foreach (employee j in elist)
                        //{
                        //    Console.WriteLine(j.ToString());
                        //}


                    }
                    else
                        Console.WriteLine("invalid");
                }


           
        }
    }
}

