using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    class Dog : Head
    {
        public override void Talk()
        {
            Console.WriteLine("Bark! I'm a dog head.");
        }

        public string Lick()
        {
            return "Tastes like human";
        }
    }

}
