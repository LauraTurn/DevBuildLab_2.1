using System;

namespace Revisit_Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prompt user to enter length & width of a classroom
            //Disply area and perimeter of of that classroom
            //Classify room as small up to 250 square feet, medium more than 250 < 650, large => 650 square feet
            //Promt the user to continue measuring rooms

            Console.WriteLine("Welcome to Grand Circus Room Detail Generator!\n");

            double length;
            double width;
            double height;
            double perimeter;
            double area;
            double volume;
            string answer;
            string newanswer;

            bool over = false;
            while (!over)

            //do
            {
                Console.Write("Please enter the length of the room: ");
                length = Double.Parse(Console.ReadLine());

                Console.Write("Please enter the width of the room: ");
                width = Double.Parse(Console.ReadLine());

                Console.Write("Please enter the height of the room: ");
                height = Double.Parse(Console.ReadLine());

                area = (length * width);
                Console.WriteLine($"\nArea: " + area);

                perimeter = (2 * length) + (2 * height);
                Console.WriteLine($"Perimeter: " + perimeter);

                volume = (length * height * width);
                Console.WriteLine($"Volume: " + volume);

                if (area >= 250 && area < 650)
                {
                    Console.WriteLine($"\nThis is a medium room.");
                }
                else if (area < 250)
                {
                    Console.WriteLine($"\nThis is a small room.");
                }
                else
                {
                    Console.WriteLine($"\nThis is a large room.");
                }

                Console.Write($"\nWould you like to continue? (Y/N)");
                answer = Console.ReadLine();
                Console.WriteLine();

                if (answer == "Y" || answer == "y")
                {
                    over = false;
                }
                else
                {
                    over = true;
                }

            }

            Console.WriteLine("Thank you for using the Room Detail Generator.  Goodbye!\n");


        }
    }
}
