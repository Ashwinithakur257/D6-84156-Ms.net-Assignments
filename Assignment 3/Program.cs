using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value\n");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value");
            int b = Convert.ToInt32(Console.ReadLine());
            int choice=-1;

            do
            {
                Console.WriteLine("Enter operation to perform");
                Console.WriteLine("0.Exit\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank you");
                        break;
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
            while(choice!= 0);
        }
    }
}
