using System;

namespace act5
{
    class Program
    {
        static void operations(int a, int b)
        {
            Console.WriteLine("The Sum of: " + a + " + " + b + " = " + (a + b));
            Console.WriteLine("The Mult of: " + a + " * " + b + " = " + (a * b));
            Console.WriteLine("The Subs of: " + a + " - " + b + " = " + (a - b));
            Console.WriteLine("The Div of: " + a + " / " + b + " = " + (a / b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("########## Operation App ################");
            Console.WriteLine("########## Add the First Number ################");

            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("########## Add the Second Number ################");

            int secondNum = Convert.ToInt32(Console.ReadLine());

            operations(firstNum, secondNum);

        }
    }
}
