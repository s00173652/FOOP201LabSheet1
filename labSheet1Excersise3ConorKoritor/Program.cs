using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet1Excersise3ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordinaryOrHigher;
            // Asking the user whether their grade is Ordinary level or higher
            Console.WriteLine("Enter 0 for Ordinary Level and 1 for Higher Level");
            Console.Write("Enter your Selection: ");
            ordinaryOrHigher = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Depending on User Input they will be taken into the ordinary or higher level if loop

            if(ordinaryOrHigher == 0)
            {
                //Taking in users grade
                int grade;
                Console.Write("Enter your Grade in Percentile: ");
                grade = int.Parse(Console.ReadLine());
                Console.WriteLine();


                //Calculating and outputting for ordinary level letter grades
                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Your Letter Grade is O1");
                    Console.WriteLine("You Recieved 56 points");
                }

                if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("Your Letter Grade is O2");
                    Console.WriteLine("You Recieved 46 points");
                }

                if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("Your Letter Grade is O3");
                    Console.WriteLine("You Recieved 37 points");
                }

                if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("Your Letter Grade is O4");
                    Console.WriteLine("You Recieved 28 points");
                }

                if (grade >= 50 && grade < 60)
                {
                    Console.WriteLine("Your Letter Grade is O5");
                    Console.WriteLine("You Recieved 20 points");
                }

                if (grade >= 40 && grade < 50)
                {
                    Console.WriteLine("Your Letter Grade is O6");
                    Console.WriteLine("You Recieved 12 points");
                }

                if (grade >= 30 && grade < 40)
                {
                    Console.WriteLine("Your Letter Grade is O7");
                    Console.WriteLine("You Recieved 0 points");
                }

                if (grade >= 0 && grade < 30)
                {
                    Console.WriteLine("Your Letter Grade is O8");
                    Console.WriteLine("You Recieved 0 points");
                }

                Console.ReadLine();
            }

            if(ordinaryOrHigher == 1)
            {

                //Taking in users grade
                int grade;
                Console.Write("Enter your Grade in Percentile: ");
                grade = int.Parse(Console.ReadLine());


                //Calculating and outputting higher level letter grade
                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Your Letter Grade is H1");
                    Console.WriteLine("You Recieved 100 points");
                }

                if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("Your Letter Grade is H2");
                    Console.WriteLine("You Recieved 88 points");
                }

                if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("Your Letter Grade is H3");
                    Console.WriteLine("You Recieved 77 points");
                }

                if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("Your Letter Grade is H4");
                    Console.WriteLine("You Recieved 66 points");
                }

                if (grade >= 50 && grade < 60)
                {
                    Console.WriteLine("Your Letter Grade is H5");
                    Console.WriteLine("You Recieved 56 points");
                }

                if (grade >= 40 && grade < 50)
                {
                    Console.WriteLine("Your Letter Grade is H6");
                    Console.WriteLine("You Recieved 46 points");
                }

                if (grade >= 30 && grade < 40)
                {
                    Console.WriteLine("Your Letter Grade is H7");
                    Console.WriteLine("You Recieved 37 points");
                }

                if (grade >= 0 && grade < 30)
                {
                    Console.WriteLine("Your Letter Grade is H8");
                    Console.WriteLine("You Recieved 0 points");
                }

                Console.ReadLine();
            }
        }
    }
}
