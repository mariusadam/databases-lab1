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
        private FilmRepository repository;
        public FilmController(FilmRepository filmRepository)
        {
            repository = filmRepository;
        }

        public List<Film> getAllMovies()
        {
            return repository.Movies;
        }

        public Film findByTitle(string title)
        {
            return this.repository.findByTitle(title);
        }

        public Film create(string title, int year, string country, double rating, List<Actor> actors)
        {
            Film movie = new Film(title, year, country, rating, actors);
            this.repository.insert(movie);

            return movie;
        }

        public Film delete(string title)
        {
            return this.repository.delete(title);
        }

        public void update(string title, int newYear, string newCountry, double newRating, List<Actor> newActors)
        {
            Film movie    = this.findByTitle(title);
            movie.Year    = newYear;
            movie.Country = newCountry;
            movie.Rating  = newRating;
            movie.Actors  = newActors;

            this.repository.update(movie);
        }
    }
}
