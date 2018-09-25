using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet1Excersise4ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {

            // Taking in all scores

            int worstGrade = 100;
            int[] points = new int[7];
            int totalScore = 0;

            for(int i = 0; i < 7; i++)
            {

                Console.Write("Please Enter your Subject Points: ");
                points[i] = int.Parse(Console.ReadLine());

                //Seeing if Entered Scores are Valid

                while(points[i] > 100 || points[i] < 0)
                {

                    Console.Write("Entry Invalid Please Enter Again: ");
                    points[i] = int.Parse(Console.ReadLine());

                }

                // Finding the smallest score to subtract it later

                if(worstGrade > points[i])
                {

                    worstGrade = points[i];

                }

                // Adding Grades To Total

                totalScore += points[i];

            }

            // Subtracting Smallest Score from Total
            totalScore -= worstGrade;


            // Waiting Gate For Presentation
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("Your total Score is {0} and your worst grade was {1}", totalScore, worstGrade);
            Console.ReadLine();

        }
    }
}
