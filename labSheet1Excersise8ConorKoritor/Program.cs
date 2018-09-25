using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labSheet1Excersise8ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {

            int currentScore;
            int totalScore = 0;
            int worstGrade = 100;
            int[,] gradeBoundaries = new int[8, 10];

            // Read Each Line and Put Them into an Array called Grades

            string[] grades = File.ReadAllLines(@"C:\Users\s00173652\Desktop\excersise6TxtFile.txt");

            foreach (string grade in grades)
            {

                



            }

            totalScore -= worstGrade;

            Console.WriteLine("Press Enter to Continue: ");
            Console.ReadLine();

            

            Console.WriteLine("Your total Score is {0} and your worst grade was {1}", totalScore, worstGrade);
            Console.WriteLine("Your total Score and Your Worst Score Were Written to your Grade file");            
            Console.ReadLine();

        }
    }
}
