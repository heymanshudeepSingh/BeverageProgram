/********************************************************************************************
 * NAME- HEYMANSHUDEEPSINGH
 * DATE 1/23/2019
 * BEVERAGE COLLECTION PROGRAM
 * 
 * THIS PROGRAM CONTAINS 5 CLASSES- MAIN(PROGRAM), BEVERAGE , BEVERAGECOLLECTION, CSVPROCESSOR,USERINTERFACE
 * THIS PROGRAM LOADS THE ARRAY FROM A CSV FILE AND USE IT FOR 
 * PRINTING ARRAY IN CONSOLE,
 * FOR LINEAR SEARCH,BASED ON USER INPUT
 * THIS PROGRAM ALLOWS USER TO CHOOSE FROM 3 OPTION -TO PRINT ARRAY,TOSEARCH A PARTICULAR BEVERAGE BASED ON ID, TO ADD A BEVERAGE TO ARRAY
 * 
 * NEW THINGS LEARNT-
 * SEARCHING FOR CSVFILE(PATH TO CSV)
 * USING DIFFERENT CLASSES, PASSING VALUES AMONG CLASSES,SEARCHING A SPECIFIC THING IN AN ARRAY,ADDING TO AN ARRAY
 * 
 * ********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a new UserInterface
            UserInterface ui = new UserInterface();

            //instantiate a new Beverage collection
            BeverageCollection bvgcollection = new BeverageCollection();
            string pathToCSV = "../../../datafiles/beverage_list.csv";

            //instantiate a new CSVProcessfor
            CSVProcessor csvProcessor = new CSVProcessor();


            csvProcessor.ImportCSV(pathToCSV, bvgcollection);


            //GETTING SOME USER INPUT
            int choice = ui.GetUserInput();


            //while the choice they selected is not 2 continue to work
            while (choice != 4)
            {
                //LISTING THE ARRAY
                if (choice == 1)
                {
                   
                    ui.Output(bvgcollection.outputList());
                }
                //LINEAR SEARCH
                if (choice == 2)
                {
                    Console.WriteLine("\n Enter Id You Want to Search");
                    string userInput = (Console.ReadLine());
                    
                    bvgcollection.LinearSearchCnt( userInput);

                }
                //ADDING TO THE ARRAY
                if (choice == 3)
                {
                   


                    Console.WriteLine("Enter ID");
                  
                    string id = Console.ReadLine();

                    Console.WriteLine("Enter Beverage Name");
                    string bvgName = Console.ReadLine();

                    Console.WriteLine("pack size");
                    string packsize = Console.ReadLine();

                    Console.WriteLine("Enter price");
                    decimal price = Convert.ToDecimal(Console.ReadLine());


                    Console.WriteLine("IS it active, Type true or false");
                    string abc= Console.ReadLine();

                    while (abc != "true" && abc != "false")
                    {
                        Console.WriteLine("Try Again , is it active, Type true or false");
                        
                        abc = Console.ReadLine();
                    }
                    bool active = Convert.ToBoolean(abc);
                
                

                    bvgcollection.addingToArray(id, bvgName, packsize, price, active);

                }
                
                choice = ui.GetUserInput();
            }

        }
    }
}
