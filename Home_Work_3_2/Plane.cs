using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_2
{
    class Plane : Vehicle
    {
        private int passenger;

        public Plane(int vehicleCoordinateX, int vehicleCoordinateY, int price, int speed, int year)
            : base(vehicleCoordinateX, vehicleCoordinateY, price, speed, year)
        {

        }
        public Plane(int price, int speed, int year)
            : base(price, speed, year)
        {

        }
        public int Height { get; set; }
        public int Passenger
        {
            get { return passenger; }
            set { passenger = value; }
        }
    }
}
