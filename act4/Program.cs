using System;

namespace act4
{
    class Program
    {

        static void setTable(int num)
        {
            int[] table = new int[10];

            for (int i = 0; i <= table.Length; i++)
            {
                Console.WriteLine(i + " x " + num + " = " + (num * i));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("########## Multiplication Table ################");
            Console.WriteLine("########## Add a Number ################");

            int number = Convert.ToInt32(Console.ReadLine());

            setTable(number);

        }
    }
}
