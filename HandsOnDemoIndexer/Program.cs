﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDemoIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.Year = 2019;
            c[0] = "maruthi";
            c[1] = "benz";
            c[2] = "honda";
            c.display();

        }
    }
}
