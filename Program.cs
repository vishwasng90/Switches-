using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            switch (day)
            {
                case 6:
                    Console.WriteLine("It's Sat means weeken");
                    break;
                case 7:
                    Console.WriteLine("It's Sun means weeken");
                    break;
                    default:
                    Console.WriteLine("It's not weekend");
                    break;

            }
            Console.ReadLine();

        }
    }
}
