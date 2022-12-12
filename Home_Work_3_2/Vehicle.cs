using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_2
{
    class Vehicle
    {

        readonly int vehicleCoordinateX;
        readonly int vehicleCoordinateY;
        readonly int price;
        readonly int speed;
        readonly int year;

        public int VehicleCoordinateX
        {
            get { return vehicleCoordinateX; }
        }
        public int VehicleCoordinateY
        {
            get { return vehicleCoordinateY; }
        }
        public int Price
        {
            get { return price; }
        }
        public int Speed
        {
            get { return speed; }
        }
        public int Year
        {
            get { return year; }
        }
        public Vehicle(int vehicleCoordinateX, int vehicleCoordinateY, int price, int speed, int year)
        {
            this.vehicleCoordinateX = vehicleCoordinateX;
            this.vehicleCoordinateY = vehicleCoordinateY;
            this.price = price;
            this.speed = speed;
            this.year = year;

        }
        public Vehicle(int price, int speed, int year)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;

        }
    }
}
