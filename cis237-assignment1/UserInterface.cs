using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class UserInterface
    {


        public int GetUserInput()
        {
            //PRINT OUT A MENU
            this.PrintMenu();

            // GET THE INPUT FROM USER
            string input = Console.ReadLine();

            // while the inout is not valid, re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4")

            {
                // PRINT ERROR MESSAGE 
                this.PrintErrorMessage();

                //RE-PRINT THE MENU
                this.PrintMenu();


                // GET INPUT FROM USER AGAIN
                input = Console.ReadLine();

            }

            //AT This Point, i know input is the valid number
            // of either a 1 or a 2 . if i didnt i should wrap the next part in a try/catch.

            return Int32.Parse(input);

        }

        public void Output(string outputString)
        {

            Console.WriteLine(outputString);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What whould you like to do?");
            Console.WriteLine("1. Print BEVERAGE List");
            Console.WriteLine("2. Search Beverage With Item Code");
            Console.WriteLine("3. Add a Beverage");
            Console.WriteLine("4. Exit");

        }

        private void PrintErrorMessage()
        {

            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("please make a valid choice");
            Console.WriteLine();
        }


    
}
}
