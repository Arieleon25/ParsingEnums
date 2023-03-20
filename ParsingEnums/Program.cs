using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysofWeek week = new DaysofWeek();

            Console.WriteLine("Enter the current day of the week");
            string userInput = Console.ReadLine();

            try
            {
                week.Day = (Day)Enum.Parse(typeof(Day), userInput);
                Console.WriteLine("You said: " + week.Day);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
