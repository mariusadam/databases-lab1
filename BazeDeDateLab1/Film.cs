using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1
{
    public class Film
    {
        private string      title;
        private string      country;
        private int         year;
        private double      rating;
        private List<Actor> actors;

        public Film(string title, int year, string country, double rating)
        {
            this.title   = title;
            this.year    = year;
            this.country = country;
            this.rating  = rating;
            this.actors  = new List<Actor>();
        }

        public Film(string title, int year, string country,double rating, List<Actor> actors)
        {
            this.title   = title;
            this.year    = year;
            this.country = country;
            this.rating  = rating;
            this.actors  = actors;
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        
        public double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public List<Actor> Actors
        {
            get
            {
                return actors;
            }
            set
            {
                actors = value;
            }
        }

        public Film addActor(Actor actor)
        {
            this.actors.Add(actor);

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
            return obj is Film && ((Film)obj).Title == this.Title;
        }
    }
}
