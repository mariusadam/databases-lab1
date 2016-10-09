using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1.Repository
{
    public class FilmRepository
    {
        private string     filename;
        private List<Film> movies;

        public FilmRepository(string filename)
        {
            this.filename = filename;
            this.movies   = new List<Film>();
            this.loadFromFile();
        }

        ~FilmRepository()
        {
            this.saveToFile();
        }

        private void loadFromFile()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(this.filename);
            string line = null, title, country;
            string[] parts, actorsParts;
            char[] comma = { ',' }, semicolon = { ';' };
            int year;
            double rating;
            List<Actor> actors = new List<Actor>();

            while (line != null)
            {
                line = file.ReadLine();
                parts = line.Split(comma);
                title = parts[0];
                country = parts[1];
                year = Convert.ToInt32(parts[2]);
                rating = Convert.ToDouble(parts[3]);
                actorsParts = parts[4].Split(semicolon);
                actors.Clear();
                foreach (string name in actorsParts)
                {
                    actors.Add(new Actor(name));
                }
                this.movies.Add(new Film(title, year, country, rating, actors));
            }
            file.Close();
        }
        private void saveToFile()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(this.filename);
            StringBuilder actorsString = new StringBuilder();

            foreach(Film movie in this.movies)
            {
                actorsString.Clear();
                foreach(Actor actor in movie.Actors)
                {
                    actorsString.AppendFormat("{0};", actor.Name);
                }
                if(actorsString.Length != 0)
                {
                    actorsString.Remove(actorsString.Length - 1, 1);
                }

                file.WriteLine(
                    string.Format("{0},{1},{2},{3},{4}",
                        movie.Title,
                        movie.Country,
                        Convert.ToString(movie.Year),
                        Convert.ToString(movie.Rating),
                        actorsString
                        )
                    );
            }

            file.Close();
        }

        public List<Film> Movies
        {
            get
            {
                return movies;
            }
        }
    }
}
