using System;

namespace act2
{
    class Program
    {

        static public double getFaran(double temp)
        {
            return ((temp * 1.8) + 32);
        }

        static public double getCelsius(double temp)
        {
            return ((temp - 32) * 5 / 9);
        }


        static public void convert(string an)
        {

            if(an == "1")
            {
              Console.WriteLine("######### Enter Celsius Temperature  #########");
              double temp = Convert.ToDouble(Console.ReadLine());
              double toFah = getFaran(temp);
              Console.WriteLine("### " + temp + " Celsius " + " is " + toFah + " Fahrenheits.");
            }
            if(an == "2")
            {
              Console.WriteLine("######### Enter Fahrenheit Temperature  #########");
              double temp = Convert.ToDouble(Console.ReadLine());
              double toCel = getCelsius(temp);
              Console.WriteLine("### " + temp + " Fahrenheits " + " is " + toCel + " Celsius.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("############ The Temperature Convertion Pro ###############");
            Console.WriteLine("############ Option 1 to: Celsius to Fahrenheit ###############");
            Console.WriteLine("############ Option 2 to: Fahrenheits to Celsius ###############");
            Console.WriteLine("############ Option 3 to: Quit ###############");
            string answer = Console.ReadLine();

            Console.WriteLine(answer);
            
            convert(answer);

        }
    }
}
