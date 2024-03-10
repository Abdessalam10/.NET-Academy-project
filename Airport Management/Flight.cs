using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management
{
    public class Flight
    {
        public String Destination { get; set; }
        public String Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        public Plane MyPlane { get; set; }

        public IList<Passenger> Passengers { get; set; }
        public String Comment { get; set; }
       
        public override string ToString()
        {
            return "Destination:" + Destination
                + "Departure:" + Departure
                + "flightdate:" + FlightDate
                + "flightid:" + FlightId
                + "EffectiveArrival:" + EffectiveArrival
                + "EstimatedDuration:" + EstimatedDuration
                + "MyPlane:" + MyPlane
                ;
        }
    }
}
