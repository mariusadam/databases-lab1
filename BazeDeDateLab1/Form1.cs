using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazeDeDateLab1.Controller;
using BazeDeDateLab1.Exception;

namespace BazeDeDateLab1
{
    public partial class Form1 : Form
    {
        private FilmController Controller;

        public Form1(FilmController ctrl)
        {
            this.Controller = ctrl;
            InitializeComponent();
        }

        private void RefreshMoviesListBox()
        {
            this.moviesListBox.Items.Clear();
            foreach(Film movie in this.Controller.GetAllMovies())
            {
                this.moviesListBox.Items.Add(movie);
            }
            this.moviesListBox.Refresh();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.RefreshMoviesListBox();
        }

        private void ReloadActorsListBox(List<Actor> list)
        {
            this.actorsListBox.Items.Clear();
            foreach (Actor actor in list)
            {
                this.actorsListBox.Items.Add(actor);
            }
            this.actorsListBox.Refresh();
        }

        private void RefreshActorsListBox(Film movie)
        {
            this.ReloadActorsListBox(this.Controller.FindByTitle(movie.Title).Actors);
        }

        private void moviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film movie = (Film) this.moviesListBox.SelectedItem;
            this.RefreshActorsListBox(movie);
            this.titleTextBox.Text = movie.Title;
            this.yearTextBox.Text = Convert.ToString(movie.Year);
            this.countryTextBox.Text = movie.Country;
            this.ratingTextBox.Text = Convert.ToString(movie.Rating);
        }

        private void actorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actor actor = this.actorsListBox.SelectedItem as Actor;
            if (actor == null)
            {
                return;
            }
            this.actorNameTextBox.Text = actor.Name;
        }

        private List<Actor> GetCurrentActors()
        {
            List<Actor> actors = new List<Actor>();
            foreach(Actor item in this.actorsListBox.Items)
            {
                actors.Add(item);
            }

            return actors;
        }

        private void updateMovieButton_Click(object sender, EventArgs e)
        {
            Film selected = (Film) this.moviesListBox.SelectedItem;
            if (selected == null)
            {
                return;
            }
            this.Controller.Update(
                    selected.Title,
                    Convert.ToInt32(this.yearTextBox.Text.ToString()),
                    this.countryTextBox.Text.ToString(),
                    Convert.ToDouble(this.ratingTextBox.Text.ToString()),
                    this.GetCurrentActors()
                );
            this.RefreshMoviesListBox();
            this.moviesListBox.SetSelected(this.moviesListBox.FindString(selected.Title), true);
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            Film selected = (Film) this.moviesListBox.SelectedItem;
            if (selected == null)
            {
                return;
            }
            this.Controller.Delete(selected.Title);
            this.RefreshMoviesListBox();
            this.ReloadActorsListBox(new List<Actor>());
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            string title = this.titleTextBox.Text.ToString();
            int year = Convert.ToInt32(this.yearTextBox.Text.ToString());
            string country = this.countryTextBox.Text.ToString();
            double rating = Convert.ToDouble(this.ratingTextBox.Text.ToString());

            try
            {
                Film movie = this.Controller.Create(title, year, country, rating, this.GetCurrentActors());
                this.RefreshMoviesListBox();
                this.RefreshActorsListBox(movie);
            } catch (DuplicateTitleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addActorButton_Click(object sender, EventArgs e)
        {
            List<Actor> actors = this.GetCurrentActors();
            actors.Add(new Actor(this.actorNameTextBox.Text.ToString()));
            this.ReloadActorsListBox(actors);
        }

        private void deleteActorButton_Click(object sender, EventArgs e)
        {
            Actor selected = (Actor) this.actorsListBox.SelectedItem;
            if (selected == null)
            {
                return;
            }
            List<Actor> actors = this.GetCurrentActors();
            actors.Remove(selected);
            this.ReloadActorsListBox(actors);
        }

        private void updateActorButton_Click(object sender, EventArgs e)
        {
            Actor selected = (Actor) this.actorsListBox.SelectedItem;
            if (selected == null)
            {
                return;
            }
            List<Actor> actors = this.GetCurrentActors();
            selected.Name = this.actorNameTextBox.Text.ToString();
            actors[actors.FindIndex(actor => actor == selected)] = selected;
            this.ReloadActorsListBox(actors);
        }
    }
}
