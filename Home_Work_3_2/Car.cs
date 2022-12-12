using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_2
{
    class Car : Vehicle
    {
        public Car(int vehicleCoordinateX, int vehicleCoordinateY, int price, int speed, int year)
            : base(vehicleCoordinateX, vehicleCoordinateY, price, speed, year)
        {

        }

        public Car(int price, int speed, int year)
            : base(price, speed, year)
        { 
        
        }

    }
}
