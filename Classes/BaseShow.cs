using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class BaseShow 
    {
        int x = 7;
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
        public  void CheckCar()
        {
            //const int t = 8;             
            device.ItsCar();
        }
        //TODO
        Device device = new Device();//TODO
        
        
        private struct Device
        {
            public int x;
            int y;
           
            public string ItsCar()
            {
                int x =8;
                return "oooo";
            }
            public Device(int a)
            {
                this.y = a; 
                this.x = a;
            }
        }

    }
}
