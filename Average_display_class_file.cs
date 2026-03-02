using System;
using System.Collections.Generic;

namespace average_in_one_project
{
    public enum Range
    {
        Min = 50,
        Max = 100,
        Size = 10
    }

    public class GradeManager
    {
        public void InputGrades()
        {
            List<int> numbers = new List<int>();
            int size = (int)Range.Size;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number for quarter {i + 1}: ");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num >= (int)Range.Min && num <= (int)Range.Max)
                    {
                        numbers.Add(num);

                        if (num >= 74)
                            Console.WriteLine($"You Passed in quarter {i + 1}");
                        else
                            Console.WriteLine($"You Fail in quarter {i + 1}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid! Enter 50-100 only.");
                        i--; // repeat same index
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Enter a number.");
                    i--; // repeat same index
                }
            }

            int sum = 0;
            foreach (int grade in numbers)
            {
                sum += grade;
            }

            double average = (double)sum / numbers.Count;
            Console.WriteLine("Average = " + average);
        }
    }
}
