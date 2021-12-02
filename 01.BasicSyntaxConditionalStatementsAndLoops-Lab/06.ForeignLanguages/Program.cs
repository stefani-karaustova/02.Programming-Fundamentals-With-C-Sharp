using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            string language = "";

            switch (country)
            {
                case "USA":
                    language = "English";
                    break;
                case "England":
                    language = "English";
                    break;
                case "Spain":
                    language = "Spanish";
                    break;
                case "Argentina":
                    language = "Spanish";
                    break;
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
