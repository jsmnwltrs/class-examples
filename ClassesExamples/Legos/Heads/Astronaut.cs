using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Astronaut : Head
    {
        public List<string> Accessories { get; set; }

        public override void Talk()
        {
            Console.WriteLine($"Houston we have a problem. I have {HairLength} hair and I'm {Color} and my ears are {EarSize}");
        }
    }
}
