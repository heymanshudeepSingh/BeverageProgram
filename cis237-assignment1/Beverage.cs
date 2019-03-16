using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Beverage
    {
        /// <summary>
        /// THIS CLASS HOLDS THE BEVERAGE INFORMATION
        /// </summary>

        //****************************************
        // VARIABLES
        //**************************************
        private string id;
        private string name;
        private decimal price;
        private string pack;
        private bool active;

        //*******************
        // PROPERTIES
        //********************
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Pack
        {
            get { return pack; }
            set { pack = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }


        public override string ToString()
        {
            return id + " " + name+ " " + pack+ " "+ price.ToString("c")+ " "+ active.ToString();
        }

        public Beverage()
        {
            
        }

        public Beverage(string id,string name,string pack,decimal price, bool active)
        {
            

            this.id = id;
            this.name = name;
            this.price = price;
            this.pack = pack;
            this.active = active;

            ID = id;

        }

    }
}
