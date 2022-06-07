using System;

namespace temperatureconverter
{
    class MainClass
    {
        //method to validate the number
        public static bool isNumber(string inTemp)
        {
            bool validator;
            int number;

            try
            {
                number = int.Parse(inTemp);
                validator = true;
            }
            catch
            {
                validator = false;
            }

            return validator;
        }

        public static void solve()
        {
            Console.WriteLine("A: Convert Celsius to Fahrenheit");
            Console.WriteLine("B: Convert Fahrenheit to Celsius");
            string selection;
            int temp = 0;
            string number;
            bool validate;

            do
            {
                selection = Console.ReadLine().ToUpper();
            } while (selection != "A" && selection != "B");

            //Will repeat until the user enter a invalid number
            do
            {
                Console.WriteLine("Enter the starting temperature:");
                number = Console.ReadLine();
                validate = isNumber(number);
            } while (!validate);

            temp = int.Parse(number);

            switch (selection)
            {
                case "A":
                    Console.WriteLine($"{temp} degress Celsius is {Math.Round(temp * 1.8 + 32, 2 )} degrees Fahrenheit.");
                    break;
                case "B": 
                    Console.WriteLine($"{temp} degress Fahrenheit is {Math.Round((temp - 32) / 1.8, 2)} degrees Celsius.");
                    break;
                default:
                    break;

            }
        }

        public static void Main(string[] args)
        {
            solve();
        }
    }
}
