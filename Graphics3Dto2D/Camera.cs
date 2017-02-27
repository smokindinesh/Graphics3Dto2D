using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics3Dto2D
{
    class Camera
    {
        public _3Dpoint from;
        public _3Dpoint to;
        public _3Dpoint up;
        public double angleh, anglev;
        public double zoom;
        public double front, back;
        public short projection;
        public Camera()
        {
            from = new _3Dpoint(0, -50, 0);
            to = new _3Dpoint(0, 50, 0);
            up = new _3Dpoint(0, 0, 1);
            angleh = 45.0;
            anglev = 45.0;
            zoom = 1.0;
            front = 1.0;
            back = 200.0;
            projection = 0;

        }
    }
}
