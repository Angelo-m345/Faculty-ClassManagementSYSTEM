using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class ViewStudent //This class calls the BSCE students class and BSIT students class
    {
        public static void Student()


        {
            Console.WriteLine("==========Student Room Assignment==========");
            Console.WriteLine("===========================================");
            Console.WriteLine("Type C, I, or E");
            Console.WriteLine(" C - View BSCE-2 Students");
            Console.WriteLine(" I - View BSIT-2 Students");
            Console.WriteLine(" E - Exit");
            char Student = Convert.ToChar(Console.ReadLine());
            Student = char.ToUpper(Student);

            switch (Student)
            {


                case 'C':
                    Console.WriteLine("==========BSCE 2 Students==========");
                    BSCEStudents.BSCE2Students();
                    break;

                case 'I':
                    Console.WriteLine("==========BSIT 2 Students==========");
                    BSITStudents.BSIT2Students();
                    break;

                case 'E':
                    Console.WriteLine("The App is Shutting Down, Thank You!");
                    break;
            }

        }
    }
}
