using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazeDeDateLab1.Repository;
using BazeDeDateLab1.Exception;

namespace BazeDeDateLab1.Controller
{
    public class FilmController
    {
        private FilmRepository Repository;
        public FilmController(FilmRepository filmRepository)
        {
            Repository = filmRepository;
        }

        public List<Film> GetAllMovies()
        {
            return Repository.Movies;
        }

        public Film FindByTitle(string title)
        {
            return this.Repository.FindByTitle(title);
        }

        public Film Create(string title, int year, string country, double rating, List<Actor> actors)
        {
            Film movie = new Film(title, year, country, rating, actors);
            this.Repository.Insert(movie);

            return movie;
        }

        public Film Delete(string title)
        {
            return this.Repository.Delete(title);
        }

        public void Update(string title, int newYear, string newCountry, double newRating, List<Actor> newActors)
        {
            Film movie    = this.FindByTitle(title);
            movie.Year    = newYear;
            movie.Country = newCountry;
            movie.Rating  = newRating;
            movie.Actors  = newActors;

            this.Repository.Update(movie);
        }
    }
}
