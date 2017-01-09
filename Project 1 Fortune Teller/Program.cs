using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age as a number");
            int age = int.Parse(Console.ReadLine());
                                             
            Console.WriteLine("What is your birthmonth? Please enter a number value");
            int birthmonth = int.Parse(Console.ReadLine());
           
            Console.WriteLine("What is you favorite RoyGBiv color? If you don't know RoyGBiv colors enter help");
            string color = Console.ReadLine();
            if (color == "help")
            {
                Console.WriteLine("RoyGBiv colors are red, orange, yellow, green, blue, indigo, and violet. Enter color again");
                color = Console.ReadLine();
            }

            string answer = "";
            switch (color.ToLower())
            { 
                case "red":
                    answer = "Rolls Royce";
                    break;
                case "orange":
                    answer = "Yacht";
                    break;
                case "yellow":
                    answer = "Harley Davidson";
                    break;
                case "green":
                    answer = "Private Jet";
                    break;
                case "blue":
                    answer = "Horse";
                    break;
                case "indigo":
                    answer = "Canoe";
                    break;
                case "violet":
                    answer = "Helicopter";
                    break;
                default:
                    answer = "pair of tennis shoes for walking";
                    break;                                         
            }
                                     
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            //Whether age is odd or even
            string retirement = "";
            if (age % 2 == 1)
            {
                retirement = "20 years";
            }
            else
            {
                retirement = "30 years";
            }
            //  Number of Siblings
            string family = "";
            if (siblings == 0)
            {
                family = "Florida";
            }
            else if (siblings == 1)
            {
                family = "Cancun";
            }
            else if (siblings == 2)
            {
                family =  "Mexico";
            }
            else if (siblings == 3)
            {
                family = "China";
            }
            else if (siblings > 3)
            {
                family = "London";
            }
            else
            {
                family = "Slums of Detroit";
            }

            float money;

            if (birthmonth >= 1 && birthmonth <= 4)
            {
                money = 100.00f;
            }
            else if (birthmonth >= 5 && birthmonth <= 8)
            {
                money = 500.00f;
            }
            else if (birthmonth >= 9 && birthmonth <= 12)
            {
                money = 200.00f;
            }
            else
                money = 00.00f;

            Console.Write(firstName + " " + lastName + " you will retire in " + retirement + " with $" + money + " in the bank, a vacation home in " + family + " and a " + answer + " ");

           








        }
    }
}
