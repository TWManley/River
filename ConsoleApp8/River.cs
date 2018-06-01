using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    class River
    {
        //fields
        public string name;
        public int depth;
        public int pollution;


        // properties
        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }

        }

        public int Pollution
        {
            get { return this.pollution; }
            set { this.pollution = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public River()
        {
            //default constructor
        }
        public River(string nameOne) // loaded constructor for the class that creates a class with a name input then assigns the pollution and depth of the clas to 100 and 20 respectivly
        {
            this.name = nameOne;
            this.pollution = 100;
            this.depth = 20;
        }
        //methods
        public void Look() //adds a random number to a given lake and displays the depth and pollution
        {
            Random randomGen = new Random();
            int randomDepth = randomGen.Next(1, 11);
            int randomPollution = randomGen.Next(1, 101);
            this.depth += randomDepth;
            this.pollution += randomPollution;
            Console.WriteLine("The {0} river has depth of {1} ft and a pollutoin level of {2}", this.Name, this.depth, this.pollution);
            WarningCheck(this.depth, this.pollution);
        }
        public void RiverDepth() // sets the depth of the river to a given user input
        {
            Console.WriteLine("what is the depth of the river?");
            this.depth = int.Parse(Console.ReadLine());
            WarningCheck(this.depth, this.pollution);

        }
        public void CleanRiver() // sets the pollution field equal to zero
        {
            this.pollution = 0;
        }
        public void LookDepth() // displays the depth field
        {
            Console.WriteLine("The {0} river has a depth of {1}", this.name, this.depth);
            WarningCheck(this.depth, this.pollution);
        }
        public void LookPollution() // displays the pollution field
        {
            
            Console.WriteLine("The {0} river has a pollution level of {1} ", this.name, this.pollution);
            WarningCheck(this.depth, this.pollution);
        }
        public void WarningCheck(int depthtest, int pollutiontest) // method used throughout this class that displays a warning if the depth or the pollution exceeds a value
        {
            string addWater;
            if (depthtest > 40) 

            {
                Console.WriteLine("The river has exceeded above acceptable depth levels");

            }
            if (pollutiontest > 1000)
            {
                Console.WriteLine("The river is too polluted");

            }
            if (depthtest < 10)
            {
                Console.WriteLine("Would you like to add water?");
                addWater= Console.ReadLine();
                if (addWater == "yes")
                {
                    this.depth = 20;
                }
            }
      
           
        }
        public void Drain() // sets the depth field equal to zero
        {
            this.depth = 0;
        }
        







    }

}


