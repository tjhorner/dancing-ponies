using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonyDancer.Ponies
{
    class TwilightSparkle : Pony
    {
        private Bitmap[] idlePositions = { Twilight.stand_right };
        private Bitmap[] dancePositions = { Twilight.partyhard_left, Twilight.partyhard_right };

        public TwilightSparkle()
        {
            this.name = "Twilight Sparkle";
        }
    }
}
