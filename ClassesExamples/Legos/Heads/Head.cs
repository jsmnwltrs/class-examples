﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Legos.Heads
{
    abstract class Head
    {
        public Colors Color { get; protected set; }
        public HairLength HairLength { get; protected set; }
        public string EarSize { get; protected set; }

        public virtual void Talk()
        {
            Console.WriteLine("I'm a talking head.");
        }
    }
}
