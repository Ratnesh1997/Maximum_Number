using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("_______Program________");
            Console.WriteLine("Enter no to find maximum among Three Number ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a>b & a>c)
            {

                Console.WriteLine("A is maximum {0}", a);
            }
            if (b > c & b > a)
            {

                Console.WriteLine("A is maximum {0}", b);
            }
            if (c > b & c > a)
            {

                Console.WriteLine("A is maximum {0}", c);
            }
            Console.ReadKey();
        }
    }

    }
    

