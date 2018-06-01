using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the first river?");
            string riverOne = Console.ReadLine();
            Console.WriteLine("what is the name of the second river?");
            string riverTwo = Console.ReadLine();
            string userInput = "yes";
            River ohio = new River(riverOne);
            River Lake = new River(riverTwo);
            
            Console.WriteLine("The {0} river has a pollution level of {1} and a depth of {2}", ohio.Name, ohio.Pollution, ohio.Depth);
            Console.WriteLine("The {0} river has a pollution level of {1} and a depth of {2}", Lake.Name, Lake.Pollution, Lake.Depth);

            {
               


                Console.WriteLine("Which river would you like to manage? or type quit to quit");
                string rivername = Console.ReadLine().ToLower();
                if (rivername == riverOne)
                {
                    do
                    {
                      
                        Console.WriteLine("What would you like to do. Options include: riverstatus, riverdepth, cleanriver, drainriver, depthinput, riverpollution, return,  or help for more information");
                        userInput = Console.ReadLine();
                        if (userInput == "riverdepth")
                        {
                            ohio.LookDepth();
                        }
                        else if (userInput == "riverstatus")
                        {
                            ohio.Look();
                        }
                        else if (userInput == "cleanriver")
                        {
                            ohio.CleanRiver();
                            ohio.LookPollution();
                        }
                        else if (userInput == "drainriver")
                        {
                            ohio.Drain();
                            ohio.LookDepth();
                        }
                        else if (userInput == "help")
                            {
                            Console.WriteLine();
                                Console.WriteLine("riverstatus checks the pollution and depth levels for the river?");
                                Console.WriteLine("river depth checks the depth of the river");
                                Console.WriteLine("cleanriver is a reduction of the pollution level");
                                Console.WriteLine("drainriver will reduce the water level");
                                Console.WriteLine("depthinput allows you to input the rivers depth");
                                Console.WriteLine("riverpollution shows the pollution level of the river");
                                Console.WriteLine("return will return you to lake selection");
                            Console.WriteLine();
                            }
                        else if (userInput == "riverpollution")
                        {
                            ohio.LookPollution();

                        }
                        else if (userInput == "depthinput")
                        {
                            ohio.RiverDepth();

                        }
                    }
                    while (userInput != "return" );

                        

                }
                if (rivername == riverTwo)
                {
                    do
                    {
                    
                        Console.WriteLine("What would you like to do. Options include: riverstatus, riverdepth, cleanriver, drainriver, depthinput, riverpollution, or to go back type return");
                        userInput = Console.ReadLine();
                        if (userInput == "riverdepth")
                        {
                           Lake.LookDepth();
                        }
                        else if (userInput == "riverstatus")
                        {
                            Lake.Look();
                        }
                        else if (userInput == "cleanriver")
                        {

                            Lake.CleanRiver();
                            Lake.LookPollution();
                        }
                        else if (userInput == "drainriver")
                        {
                            Lake.Drain();
                            Lake.LookDepth();
                        }
                            else if (userInput == "help")
                            {
                            Console.WriteLine();
                                Console.WriteLine("riverstatus checks the pollution and depth levels for the river?");
                                Console.WriteLine("river depth checks the depth of the river");
                                Console.WriteLine("cleanriver is a reduction of the pollution level");
                                Console.WriteLine("drainriver will reduce the water level");
                                Console.WriteLine("depthinput allows you to input the rivers depth");
                                Console.WriteLine("riverpollution shows the pollution level of the river");
                                Console.WriteLine("return will return you to lake selection");

                            Console.WriteLine();

                        }
                        else if (userInput == "riverpollution")
                        {
                            Lake.LookPollution();

                        }
                        else if (userInput == "depthinput")
                        {
                            Lake.RiverDepth();

                        }
                        
                    }
                    while (userInput != "return");
                        if (rivername == "quit")
                        {
                            return;
                        }




                 

               
             


                    
                }
        }

    }
    }
}
