using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public String PassportNumber { get; set; }
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }

        public String LastName { get; set; }
        public String TelNumber { get; set; }

        public IList<Flight> Flights { get; set; }
        private int age;
        public int Age
        {
            get
            {
                age = DateTime.Now.Year - BirthDate.Year;
                if ((BirthDate.Month > DateTime.Now.Month)
                    || ((BirthDate.Month == DateTime.Now.Month)
                    && (BirthDate.Day > DateTime.Now.Day)))
                    age--;
                return age;
            }
        }
        public override string ToString()
        {
            return "BirdhDate :" + BirthDate
                + "PassportNumber : " + PassportNumber
                + "EmailAddress :" + EmailAddress
                + "FirstName :" + FirstName
                + "LastName :" + LastName
                + "TelNumber :" + TelNumber
                ;
        }

        //public Boolean CheckProfile(String nom,String prenom)
        //{
        //    return FirstName==nom && LastName==prenom;
        //}
        //public Boolean CheckProfile(String nom, String prenom,String email)
        //{
        //    return FirstName == nom && LastName == prenom && EmailAddress==email;
        //}
        public Boolean CheckProfile(String nom, String prenom, String email = null)
        {
            if (email == null)
                return FirstName == nom && LastName == prenom;

            return FirstName == nom && LastName == prenom && EmailAddress == email;

        }

        public virtual string GetPassengerType()
        {
            return "I am a passenger ";
        }
     
        public void GetAge(DateTime birthDate, ref int calculatedAge)// ref 
        {
            calculatedAge = DateTime.Now.Year - birthDate.Year;
            if ((birthDate.Month > DateTime.Now.Month)
                || ((birthDate.Month == DateTime.Now.Month)
                && (birthDate.Day > DateTime.Now.Day)))
                calculatedAge--;
        }
        public void GetAge(Passenger aPassenger)
        {
            //aPassenger.Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
            //if ((aPassenger.BirthDate.Month > DateTime.Now.Month)
            //    || ((aPassenger.BirthDate.Month == DateTime.Now.Month)
            //    && (aPassenger.BirthDate.Day > DateTime.Now.Day)))
            //    aPassenger.Age--;
        }
        





    }
}
