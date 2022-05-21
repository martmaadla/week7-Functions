using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv:");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            int inputNum2 = Convert.ToInt32(Console.ReadLine());

            userOperator:
            Console.WriteLine("Vali tehe (sisesta '+', '-', '*', või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    Console.WriteLine("Vastus on: ");
                    AddTwoNumbers(inputNum1, inputNum2);
                    break;
                case '/':
                    Console.WriteLine("Vastus on: ");
                    DivideTwoNumbers(inputNum1, inputNum2);
                    break;
                case '*':
                    Console.WriteLine("Vastus on: ");
                    MultiplyTwoNumbers(inputNum1, inputNum2);
                    break;
                case '-':
                    Console.WriteLine("Vastus on: ");
                    RemoveTwoNumbers(inputNum1, inputNum2);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
            Console.ReadLine();
        }
    
    private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

    private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        private static void RemoveTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}
