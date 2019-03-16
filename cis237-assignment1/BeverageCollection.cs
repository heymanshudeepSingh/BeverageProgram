using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class BeverageCollection
    {

        /// <summary>
        /// THIS IS THE WRAPPER CLASS TO BEVERAGE IN WHICH LINEAR SEARCH AND ADDING TO ARRAY TAKES PLACE
        /// </summary>
        /// <returns></returns>


        Beverage[] beverages = new Beverage[5000];
        int index = 0;


        //PRINTING THE ARRAY
        public string outputList()
        {
            string outputstring = "";
            foreach (Beverage beverage in beverages)
            // have to do a null check since all spots in the array are not full.
            {
               
                if (beverage != null)
                {
                     outputstring += beverage.ToString() + Environment.NewLine;
                }

            }
            return outputstring;
        }

        //THIS IS WHERE USER INPUT IS PASSED TO ADD TO ARRAY
        public void addingToArray(string id, string name, string pack, decimal price, bool active)
        {

            
            beverages[index] = new Beverage(id, name, pack, price, active);
            index++;
        }

        //SEARCHING FOR BEVERAGE BASED ON ID
        public void LinearSearchCnt( string target)   // ACCEPTS SEARCH ARGUMENT    // SEARCH METHOD
        {
            //Beverage bvgs = new Beverage();
            //string id = bvg.ID;
            Boolean match = false;
            
            
            int s = 0;


            for (s = 0; s < beverages.Length; s++)
            {
                // COUNT # ITERATIONS
                if (beverages[s] != null)
                {
                    if (beverages[s].ID == target)
                    {
                        Console.WriteLine("beverages with ID {0} Are {1}", target, beverages[s]);
                        match = true;
                    }
                }

            }

            if (match == false)
            {


                Console.WriteLine("No Match");

            }







        }
      



    }
}

