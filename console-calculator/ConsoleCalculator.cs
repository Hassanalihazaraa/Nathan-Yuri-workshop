using System;

namespace console_calculator
{
    public class ConsoleCalculator
    {
        public double solution;
        public double calculator()
        {
            Console.Writeline("Please enter a number two times");
            double numb1 = (double)Console.Readline();
            double numb2 = (double)Console.Readline();
            Console.Writeline("Please enter which arithmetic operation(additon,substraction,multiplication,division) do you want to do?");
            string input = Console.Readline();
            switch (input)
            {
                case "add":
                    solution = numb1 + numb2;
                    break;
                case "substract":
                    solution = numb1 - numb2;
                    break;
                case "multiply":
                    solution = numb1 * num2;
                    break;
                case "divide":
                    solution = numb1 / num2;
                    break;
            }
            return Console.Writeline(solution);
        }
    }
}