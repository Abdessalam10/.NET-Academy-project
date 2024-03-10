using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management
{
    public enum PlaneType
    {
        Boing, AirBus
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Capacity:" + Capacity
                + "ManufactureDate:" + ManufactureDate
                + "PlaneId:" + PlaneId
                + "planetype:" + MyPlaneType
                ;
        }
        public Plane(PlaneType MyPlaneType, int capacity, DateTime date)
        {
            this.MyPlaneType = MyPlaneType;
            Capacity = capacity;
            ManufactureDate = date;
        }
        public Plane()
        {

        }
    }
}
