using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /* Display Table of Powers. Prompt the user to enter an iteger and display table of Squares and Cubes 
     // from 1 to the value entered. Also prompt user to continue*/
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter a whole number to get its square and cube!");
                var value = Console.ReadLine();

                try
                {
                    // User Input Validations check to make sure user enters whole number
                    if (!int.TryParse(value, out count) || count < 1)
                    {
                        Console.WriteLine("Please enter a whole number and try again.");
                        value = Console.ReadLine();

                    }
                    int integerValue = int.Parse(value);
                    Console.WriteLine("Number\tSquared\tCubed");
                    Console.WriteLine("=======\t=======\t=======");

                    for (int i = 1; i <= integerValue; i++)
                    {

                        int ansSquare = CalcSquare(i);
                        int ansCube = CalcCube(i);
                        Console.WriteLine(i + "\t" + ansSquare + "\t" + ansCube);


                    }
                    run = Continue();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.GetType()+ " means " + ex.Message);
                }
                                            
            }
        }

        public static int CalcSquare(int i)
        {
            int squareNum = i * i;
            return squareNum;
        }
        public static int CalcCube(int i)
        {
            int cubeNum = CalcSquare(i) * i;
            return cubeNum;
        }
        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                 
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;

        }
    }
}
