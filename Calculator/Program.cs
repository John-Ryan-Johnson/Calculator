using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Professor.");

            Console.WriteLine(@"Please enter one of the following methods that you would like to use:
                * (multiply each number)
                ^ (square each number)
                + (add each number)
                / (divide each number)
                @ (average of all numbers)");

            var chosenMethod = Console.ReadLine();

            Console.WriteLine("Please enter some numbers seperated by commas. (Ex: 2,4,6,8)");

            string userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            int result = 1;

            //Multiply

            if (chosenMethod.Contains('*'))
            {
                foreach (var number in numbers)
                {
                    result *= int.Parse(number);
                }

                Console.WriteLine(result);

                Console.ReadKey();
            }

            //Square

            else if (chosenMethod.Contains('^'))
            {
                var squaredResult = "";

                foreach (var number in numbers)
                {
                    var numbersToSquare = int.Parse(number);

                    var squaredNumber = numbersToSquare * numbersToSquare;

                    squaredResult += $"{squaredNumber},";
                }
                squaredResult = squaredResult.Remove(squaredResult.Length - 1);

                Console.WriteLine($"The answer is: {squaredResult}.");

                Console.ReadKey();
            }

            //Addition

            else if (chosenMethod.Contains('+'))
            {
                var addedResult = 0;

                foreach (var number in numbers)
                {
                    addedResult += int.Parse(number);
                }
                Console.WriteLine($"The answer is: {addedResult}.");

                Console.ReadKey();
            }

            //Division

            else if (chosenMethod.Contains('/'))
            {
                var dividedResult = 0m;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == 0)
                    {
                        dividedResult = Convert.ToDecimal(numbers[i]);
                    }
                    else
                    {
                        dividedResult /= Convert.ToDecimal(numbers[i]);
                    }
                }
                Console.WriteLine($"The answer is: {dividedResult}.");
                Console.ReadKey();
            }

            //Averages

            else if (chosenMethod.Contains('@'))
            {
                var sum = 0;

                foreach (var number in numbers)
                {
                    sum += int.Parse(number);
                }
                var averagedResult = Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Length);

                Console.WriteLine($"The answer is: {averagedResult}.");

                Console.ReadKey();
            }
        }
    }
}
