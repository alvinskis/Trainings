using System;
using System.Collections.Generic;

namespace CollectionsManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\modestas.alvinskis\Desktop\Trainings\CollectionsManipulation\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Enter no. of countries to display: ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if(!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("Type existing integer");
                return;
            }

            int maxToDisplay = userInput;
            //foreach (Country country in countries)
            for (int i = 0; i < countries.Count; i++)
            {
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit: ");
                    if (Console.ReadLine() != "")
                    {
                        break;
                    }
                }
                Country country = countries[i];
                Console.WriteLine($"{1+i}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
