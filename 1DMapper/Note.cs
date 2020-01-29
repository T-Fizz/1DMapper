using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DMapper
{
    class Note
    {
        public float time;
        public int x;
        public int y;
        public bool trailUp;
        public bool trailDown;
        public bool trailLeft;
        public bool trailRight;

        public Note(float t, int x, int y, bool tu, bool td, bool tl, bool tr)
        {
            time = t;
            this.x = x;
            this.y = y;
            trailUp = tr;
            trailDown = td;
            trailLeft = tl;
            trailRight = tr;
        }
    }
}
