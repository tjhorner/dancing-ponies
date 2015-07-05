using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyDancer.Ponies
{
    class Pony
    {
        // pony bitmaps
        internal Bitmap[] idlePositions;
        internal Bitmap[] dancePositions;

        // pony information
        internal string name = "Generic Pony";

        // position getters
        public Bitmap[] GetIdlePositions()
        {
            return this.idlePositions;
        }

        public Bitmap[] GetDancePositions()
        {
            return this.dancePositions;
        }

        // information getters
        public string GetName()
        {
            return this.name;
        }
    }
}
