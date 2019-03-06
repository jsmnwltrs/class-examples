using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Bald : Head
    {
        //Properties
       
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }
        //Fields
        //Constructor
        //Methods
        public void Cut(HairLength newLength)
        {
            HairLength = newLength;
        }

        public override void Talk()
        {
            Console.WriteLine("Why me?");
        }



    }

    internal enum HairLength
    {
        CompletelyBald,
        Stubble,
        Short,
        Medium,
        Long
    }
}
