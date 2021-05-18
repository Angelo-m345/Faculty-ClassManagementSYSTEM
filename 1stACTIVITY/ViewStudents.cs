using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class ViewStudents
    {
        static void Student()
        {
            Console.WriteLine("Student's Name >Section");
            Console.WriteLine("=============");
            Console.WriteLine("Type V or C");
            Console.WriteLine(" V - View Students, Section");
            Console.WriteLine(" C - Cancel");
            char Student = Convert.ToChar(Console.ReadLine());
            Student = char.ToUpper(Student);

            switch (Student)
            {
                case 'V':
                    viewStudentsNameSection();
                    break;

                case 'C':
                    Console.WriteLine("The App is Shutting Down, Thank You!");
                    break;
            }
            static void viewStudentsNameSection()
            {
                string[] Student = { "Ron Jovi Letriro  > BSBA 2-1",
                                     "Adrian Alejandre  > BSBA 2-1",
                                     "Angelo Mangahas   > BSIT 2-1" };
                                           
                foreach (string b in Student)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
