using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management
{
    public class Traveller : Passenger
    {
        public String HealthInformation { get; set; }
        public String Nationality { get; set; }
        public override string ToString()
        {
            return base.ToString()
                + " HealthInformation : " + HealthInformation
                + "Nationality :" + Nationality
                ;


        }

        public override string GetPassengerType()
        {
            return " I am a Traveller ";
        }


    }
}
