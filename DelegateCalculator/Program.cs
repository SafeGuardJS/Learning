using System;

namespace DelegateCalculator
{
    class Program
    {
        public delegate double ArithmeticOperation(int a, int b);

        static void Main(string[] args)
        {
            ArithmeticOperation add = (a, b) => a + b;
            ArithmeticOperation sub = (a, b) => a - b;
            ArithmeticOperation mul = (a, b) => a * b;
            ArithmeticOperation div = (a, b) => 
            {
                if (b == 0)
                {
                    Console.WriteLine("Division by zero");
                    return 0;
                }
                else return 
                    a / b;
            };

            int firstMember, secondMember;
            string operationSimbol;

            Console.WriteLine("Enter first memeber of operation: ");
            firstMember = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first memeber of operation: ");
            operationSimbol = Console.ReadLine();
            Console.WriteLine("Enter second memeber of operation: ");
            secondMember = Convert.ToInt32(Console.ReadLine());

            switch (operationSimbol)
            {
                case "+":
                    Console.WriteLine($"{firstMember} + {secondMember} = {add(firstMember, secondMember)}");
                    break;
                case "-":
                    Console.WriteLine($"{firstMember} - {secondMember} = {sub(firstMember, secondMember)}");
                    break;
                case "*":
                    Console.WriteLine($"{firstMember} * {secondMember} = {mul(firstMember, secondMember)}");
                    break;
                case "/":
                    Console.WriteLine($"{firstMember} / {secondMember} = {div(firstMember, secondMember)}");
                    break;
                default:
                    Console.WriteLine("Enter correct operation value");
                    break;
            }
        }
    }
}
