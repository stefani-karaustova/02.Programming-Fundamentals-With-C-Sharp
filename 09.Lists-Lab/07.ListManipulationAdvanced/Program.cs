using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            bool isChanged = false;

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "remove":
                        numbers.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "removeat":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "contains":

                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }

                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;

                    case "printeven":

                        List<int> evenNumbers = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            var currentNumber = numbers[i];

                            if (currentNumber % 2 == 0)
                            {
                                evenNumbers.Add(currentNumber);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;

                    case "printodd":

                        List<int> oddNumbers = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            var currentNumber = numbers[i];

                            if (currentNumber % 2 != 0)
                            {
                                oddNumbers.Add(currentNumber);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;

                    case "getsum":
                        var sum = 0;

                        foreach (var number in numbers)
                        {
                            sum += number;
                        }

                        Console.WriteLine(sum);
                        break;

                    case "filter":

                        if (command[1] == "<")
                        {
                            foreach (var number in numbers)
                            {
                                if (number < int.Parse(command[2]))
                                {
                                    Console.Write($"{number} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (command[1] == ">")
                        {
                            foreach (var number in numbers)
                            {
                                if (number > int.Parse(command[2]))
                                {
                                    Console.Write($"{number} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (command[1] == ">=")
                        {
                            foreach (var number in numbers)
                            {
                                if (number >= int.Parse(command[2]))
                                {
                                    Console.Write($"{number} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (command[1] == "<=")
                        {
                            foreach (var number in numbers)
                            {
                                if (number <= int.Parse(command[2]))
                                {
                                    Console.Write($"{number} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
