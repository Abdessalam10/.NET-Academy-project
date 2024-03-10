// See https://aka.ms/new-console-template for more information
using Airport_Management;
using AM.Data;

Console.WriteLine("Hello, World!");
Plane p = new Plane();
p.Capacity = 1;
p.ManufactureDate = DateTime.Now;
p.MyPlaneType = PlaneType.Boing;
p.PlaneId = 1;

Plane p2 = new Plane(PlaneType.AirBus, 2, DateTime.Now);

Plane p3 = new Plane()
{
    Capacity = 3,
    ManufactureDate = DateTime.Now,
    MyPlaneType = PlaneType.AirBus
};
Passenger tr = new Traveller();
Passenger passenger = new Traveller();
Passenger staff = new Staff();
Console.WriteLine(tr.GetPassengerType());
Console.WriteLine(passenger.GetPassengerType());
Console.WriteLine(staff.GetPassengerType());

Passenger pp = new Passenger()
{
    BirthDate = new DateTime(2000, 1, 1)
};
pp.GetAge(pp);
Console.WriteLine(pp.Age);
int age = 0;
//pp.GetAge(new DateTime(2000, 1, 1), age);
pp.GetAge(new DateTime(2000, 1, 1), ref age);

Console.WriteLine(age);
//AMContext context = new AMContext();
Plane p1 = new Plane()
{
    Capacity = 10,
    
    MyPlaneType = PlaneType.AirBus,
    ManufactureDate = DateTime.Now,
};
Flight f1 = new Flight()
{
    Comment = "comment",
    Departure = "departure",
    Destination = "destination",
    EffectiveArrival = new DateTime(2021, 02, 1),
    EstimatedDuration = 2,
    FlightDate = new DateTime(2021, 02, 1),
    MyPlane = p1
};
AMContext context = new AMContext();
context.Add(p1);
context.Add(f1);  // Multiple ( Ajout en mémoire)
context.SaveChanges();