using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct StructCoordinate
    {
      
       public double x;
       public double y;
       public double z;
        

        //public static int ADDcoordinate operator +(int x, int y, int z)
        //    {}
    public void  Platform(int xx, int yy, int zz)
    {
        x = xx;
        y = yy;
        z = zz;

    }
        public int Adding(int x)
        {
            return x + x;
        }
}

}



