using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Legs
{
    class PegLeg : Legs
    {
        public PegLeg(Length legLength) : base(legLength,Colors.Tan)
        {
        }

        public override void Jump()
        {
            Console.WriteLine($"I can't jump with {(Hairy ? "hairy": "")} peg legs. :(");
        }
    }
}
