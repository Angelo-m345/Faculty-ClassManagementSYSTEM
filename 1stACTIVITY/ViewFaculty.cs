using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class ViewFaculty  ////This class calls BSCE Faculty class and BSIT Faculty class

    {                          
        public static void Faculty()
        
        {
            Console.WriteLine("==========Faculty Assignment==========");
            Console.WriteLine("======================================");
            Console.WriteLine("Select C, I, or E options");
            Console.WriteLine(" C - View BSCE Facilitators");
            Console.WriteLine(" I - View BSIT Facilitators");
            Console.WriteLine(" E - Exit");
            char Faculty = Convert.ToChar(Console.ReadLine());
            Faculty = char.ToUpper(Faculty);

          
            

            switch (Faculty)
            {
               
                case 'C':
                    Console.WriteLine("==========BSCE 2 FACILITATORS==========");
                    BSCEFaculty.viewBSCEfacilitators();
                    break;

                case 'I':
                    Console.WriteLine("==========BSIT 2 FACILITATORS==========");
                    BSITFaculty.viewBSITfacilitators();
                    break;

                case 'E':
                    Console.WriteLine("The app is Shutting Down, Thank You!");
                    break;
            }

        }


      

       


    }

       
}
