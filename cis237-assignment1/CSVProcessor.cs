using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cis237_assignment1
{
    class CSVProcessor
    {
        
        /// <summary>
        /// THIS CLASS IS USED TO IMPORT THE CSV FILE
        /// </summary>
        /// <param name="pathToCSVFile"></param>
        /// PATH TO CSVFILE IS THE LOCATION OF CSVFILE USED IN STREAMREADER TO OPEN THE FILE
        /// <param name="bvgCollection"></param>
        /// <returns></returns>
        public bool ImportCSV(string pathToCSVFile, BeverageCollection bvgCollection)
        {//define the streamreader
            StreamReader streamReader = null;

            try
            {
                string line;

                //institate the streamreader
                streamReader = new StreamReader(pathToCSVFile);

                //used to index into the array
                int counter = 0;
                //while we are still reading a line from file
                while ((line = streamReader.ReadLine()) != null)
                {
                    processLine(line, bvgCollection, counter++);

                }

                return true;
            }
            catch (Exception e)
            {
                //output the exception and the stacktrace for the exception
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                //if the stream reader was instanciated,make sure it is closed before exiting the reader

                if (streamReader != null)
                {
                    streamReader.Close();
                }

            }

        }

        /// <summary>
        /// IT IS SPLITING UP OF ARRAY IN DIFFERENT PARTS
        /// </summary>
        /// <param name="line"></param>
        /// <param name="beverageCollection"></param>
        /// <param name="index"></param>
        private void processLine(string line, BeverageCollection beverageCollection, int index)
        {
            // declare array of parts that will contain the results of splitting the read in string
             string[] parts = line.Split(',');


            string id = parts[0];
            string name = parts[1];
            string pack = parts[3];
            decimal price = decimal.Parse(parts[3]);
            bool active = Boolean.Parse(parts[4]);

            beverageCollection.addingToArray(id, name, pack, price, active);
            


        }


    }
}
