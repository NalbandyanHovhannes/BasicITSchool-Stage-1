using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {

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



        }
        struct Coordinate
        {
            public int x;
            public int y;
     
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

        struct Coordinate3
        {
            public int x { get; set; }
            public int y { get; set; }

            public  void SetOrigin()
            {
                this.x = 0;
                this.y = 0;
            }
        }

    }
}

