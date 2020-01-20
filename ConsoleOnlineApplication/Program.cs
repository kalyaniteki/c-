using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            sellerbo boi = new sellerbo();
            itembo io = new itembo();
            BusinnesObject b = new BusinnesObject();
            while (true)
            {
                Console.WriteLine("***Welcome To e-Mart***");
                Console.WriteLine("1.Buyer");
                Console.WriteLine("2.Seller");
                Console.WriteLine("3.Admin");
                Console.WriteLine("4.Exit");

                int ch = int.Parse(Console.ReadLine());
                string username;
                string id;
                string email;
                int phn;
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("1.Login");
                        Console.WriteLine("2.Register");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("Enter name:");
                            string ur = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string pa = Console.ReadLine();
                            bool status = b.login(ur, pa);
                            if (status == true)
                            {
                                Console.WriteLine("1.search");
                                Console.WriteLine("2.display all");
                                Console.WriteLine("3.myprofile");
                                Console.WriteLine("enter your choice:");
                                int a = int.Parse(Console.ReadLine());
                                if(a==1)
                                {
                                    io.search();
                                }
                                if(a==2)
                                {
                                    io.dispaly();
                                }
                                if (a == 3)
                                {
                                    b.displaybuyer();
                                }
                                else
                                    Console.WriteLine("Invalid");
                                //boi.additem();
                                //io.dispaly();
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }


                        }
                        else if (n == 2)
                        {

                            Console.WriteLine("Enter id:: ");
                            id = (Console.ReadLine());
                            Console.WriteLine("Enter Username");
                            username = Console.ReadLine();
                            Console.WriteLine("Email:");
                            email = Console.ReadLine();
                            Console.WriteLine("Phone Number:");
                            phn = int.Parse(Console.ReadLine());
                            Console.WriteLine("Password:");
                            DateTime d = DateTime.Now;
                            var pass = Console.ReadLine();
                            //if (pass.Length < 8 || pass.Length > 16)
                            //    Console.WriteLine("Invalid Length");
                            //else if (!pass.Any(char.IsDigit))
                            //    Console.WriteLine("Needs A Digit");
                            //else if (!pass.Any(char.IsLower))
                            //    Console.WriteLine("Needs A LowerCase");
                            //else if (!pass.Any(char.IsUpper))
                            //    Console.WriteLine("Needs A UpperCase");
                            b.reg(id, username, email, phn, d, pass);


                        }
                        else
                        {
                            Console.WriteLine("Invalid");

                        }
                        break;

                    case 2:
                        Console.WriteLine("1.Login");
                        Console.WriteLine("2.Register");
                        int n1 = int.Parse(Console.ReadLine());
                        if (n1 == 1)
                        {
                            Console.WriteLine("Enter name:");
                            string ur = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string pa = Console.ReadLine();
                            bool status = b.loginseller(ur, pa);
                            if (status == true)
                            {
                                Console.WriteLine("1.additems");
                                Console.WriteLine("2.display");
                                Console.WriteLine("3.myprofile");
                                Console.WriteLine("enter choice:");
                                int v = int.Parse(Console.ReadLine());
                                if(v==1)
                                {
                                     boi.additem();
                                }
                                if(v==2)
                                {
                                    io.displayseller();
                                }
                                if (v == 3)
                                {
                                    b.displaysellerdetails();
                                }
                               
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                            }

                        }
                        else if (n1 == 2)
                        {

                            Console.WriteLine("Enter id:: ");
                            id = (Console.ReadLine());
                            Console.WriteLine("Enter Username");
                            username = Console.ReadLine();
                            Console.WriteLine("Email:");
                            email = Console.ReadLine();
                            Console.WriteLine("Phone Number:");
                            phn = int.Parse(Console.ReadLine());
                            Console.WriteLine("Password:");
                            DateTime d = DateTime.Now;
                            var pass = Console.ReadLine();
                            //if (pass.Length < 8 || pass.Length > 16)
                            //    Console.WriteLine("Invalid Length");
                            //else if (!pass.Any(char.IsDigit))
                            //    Console.WriteLine("Needs A Digit");
                            //else if (!pass.Any(char.IsLower))
                            //    Console.WriteLine("Needs A LowerCase");
                            //else if (!pass.Any(char.IsUpper))
                            //    Console.WriteLine("Needs A UpperCase");
                            b.regseller(id, username, email, phn, d, pass);
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;
                    // seller();
                    //break;
                    case 3:
                        //   Admin();
                        break;
                    case 4:
                        return;
                        
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}

