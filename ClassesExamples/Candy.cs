using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        //Properties
        public string Flavor { get; }
        public int Rating { get; private set; }
        //you can set an initial value to a property. its called property initialization.
        //public int Rating { get; private set; } = 1
        public string Name { get; }
        public CandyType Type { get; }
        public string Review { get; private set; }

        //Fields
        const int MinRatingValue = 1; //Constant fields are named with Capitals.
        const int MaxRatingValue = 10;

        //Constructor
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        //Methods (function inside a class)
        public void SetRating(int userRating) //void is a return type that means this method won't return anything. Method signature: accessiblity, return type, name, parameter list
        {
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue} moron.");
            }
        }

        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}";
        }

        public 

    }
    enum CandyType //This is basically an options class.
    {
        Chocolate = 1, //You can set a number if you don't want Chocolate to be defaulted. In this case if 0 is returned then a type hasn't been given.
        HardCandy,
        Caramel,
        Sour,
        Stretchy,
        Nuts
    }
}
