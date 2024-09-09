using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===Temperature Converter===");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Celsius to Réaumur");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                Console.Write("Enter temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
                        break;
                    case 2:
                        double kelvin = celsius + 273.15;
                        Console.WriteLine($"Temperature in Kelvin: {kelvin:F2}");
                        break;
                    case 3:
                        double reaumur = celsius * 4 / 5;
                        Console.WriteLine($"Temperature in Réaumur: {reaumur:F2}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                        break;
                }
            }
        }
    }
}
