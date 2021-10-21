using System;

namespace act1
{
    class Program
    {


        static public void checkNum(string a, string b)
        {
            int intA = Convert.ToInt32(a);
            int intB = Convert.ToInt32(b);

            if(intA % 2 == 0 || intA % 3 == 0  && intB % 2 == 0 || intB % 3 == 0)
            {
                Console.WriteLine("The Mult of those numbers -> " + (intA * intB));
            }else
            {
                Console.WriteLine("The Sum of those numbers -> " + (intA + intB));
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("######Calc Integer#####");

            Console.WriteLine("###### Please Enter a Int Number #####");
            string a = Console.ReadLine();
            Console.WriteLine("###### Please Enter a second Int Number #####");
            string b = Console.ReadLine();    
            Console.WriteLine("The Entered Numbers are: " + a + " and " + b);

            checkNum(a, b);

            Console.WriteLine("###### The End #####");

        }
    }
}
