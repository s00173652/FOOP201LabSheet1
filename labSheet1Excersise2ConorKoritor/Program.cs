using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet1Excersise2ConorKoritor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Taking in Letter Grade

            string letterGrade;
            Console.Write("Enter your Letter Grade: ");
            letterGrade = Console.ReadLine();

            //Using Switch Statement To see what the letter grade entered is worth

            switch (letterGrade)
            {

                case "H1":
                    //Outputting Final Grade
                    Console.WriteLine("You Recieved 100 Points");
                    break;

                case "H2":
                    Console.WriteLine("You Recieved 88 Points");
                    break;

                case "H3":
                    Console.WriteLine("You Recieved 77 Points");
                    break;

                case "H4":
                    Console.WriteLine("You Recieved 66 Points");
                    break;

                case "H5":
                    Console.WriteLine("You Recieved 56 Points");
                    break;

                case "H6":
                    Console.WriteLine("You Recieved 46 Points");
                    break;

                case "H7":
                    Console.WriteLine("You Recieved 37 Points");
                    break;

                case "H8":
                    Console.WriteLine("You Recieved 0 Points");
                    break;

                case "O1":
                    Console.WriteLine("You Recieved 56 Points");
                    break;

                case "O2":
                    Console.WriteLine("You Recieved 46 Points");
                    break;

                case "O3":
                    Console.WriteLine("You Recieved 37 Points");
                    break;

                case "O4":
                    Console.WriteLine("You Recieved 28 Points");
                    break;

                case "O5":
                    Console.WriteLine("You Recieved 20 Points");
                    break;

                case "O6":
                    Console.WriteLine("You Recieved 12 Points");
                    break;

                case "O7":
                    Console.WriteLine("You Recieved 0 Points");
                    break;

                case "O8":
                    Console.WriteLine("You Recieved 0 Points");
                    break;

                default:
                    Console.WriteLine("You Entered an Invalid Grade");
                    break;

            }

            Console.ReadLine();

        }
    }
}
