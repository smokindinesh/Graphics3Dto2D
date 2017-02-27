using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics3Dto2D
{
    class Screen
    {
        public _2Dpoint center;
        public _2Dpoint size;
        public Screen()
        {
            center = new _2Dpoint(720, 420);
            size = new _2Dpoint(800, 800);
        }
    }
}
