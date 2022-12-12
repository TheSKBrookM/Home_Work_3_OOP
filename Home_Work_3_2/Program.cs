namespace Home_Work_3_2
{
    class Program
    {
        static void Main()
        {
            Car car = new Car(100000, 220, 2014);

            Ship ship = new Ship(3000000, 600, 2018);
            ship.Passenger = 300;
            ship.Port = "Odesa";

            Plane plane = new Plane(40000000, 1200, 2015);
            plane.Passenger = 150;
            plane.Height = 10000;

            Console.WriteLine($"Цiна машини {car.Price}, швидкiсть {car.Speed}, рiк випуска {car.Year}");

            Console.WriteLine("Цiна корабля {0}, швидкiсть {1}, рiк випуску {2}, кiлькiсть пасажирiв {3}, порт приписки {4}", ship.Price, ship.Speed, ship.Year, ship.Passenger, ship.Port);

            Console.WriteLine("Цiна лiтака " + plane.Price + ", швидкiсть " + plane.Speed + ", рiк випуску " + plane.Year + ", кiлькiсть пасажирiв " + plane.Passenger + ", висота польоту " + plane.Height);

            Console.ReadKey();
        }
    }
}