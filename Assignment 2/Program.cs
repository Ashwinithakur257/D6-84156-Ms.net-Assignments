using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);

            Console.WriteLine("Enter operation to perform");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int choice=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Addition is " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction is " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is " + (a * b));
                    break;            
            case 4:
                    Console.WriteLine("Division is " + a / b);
                    break;
            }

            Console.ReadLine();

        }
    }
}
