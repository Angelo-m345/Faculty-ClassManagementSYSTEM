using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
     class BSCEStudents//This Class contains list of BSCE students.
                       //called by ViewStudent class



    {

        public static void BSCE2Students()
            {
                string[] StudentC = {"Ralph Talay     ",
                                     "Francisco Reyes ",
                                     "Rody Bartolome  ",
                                     "Alyanna Romero  ",
                                     "Robert Alarcon  ",
                                     "Andrew Emerson  ",
                                     "Joshua Vilanueva",
                                     "Jason Batumbkal "};

                foreach (string b in StudentC)
                {
                    Console.WriteLine(b);
                }
            }

           
    }
}

