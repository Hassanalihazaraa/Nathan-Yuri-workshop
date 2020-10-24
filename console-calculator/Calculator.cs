using System;

namespace console_calculator
{
    public class Calculator
    {
        public double solution;

        public void calculate()
        {
            Console.WriteLine("Please enter first number");
            double numb1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            double numb2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                "Please enter which arithmetic operation(add,substract,multiply,divide) do you want to do?");
            string input = Console.ReadLine();
            switch (input)
            {
                case "add":
                    solution = numb1 + numb2;
                    break;
                case "substract":
                    solution = numb1 - numb2;
                    break;
                case "multiply":
                    solution = numb1 * numb2;
                    break;
                case "divide":
                    solution = numb1 / numb2;
                    break;
            }
            Console.WriteLine(solution);
        }
    }
}