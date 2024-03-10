using Airport_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class FlightService : IFlightService//
    {
        public IList<Flight> Flights { get; set; }

        public double GetDurationAverage(string destination)
        {
            return (from flight in Flights
                    where (flight.Destination == destination)
                    select flight.EstimatedDuration)
                    .Average();
        }

        public IList<DateTime> GetFlightDates(string destination)
        {
            return
            (from flight in Flights
             where flight.Destination == destination
             select flight.FlightDate).ToList(); //ToList()

            //2eme méthode
            return Flights.Where(f => f.Destination == destination)
                .Select(f => f.FlightDate).ToList();
        }

        public IList<Flight> GetFlights(string filterType, string filtreValue)
        {
            PropertyInfo property = typeof(Flight).GetProperty(filterType);

            if (property == null)
            {
                return new List<Flight>();
            }

            return (from flight in Flights
                    where property.GetValue(flight)?.ToString() == filtreValue
                    select flight).ToList();

        }

        public Passenger GetSeniorPassenger(IFlightService.GetScore meth)
        {

            return Flights.SelectMany(f => f.Passengers)
                .MaxBy(p => meth(p));
        }

        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            return flight.Passengers.OrderByDescending(Age => Age).Take(3).ToList();

        }

        public int GetWeeklyFlightNumber(DateTime date)
        {
            DateTime d = date.AddDays(7);
            return Flights.Count(f => f.FlightDate >= date && f.FlightDate < d);

        }



        public void ShowFlightDetails(Plane plane)
        {
            var matchingFlights =
                from flight in Flights
                where flight.MyPlane.PlaneId == plane.PlaneId
                select new
                {
                    destination = flight.Destination,
                    date = flight.FlightDate
                };
            foreach (var obj in matchingFlights)
            {
                Console.WriteLine("Destination \n" + obj.destination
                    + "\n Date \n" + obj.date);
            }

        }

        public void ShowGroupedFlights()
        {

            var groups = Flights.GroupBy(flight => flight.Destination);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var flight in group)
                {
                    Console.WriteLine(flight);
                }
            }
        }

        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(flight => flight.EstimatedDuration)
                .ToList();

        }
    }
}
