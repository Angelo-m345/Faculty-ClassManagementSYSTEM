using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class UserLogin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Login");

            ViewStudents UserLogin = new ViewStudents();

            string usernameC = ("PUPuser");
            string passwordC = ("P103003");

            string username, password;

            Console.Write("username: ");
            username = Console.ReadLine();
            Console.Write("password: ");
            password = Console.ReadLine();


            if (username == usernameC && password == passwordC)
            {
                Console.WriteLine("Successfully Logged In");


            }


            else
            {
                Console.WriteLine("Invalid");
            }
        }
        static void FacultyoStudent()
        {
            Console.WriteLine("Faculty or Student");
            Console.WriteLine("==================");
            Console.WriteLine("Type S, F, or E");
            Console.WriteLine("S - Student's Name >Section");
            Console.WriteLine("F - Faculty >Subject >Day >Time");
            Console.WriteLine("E - Exit");
            char FacultyoStudent = Convert.ToChar(Console.ReadLine());
            FacultyoStudent = char.ToUpper(FacultyoStudent);

            switch (FacultyoStudent)
            {
                case 'S':
                    Student();
                    break;

                case 'F':
                    Faculty();
                    break;

                case 'E':
                    Console.WriteLine("The app is Shuting Down, Thank You!");
                    break;
            }



        }
    }
}
