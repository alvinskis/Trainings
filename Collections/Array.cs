using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Array
    {
        public void WeekArray()
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Weed",
                "Thurdsday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            foreach(var day in daysOfWeek)
            {
                Console.WriteLine($"{day}");
            }

            Console.WriteLine(" ");
            daysOfWeek[2] = "Wednesday";

            foreach(var day in daysOfWeek)
            {
                Console.WriteLine($"{day}");
            }
        }
    }
}
