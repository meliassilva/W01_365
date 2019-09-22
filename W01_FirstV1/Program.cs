using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_FirstV1
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //2. First step
            string name = "Mario";
            string location = " Brazil";

            //3.
            Console.WriteLine($"My name is {name} ." );
            Console.WriteLine($"I'm from {location}.");

            //4
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.ToString("d")}");

            //5.
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            var numberOfDays = (christmasDay - currentDate);
            Console.WriteLine($"The number of the days until Chrystimas is: {numberOfDays.ToString("dd")} ");

            //6.
            GrazerCalc();

            Console.WriteLine("\n Press any key to close the program");
            Console.ReadKey();
        }

        /// <summary>
        /// Method used to calculate lenght and the area
        /// </summary>
        public static void GrazerCalc()
        {
            //variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //input one
            Console.Write("\nGive the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //input two
            Console.Write("\nGive the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //calculation
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //display
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
