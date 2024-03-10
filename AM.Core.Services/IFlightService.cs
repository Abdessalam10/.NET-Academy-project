using Airport_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IFlightService
    {
        IList<DateTime> GetFlightDates(string Destination);

        void ShowFlightDetails(Plane plane);

        int GetWeeklyFlightNumber(DateTime date);

        double GetDurationAverage(String destination);

        IList<Flight> SortFlights();

        IList<Passenger> GetThreeOlderTravellers(Flight flight);

        void ShowGroupedFlights();

        IList<Flight> GetFlights(string filterType, string filtreValue);

        delegate int GetScore(Passenger passenger);

        Passenger GetSeniorPassenger(GetScore meth);
    }
}

