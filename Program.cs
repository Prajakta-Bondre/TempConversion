using System;

namespace TempConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 84;
            double fahrenheit;
            Console.WriteLine("Temperature in celsius: " + celcius);
           
            fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

           


        }
    }
}
