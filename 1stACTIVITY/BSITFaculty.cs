using System;
using System.Collections.Generic;
using System.Text;

namespace _1stACTIVITY
{
    class BSITFaculty  //This Class contains list of BSIT Facilitators together with their subject, day and time.
                       //called by ViewFaculty class
    {
        public static void viewBSITfacilitators()
        {


            string[] FacilitatorA = {"Mr. Johnny Tayao    >Filipinolohiya         > TUESDAY 7:30am - 10:30am",
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
