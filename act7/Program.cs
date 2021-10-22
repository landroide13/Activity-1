using System;

namespace act7
{
    class Program
    {

        static double perimeter(int rad)
        {
            return 2 * 3.14 * rad;
        }

        static double area(int rad)
        {
            return (rad * rad) * 3.14;
        }

        static double volumen(int rad)
        {
            return (rad * rad * rad);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("######## Circle App #########");
            Console.WriteLine("##### Please add the radius: ");

            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Area is: " + area(radius));
            Console.WriteLine("The Perimeter is: " + perimeter(radius));
            Console.WriteLine("The Volumen is: " + volumen(radius));
        }
    }
}
