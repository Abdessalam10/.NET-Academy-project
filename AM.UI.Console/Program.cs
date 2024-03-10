// See https://aka.ms/new-console-template for more information
using Airport_Management;

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

