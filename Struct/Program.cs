using System;
using static Struct.t2;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {

            t2 t3 = new t2();
           
            Car car=new Car();
            car.Model = "";
            //car.


            StructCoordinate structCoordinate=new StructCoordinate();
            structCoordinate.Adding(7);
            StructCoordinate R;
            R.x = 9;          
            Coordinate point;
            point.x = 10;
            point.y = 20;
            Console.Write(point.x); //output: 10  
            Console.Write(point.y); //output: 20  
            //-----
            Coordinates points = new Coordinates(10, 20);
            Console.WriteLine(points.x); //output: 10  
            Console.WriteLine(points.y); //output: 20  
            //--    
            Console.WriteLine(point.x); //output: 0  
            Console.WriteLine(point.y); //output: 0  

            Coordinate cor = new Coordinate(8, 9);
            var x = cor + point;
            cor.Calc();
        }

       






        struct Coordinate
        {
            public int x;
            public int y;

            public static Coordinate operator +(Coordinate point_left, Coordinate point_right)
            {
                return new Coordinate(point_left.x + point_right.x, point_left.y + point_right.y);
            }

            public int Calc()
            {
                return x + y;
            }
            public Coordinate(int gven, int vle)
            {
                x = gven;
                y = vle;
            }
            //public Coordinate(int test2)
            //{
            //    x = test2;
            //    y = 0;
            //}
        }

        struct Coordinates
        {
            public int x;
            public int y;

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }


    }
        struct Coordinate3
        {
            public int x { get; set; }
            public int y { get; set; }
            public void SetOrigin()
            {
                this.x = 0;
                this.y = 0;
            }
        }
}

