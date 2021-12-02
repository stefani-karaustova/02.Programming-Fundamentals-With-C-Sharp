using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfField = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] ladybug = new int[sizeOfField];

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] >= 0 && indexes[i] < sizeOfField)
                {
                    ladybug[indexes[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split();

                int whichBug = int.Parse(commandArray[0]);

                if (whichBug >= 0 && whichBug < sizeOfField)
                {
                    int jumpPlaces = int.Parse(commandArray[2]);

                    if (ladybug[whichBug] == 1)
                    {
                        if (commandArray[1] == "left")
                        {
                            int jumpCount = 1;

                            int currLanding = whichBug - jumpPlaces * jumpCount;

                            while (currLanding >= 0 && ladybug[currLanding] == 1)
                            {
                                if (jumpPlaces == 0) break;
                                jumpCount++;

                                currLanding = whichBug - jumpPlaces * jumpCount;
                            }

                            if (currLanding >= 0)
                            {
                                ladybug[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)
                            {
                                ladybug[whichBug] = 0;
                            }
                        }

                        else if (commandArray[1] == "right")
                        {
                            int jumpCount = 1;
                            int currLanding = whichBug + jumpPlaces * jumpCount;

                            while (currLanding < sizeOfField && ladybug[currLanding] == 1)
                            {
                                if (jumpPlaces == 0) break;

                                jumpCount++;
                                currLanding = whichBug + jumpPlaces * jumpCount;
                            }

                            if (currLanding < sizeOfField)
                            {
                                ladybug[currLanding] = 1;
                            }

                            if (jumpPlaces != 0)
                            {
                                ladybug[whichBug] = 0;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybug));
        }
    }
}
