using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            
            Console.WriteLine("加總="+ (meal_cost + tip_percent + tax_percent));
        }
    }
}
