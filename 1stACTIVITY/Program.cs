using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class Program     //This class is the main method of the program.
                      
                      
    {
      

       public static void Main(string[] args)
        {
           
            Console.WriteLine("==========FACULTY CLASS MANAGEMENT SYSTEM==========");


            UserLogin UL = new UserLogin();

            UL.Login();

        }
    }
}
