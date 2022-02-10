using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class BaseShow : BMW
    {
        public double CalcTorque(double value, double horsepower)
        {
            var torque = horsepower / value;
            if (torque < 100)
            {
                CarParts k = new CarParts();
                k.wheel.ToString();
                return torque = 0;
            }
            else
            {
                return torque;
            }


        }
        public void CheckCar()
        {




        }

    }
}
