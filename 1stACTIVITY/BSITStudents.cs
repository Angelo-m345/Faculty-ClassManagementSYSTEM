using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class BSITStudents  //This Class contains list of BSIT students.
                        //called by ViewStudent class
    {
        public static void BSIT2Students()
        {
            string[] StudentI = {"Alfredson Brown     ",
                                     "Rodrigo Gracio      ",
                                     "Juan Miguel Castro  ",
                                     "Gabriel Angelo Magno",
                                     "Peterson Alvarado   ",
                                     "Rita Manuela Santos ",
                                     "Virgilio Vicente    ",
                                     "Armando Bagatsing   ",};

            foreach (string b in StudentI)
            {
                Console.WriteLine(b);
            }
        }
    }
}
