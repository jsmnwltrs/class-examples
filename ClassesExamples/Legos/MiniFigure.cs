using ClassesExamples.Legos.Heads;
using ClassesExamples.Legos.Torsos;

namespace ClassesExamples.Legos
{
    class MiniFigure
    {
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public string Name { get; set; }
        public Legs.Legs Legs { get; set; }

        public MiniFigure(string name,Head head,Torso torso, Legs.Legs legs)
        {
            Head = head;
            Torso = torso;
            Name = name;
            Legs = legs;
        }

        public void Greet()
        {
            Torso.Wave();
            Legs.Walk();
            Head.Talk();
        }
    }
}
