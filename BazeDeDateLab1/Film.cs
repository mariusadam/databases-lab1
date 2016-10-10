using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1
{
    public class Film
    {
        public string      Title   { get; }
        public string      Country { set; get; }
        public int         Year    { set; get; }
        public double      Rating  { set; get; }
        public List<Actor> Actors  { set; get; }

        public Film(string title, int year, string country, double rating)
        {
            this.Title   = title;
            this.Year    = year;
            this.Country = country;
            this.Rating  = rating;
            this.Actors  = new List<Actor>();
        }

        public Film(string title, int year, string country,double rating, List<Actor> actors)
        {
            this.Title   = title;
            this.Year    = year;
            this.Country = country;
            this.Rating  = rating;
            this.Actors  = actors;
        }

        public Film addActor(Actor actor)
        {
            this.Actors.Add(actor);

            return this;
        }

        public override string ToString()
        {
            return String.Format(
                        "{0} | {1} | {2} | {3}",
                        this.Title,
                        this.Country,
                        Convert.ToString(this.Year),
                        Convert.ToString(this.Rating)
                    );
        }

        public override bool Equals(object obj)
        {
            return obj is Film && (obj as Film).Title == this.Title;
        }
    }
}
