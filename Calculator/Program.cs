using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers seperated by commas. (Ex: 2,4,6,8)");

            string userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            //loop through numbers and multiply them together

            int result = 1;

            foreach (var number in numbers)
            {
                int parsedNumber = int.Parse(number);

                result *= parsedNumber;
            }


            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
