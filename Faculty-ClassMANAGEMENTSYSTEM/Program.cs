using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_ClassMANAGEMENTSYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========FACULTY CLASS MANAGEMENT SYSTEM==========");


            Console.WriteLine("User Login");

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
                FacultyoStudent();
            }


            else
            {
                Console.WriteLine("Invalid");
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
                        string[] Student = { "Josefina Anderson > BSBA 2-1",
                                             "Earl Lacson       > BSBA 2-1",
                                             "Andrew Soriano    > BSIT 2-1",
                                             "Richard Chua      > BSED 2-1",
                                             "Michael Kors      > BSED 2-1",
                                             " Alden Ford       > BSCA 2-1"};
                        foreach (string b in Student)
                        {
                            Console.WriteLine(b);
                        }
                    }
                }

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
                            viewFacilitatorSubjectDayTime();
                            break;

                        case 'C':
                            Console.WriteLine("The app is shutting Down, Thank You!");
                            break;
                    }

                    static void viewFacilitatorSubjectDayTime()
                    {


                        string[] Facilitator = { "Mr. Johnny Tayao    >Filipino               > MONDAY 7:30am - 10:30am",
                                                 "Mr. Alfred Bautista >Programming 3          > MONDAY 10:30am - 12:30pm",
                                                 "Dr. Ellen Santiago  >Understanding Self     > WEDNESDAY 10:30am - 12:30pm",
                                                 "Ms. Maria Del Valle >Network Administration > WEDNESDAY 2:00pm - 4:00pm",
                                                 "Ms. Darla Mae Cruz  >Discrete Mathematics   > FRIDAY 7:30am - 10:30am",
                                                 "Mr. Jonas Mendoza   >Physical Science       > FRIDAY 1:30pm - 3:00pm" };


                        foreach (string a in Facilitator)
                        {
                            Console.WriteLine(a);
                        }


                    }



                }

            }
        }
    }
}
