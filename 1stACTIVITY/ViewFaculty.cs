using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class ViewFaculty
    {

        static void Faculty()
        {
            Console.WriteLine("Faculty >Subject >Day >Time");
            Console.WriteLine("===========================");
            Console.WriteLine("Select V or C options");
            Console.WriteLine(" V - View Facilitators, Subject, Day and Time");
            Console.WriteLine(" C - Cancel");
            char Faculty = Convert.ToChar(Console.ReadLine());
            Faculty = char.ToUpper(Faculty);


            switch (Faculty)
            {
                case 'V':

                    break;

                case 'C':
                    Console.WriteLine("The app is shutting Down, Thank You!");
                    break;
            }

        }
    }
}
