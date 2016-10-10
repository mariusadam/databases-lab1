using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazeDeDateLab1.Exception;

namespace BazeDeDateLab1.Repository
{
    public class FilmRepository
    {
        public string     Filename { get; }
        public List<Film> Movies   { get; }

        public FilmRepository(string filename)
        {
            this.Filename = filename;
            this.Movies   = new List<Film>();
            this.LoadFromFile();
        }

        ~FilmRepository()
        {
            this.SaveToFile();
        }

        private void LoadFromFile()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(this.Filename);
            string line = null, title, country;
            string[] parts, actorsParts;
            char[] comma = { ',' }, semicolon = { ';' };
            int year;
            double rating;

            line = file.ReadLine();
            while (line != null)
            {
                parts = line.Split(comma);

                if (parts.Length != 5)
                {
                    line = file.ReadLine();
                    continue;
                }

                title = parts[0];
                country = parts[1];
                year = Convert.ToInt32(parts[2]);
                rating = Convert.ToDouble(parts[3]);
                actorsParts = parts[4].Split(semicolon);
                List<Actor> actors = new List<Actor>();
                foreach (string name in actorsParts)
                {
                    actors.Add(new Actor(name));
                }
                this.Movies.Add(new Film(title, year, country, rating, actors));

                line = file.ReadLine();
            }
            file.Close();
        }
        private void SaveToFile()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(this.Filename);
            StringBuilder actorsString = new StringBuilder();

            foreach(Film movie in this.Movies)
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

        public void Insert(Film movie)
        {
            try
            {
                this.FindByTitle(movie.Title);
                throw new DuplicateTitleException("This movie is already added!");
            } catch (ItemNotFoundException ex)
            {
                this.Movies.Add(movie);
                this.SaveToFile();
            }
            
        }

        public Film FindByTitle(string title)
        {
            Film result = this.Movies.Find(movie => movie.Title == title);

            if (result == default(Film))
            {
                throw new ItemNotFoundException();
            }

            return result;
        }

        public Film Delete(string title)
        {
            Film movie = this.FindByTitle(title);
            this.Movies.Remove(movie);
            this.SaveToFile();
            return movie;
        }

        public void Update(Film newMovie)
        {
            int poz = this.Movies.FindIndex(movie => movie.Title == newMovie.Title);

            if (poz == -1)
            {
                throw new ItemNotFoundException();
            }

            this.Movies[poz] = newMovie;
            this.SaveToFile();
        }
    }
}
