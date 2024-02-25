using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runstate = true;
            while (runstate)
            {
                Console.WriteLine("enter a number to execute the operation \n 1. addition \n 2. multiplication\n");
                int operation = int.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    ExecAdd();
                }
                else if (operation == 2)
                {
                    ExecMulti();
                }
                else
                {
                    runstate = false;
                    Console.WriteLine("error");
                }
            }

        }



        static void ExecAdd()
        {
            Console.WriteLine("eneter first value");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter second value");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }

        static void ExecMulti()
        {
            Console.WriteLine("eneter first value");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter second value");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
        }

    }
}
