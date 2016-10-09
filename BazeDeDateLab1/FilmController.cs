using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazeDeDateLab1.Repository;

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
    }
}
