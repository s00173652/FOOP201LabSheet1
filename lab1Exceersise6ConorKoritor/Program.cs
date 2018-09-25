using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab1Exceersise6ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {

            int currentScore;
            int totalScore = 0;
            int worstGrade = 100;

            // Read Each Line and Put Them into an Array called Grades

            string[] grades = File.ReadAllLines(@"C:\Users\s00173652\Desktop\excersise6TxtFile.txt");

            foreach(string grade in grades)
            {

                // Changing what was read to an int
                currentScore = int.Parse(grade);


              

                // Finding the smallest score to subtract it later

                if (worstGrade > currentScore)
                {

                    worstGrade = currentScore;

                }

                // Adding Grades To Total

                totalScore += currentScore;


            }

            totalScore -= worstGrade;

            Console.WriteLine("Press Enter to Continue: ");
            Console.ReadLine();

            Console.WriteLine("Your total Score is {0} and your worst grade was {1}", totalScore, worstGrade);
            Console.WriteLine("Your total Score and Your Worst Score Were Written to your Grade file");
            using (StreamWriter file =
            new StreamWriter(@"C: \Users\s00173652\Desktop\excersise6TxtFile.txt", true))
            {
                file.WriteLine();
                file.WriteLine("Your total Score is {0} and your worst grade was {1}", totalScore, worstGrade);
            }
            Console.ReadLine();

        }
    }
}
