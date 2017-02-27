using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics3Dto2D
{
    class _3Dpoint
    {
        public double x, y, z;
        public _3Dpoint(double xx, double yy, double zz)
        {
            x = xx;
            y = yy;
            z = zz;
        }
        public _3Dpoint()
        {
            x = 0;
            y = 0;
            z = 0;
        }
    }
}
