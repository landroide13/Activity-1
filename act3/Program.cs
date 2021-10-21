using System;


namespace act3
{
    class Program
    {
         static void setArr()
        {
            int[] arr = new int[10];

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("###### Add Elements ######");
                Console.WriteLine("Element: " + " " + i);
                int el = Convert.ToInt32(Console.ReadLine());
                arr[i] = el;

            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" Ele " + " " + i + ":  " + arr[i]);

                sum += arr[i];
            }

            Console.WriteLine("The Sum: " + sum);
            Console.WriteLine("The Avg: " + sum / 10);

    }
        static void Main(string[] args)
        {
            Console.WriteLine("######## Enter 10 numbers ############");

            setArr();
        }
    }
}
