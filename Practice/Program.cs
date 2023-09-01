using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        public static void Main()
        {
            // Asking the user for expression
            Console.WriteLine("Enter an expression: ");
            string exp = Console.ReadLine();

            // Lists for storing numbers and operator
            List<double> numbers = new();
            List<char> operators = new();
            int charToInt;
            double currNum = 0;
            int i = 0;
            double res = 0;
            foreach (char letters in exp)
            {

                charToInt = letters - 48;
                if (letters == '+' || letters == '-' || letters == '/' || letters == '*')
                {
                    operators.Insert(i, letters);
                    i++;
                    currNum = 0;
                    continue;
                }
                else
                {
                    currNum = currNum * 10 + charToInt;
                    numbers.Insert(i, currNum);
                }
            }
            for (int arrayIndex = 0; arrayIndex < operators.Count; arrayIndex++)
            {
                if (operators[arrayIndex] == '/')
                {
                    res = numbers[arrayIndex] / numbers[arrayIndex + 1];
                    numbers[arrayIndex] = res;
                    numbers.RemoveAt(arrayIndex + 1);
                    operators.RemoveAt(arrayIndex);
                }
            }

            for (int arrayIndex = 0; arrayIndex < operators.Count; arrayIndex++)
            {
                if (operators[arrayIndex] == '*')
                {
                    res = numbers[arrayIndex] * numbers[arrayIndex + 1];
                    numbers[arrayIndex] = res;
                    numbers.RemoveAt(arrayIndex + 1);
                    operators.RemoveAt(arrayIndex);
                }
            }

            for (int arrayIndex = 0; arrayIndex < operators.Count; arrayIndex++)
            {
                if (operators[arrayIndex] == '-')
                {
                    res = numbers[arrayIndex] - numbers[arrayIndex + 1];
                    numbers[arrayIndex] = res;
                    numbers.RemoveAt(arrayIndex + 1);
                    operators.RemoveAt(arrayIndex);
                }
            }


            for (int arrayIndex = 0; arrayIndex < operators.Count; arrayIndex++)
            {
                if (operators[arrayIndex] == '+')
                {
                    res = numbers[arrayIndex] + numbers[arrayIndex + 1];
                    numbers[arrayIndex] = res;
                    numbers.RemoveAt(arrayIndex + 1);
                    operators.RemoveAt(arrayIndex);
                }
            }

            
            Console.WriteLine(res);
        }
    }
}