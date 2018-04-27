using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
       
 {
            //Welcome user
            Console.WriteLine("Welcome to the Dice Generator!");

            string answer;
            do
            {
                //ask user for dice sides
                Console.WriteLine("How any sides?");

                string sides = Console.ReadLine();
                int numberSides = int.Parse(sides);

                //ask user to roll dice

                Console.WriteLine("Do you want to roll the dice or exit? (R/E)");
                answer = Console.ReadLine();
                if (answer.ToUpper() == "R")
                {

                    int rolledNum = RollDice(numberSides);
                    int rolledNum2 = RollDice(numberSides);

                    //dislpay what user has rolled
                    Console.WriteLine($"1st number {rolledNum} 2nd number {rolledNum2}");
                }
                else
                {
                    break;
                }
                //aks if user wants to continue
                Console.WriteLine("Would you like to roll again? (y/n)");
                answer = Console.ReadLine();

            } while (answer == "y");
         
            
            
        } 

        static int RollDice(int numberSides)
        {
            

           int num = rnd.Next(1, numberSides);

           return num;
        }
    }
}
