using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Excersise5ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {

            int exitNumber = 0;
            int worstGrade = 100;
            int totalScore = 0;
            int currentScore = 0;

            while (exitNumber != -1)
            {

                Console.Write("Please Enter your Subject Points: ");
                currentScore = int.Parse(Console.ReadLine());
#
                // Seeing if the entered score is valid

                while (currentScore > 100 || currentScore < 0)
                {

                    Console.Write("Entry Invalid Please Enter Again: ");
                    currentScore = int.Parse(Console.ReadLine());

                }

                // Finding the smallest score to subtract it later

                if (worstGrade > currentScore)
                {

                    worstGrade = currentScore;

                }

                // Adding Grades To Total

                totalScore += currentScore;

                Console.Write("Enter -1 to Exit or Enter 0 to Submit another Grade: ");
                exitNumber = int.Parse(Console.ReadLine());

            }

            totalScore -= worstGrade;

            Console.WriteLine("Press Enter to Continue: ");
            Console.ReadLine();

            Console.WriteLine("Your total Score is {0} and your worst grade was {1}", totalScore, worstGrade);
            Console.ReadLine();

        }
    }
}
