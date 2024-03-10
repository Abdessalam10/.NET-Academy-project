using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public String Function { get; set; }
        public float Salary { get; set; }
        public override string ToString()
        {

            return base.ToString() +
                " EmployementDate  : " + EmployementDate
              + "Function :" + Function
              + "Salary :" + Salary
             ;
        }

        public override string GetPassengerType()
        {
            return "I am a passenger I am a Staff Member ";
        }

    }
}
