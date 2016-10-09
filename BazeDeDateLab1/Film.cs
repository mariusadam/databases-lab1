using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1
{
    class Film
    {
        private string      __title;
        private string      __country;
        private int         __year;
        private double      __rating;
        private List<Actor> __actors;

        public Film(string title, int year, string country,double rating)
        {
            __title   = title;
            __year    = year;
            __country = country;
            __rating  = rating;
            __actors = new List<Actor>(0);
        }

        public string Title
        {
            get
            {
                return __title;
            }
            set
            {
                __title = value;
            }
        }

        public int Year
        {
            get
            {
                return __year;
            }
            set
            {
                __year = value;
            }
        }
        
        public double Rating
        {
            get
            {
                return __rating;
            }
            set
            {
                __rating = value;
            }
        }

        public string Country
        {
            get
            {
                return __country;
            }
            set
            {
                __country = value;
            }
        }

        public List<Actor> Actors
        {
            get
            {
                return __actors;
            }
            set
            {
                __actors = value;
            }
        }
    }
}
