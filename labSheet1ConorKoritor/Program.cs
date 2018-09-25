using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet1Excersise1ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;

            //Read in Grade

            Console.Write("Enter your Grade in Percentile: ");
            grade = int.Parse(Console.ReadLine());

            // Checks Grade Against boundaries to see what the letter grade is and outputs the letter grade


            // Checking Boundaries
            if(grade >= 90 && grade <= 100)
            {
                //Outputting Letter Grade
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
