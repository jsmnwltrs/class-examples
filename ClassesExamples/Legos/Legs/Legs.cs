using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Legs
{
    class Legs
    {
        public bool Hairy { get; set; }
        public Colors Color { get; set; }
        public bool CanBend { get; set; }
        public Length Length { get; set; }

        protected Legs(Length length, Colors color)
        {
            Length = length;
            Color = color;
        }

        public virtual void Jump()
        {
            Console.WriteLine("WEEEEEEEEEE!!!");
        }

        public void Kick(MiniFigure personToKick)
        {

            Console.WriteLine($"{personToKick.Name} just got kicked by {GetType().Name}. HAHAHAHAHAHA!!!");
        }

        public void Walk()
        {
            Console.WriteLine($"{GetType().Name} Took a few steps.");
        }


    }

    enum Length
    {
        Short,
        Medium,
        Long,
        SuperLong
    }
}

