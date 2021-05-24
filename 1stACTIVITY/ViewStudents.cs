using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class ViewStudents
    {
        public static void Student()

        {
            Console.WriteLine("Student Inquiry");
            Console.WriteLine("=============");
            Console.WriteLine("Type A, D, C, I, or E");
            Console.WriteLine(" A - View BSBA-2 Students");
            Console.WriteLine(" D - View BSED-2 Students");
            Console.WriteLine(" C - View BSCE-2 Students");
            Console.WriteLine(" I - View BSIT-2 Students");
            Console.WriteLine(" E - Exit");
            char Student = Convert.ToChar(Console.ReadLine());
            Student = char.ToUpper(Student);

            switch (Student)
            {
                case 'A':
                    Console.WriteLine("==========BSBA 2 Students==========");
                    viewBSBA2Students();
                    break;

                case 'D':
                    Console.WriteLine("==========BSED 2 Students==========");
                    viewBSED2Students();
                    break;

                case 'C':
                    Console.WriteLine("==========BSCE 2 Students==========");
                    viewBSCE2Students();
                    break;

                case 'I':
                    Console.WriteLine("==========BSIT 2 Students==========");
                    viewBSIT2Students();
                    break;

                case 'E':
                    Console.WriteLine("The App is Shutting Down, Thank You!");
                    break;
            }
            static void viewBSBA2Students()
            {
                string[] StudentA = {"Virgilio Santos    ",
                                     "Ramon Buenaventura ",
                                     "Estrella Concio    ",
                                     "Rodrigo Valentino  ",
                                     "Esperanza Reyes    ",
                                     "Andres Garcia      ",
                                     "Carlito Del Mundo  ",
                                     "Angelito Diumano   "};
                                           
                foreach (string b in StudentA)
                {
                    Console.WriteLine(b);
                }
            }

            static void viewBSED2Students()
            {
                string[] StudentD = {"Darlene Delos Santos ",
                                     "Ma Angela Buenconsejo",
                                     "Juan Enrico Dela Rosa",
                                     "Valerie Montemayor   ",
                                     "Monalisa Anderson    ",
                                     "Christine Reyes      ",
                                     "Dolores AArevalo     ",
                                     "Miyuki Oka           "};

                foreach (string b in StudentD)
                {
                    Console.WriteLine(b);
                }
            }

            static void viewBSCE2Students()
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

            static void viewBSIT2Students()
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
}
