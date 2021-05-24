using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stACTIVITY
{
    class ViewFaculty
    {

        public static void Faculty()
        {
            Console.WriteLine("Faculty >Subject >Day >Time");
            Console.WriteLine("===========================");
            Console.WriteLine("Select A, D, C, I, or E options");
            Console.WriteLine(" A - View BSBA Facilitators");
            Console.WriteLine(" D - View BSED Facilitators");
            Console.WriteLine(" A - View BSCE Facilitators");
            Console.WriteLine(" A - View BSIT Facilitators");
            Console.WriteLine(" E - Exit");
            char Faculty = Convert.ToChar(Console.ReadLine());
            Faculty = char.ToUpper(Faculty);


            switch (Faculty)
            {
                case 'A':
                    viewBSBAfacilitators();
                    break;

                case 'D':
                    viewBSEDfacilitators();
                    break;

                case 'C':
                    viewBSCEfacilitators();
                    break;

                case 'I':
                    viewBSITfacilitators();
                    break;

                case 'E':
                    Console.WriteLine("The app is shutting Down, Thank You!");
                    break;
            }

        }


        static void viewBSBAfacilitators()
        {


            string[] FacilitatorA = { "Mr. Johnny Tayao   >Filipinolohiya         > MONDAY 7:30am - 10:30am",
                                     "Mr. Conan Reyes     >Accounting Principles  > MONDAY 10:30am - 12:30pm",
                                     "Dr. Ellen Santiago  >Understanding Self     > WEDNESDAY 10:30am - 12:30pm",
                                     "Ms. Marie Del Pilar >Entrepreneurship       > WEDNESDAY 2:00pm - 4:00pm",
                                     "Ms. Darla Mae Cruz  >Discrete Mathematics   > FRIDAY 7:30am - 10:30am",
                                     "Mr. Jonas Mendoza   >Physical Science       > FRIDAY 1:30pm - 3:00pm" };


            foreach (string a in FacilitatorA)
            {
                Console.WriteLine(a);
            }


        }

        static void viewBSEDfacilitators()
        {


            string[] FacilitatorA = { "Mr. Johnny Tayao   >Filipinolohiya         > MONDAY 10:30am - 12:30pm",
                                     "Mr. Emerson Diaz    >Basic teaching         > MONDAY 10:30am - 12:30pm",
                                     "Dr. Ellen Santiago  >Understanding Self     > WEDNESDAY 10:30am - 12:30pm",
                                     "Dr. Juana Mirasol   >Curriculum Studies     > WEDNESDAY 2:00pm - 4:00pm",
                                     "Mr. Jonas Mendoza   >Physical Science       > FRIDAY 7:30am - 10:00am",  
                                     "Ms. Darla Mae Cruz  >Discrete Mathematics   > FRIDAY 10:30am - 12:30pm"};


            foreach (string a in FacilitatorA)
            {
                Console.WriteLine(a);
            }


        }

        static void viewBSCEfacilitators()
        {


            string[] FacilitatorA = { "Mr. Johnny Tayao   >Filipinolohiya         > TUESDAY 12:30pm - 3:30pm",
                                     "Mr. Alfred Bautista >Programming 3          > TUESDAY 3:30pm - 6:30pm",
                                     "Dr. Ellen Santiago  >Understanding Self     > WEDNESDAY 10:30am - 12:30pm",
                                     "Ms. Juliana Monte   >Data Structures        > WEDNESDAY 2:00pm - 4:00pm",
                                     "Ms. Darla Mae Cruz  >Discrete Mathematics   > FRIDAY 1:30pm - 3:30pm",
                                     "Mr. Jonas Mendoza   >Physical Science       > FRIDAY 10:30am - 12:00pm" };


            foreach (string a in FacilitatorA)
            {
                Console.WriteLine(a);
            }


        }

        static void viewBSITfacilitators()
        {


            string[] FacilitatorA = { "Mr. Johnny Tayao   >Filipinolohiya         > TUESDAY 7:30am - 10:30am",
                                     "Mr. Alfred Bautista >Programming 3          > TUESPDAY 10:30am - 12:30pm",
                                     "Dr. Ellen Santiago  >Understanding Self     > WEDNESDAY 10:30am - 12:30pm",
                                     "Ms. Maria Del Valle >Network Administration > WEDNESDAY 2:00pm - 4:00pm",
                                     "Ms. Darla Mae Cruz  >Discrete Mathematics   > THURSDAYDAY 7:30am - 10:30am",
                                     "Mr. Jonas Mendoza   >Physical Science       > THURSDAY 1:30pm - 3:00pm" };


            foreach (string a in FacilitatorA)
            {
                Console.WriteLine(a);
            }


        }
    }
}
