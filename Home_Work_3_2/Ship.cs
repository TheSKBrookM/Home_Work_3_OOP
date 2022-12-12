using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_2
{
    class Ship : Vehicle
    {
        private int passenger;
        private string port;

        public Ship(int vehicleCoordinateX, int vehicleCoordinateY, int price, int speed, int year)
            : base(vehicleCoordinateX, vehicleCoordinateY, price, speed, year)
        {

        }
        public Ship(int price, int speed, int year)
            : base(price, speed, year)
        {

        }
        public int Passenger
        {
            get { return passenger; }
            set { passenger = value; }
        }
        public string Port
        {
            get
            {
                if (port == null)
                {
                    return "Не вказано порт";
                }
                return port;
            }
            set
            {
                port = value;
            }
        }
    }
}
