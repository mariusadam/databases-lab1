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
            this.listBox1.Items.Clear();
            foreach(Film movie in this.Controller.GetAllMovies())
            {
                this.listBox1.Items.Add(movie);
            }
            this.listBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RefreshMoviesListBox();
        }

        private void ReloadActorsListBox(List<Actor> list)
        {
            this.listBox2.Items.Clear();
            foreach (Actor actor in list)
            {
                this.listBox2.Items.Add(actor);
            }
            this.listBox2.Refresh();
        }

        private void RefreshActorsListBox(Film movie)
        {
            this.ReloadActorsListBox(this.Controller.FindByTitle(movie.Title).Actors);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film movie = (Film) this.listBox1.SelectedItem;
            this.RefreshActorsListBox(movie);
            this.textBox1.Text = movie.Title;
            this.textBox2.Text = Convert.ToString(movie.Year);
            this.textBox3.Text = movie.Country;
            this.textBox4.Text = Convert.ToString(movie.Rating);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actor actor = this.listBox2.SelectedItem as Actor;
            if (actor == null)
            {
                return;
            }
            this.textBox5.Text = actor.Name;
        }

        private List<Actor> GetCurrentActors()
        {
            List<Actor> actors = new List<Actor>();
            foreach(Actor item in this.listBox2.Items)
            {
                actors.Add(item);
            }

            return actors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Film selected = (Film) this.listBox1.SelectedItem;
            if (selected == null)
            {
                return;
            }
            this.Controller.Update(
                    selected.Title,
                    Convert.ToInt32(this.textBox2.Text.ToString()),
                    this.textBox3.Text.ToString(),
                    Convert.ToDouble(this.textBox4.Text.ToString()),
                    this.GetCurrentActors()
                );
            this.RefreshMoviesListBox();
            this.listBox1.SetSelected(this.listBox1.FindString(selected.Title), true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Film selected = (Film) this.listBox1.SelectedItem;
            if (selected == null)
            {
                return;
            }
            this.Controller.Delete(selected.Title);
            this.RefreshMoviesListBox();
            this.ReloadActorsListBox(new List<Actor>());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string title = this.textBox1.Text.ToString();
            int year = Convert.ToInt32(this.textBox2.Text.ToString());
            string country = this.textBox3.Text.ToString();
            double rating = Convert.ToDouble(this.textBox4.Text.ToString());

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

        private void button7_Click(object sender, EventArgs e)
        {
            List<Actor> actors = this.GetCurrentActors();
            actors.Add(new Actor(this.textBox5.Text.ToString()));
            this.ReloadActorsListBox(actors);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Actor selected = (Actor) this.listBox2.SelectedItem;
            if (selected == null)
            {
                return;
            }
            List<Actor> actors = this.GetCurrentActors();
            actors.Remove(selected);
            this.ReloadActorsListBox(actors);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actor selected = (Actor) this.listBox2.SelectedItem;
            if (selected == null)
            {
                return;
            }
            List<Actor> actors = this.GetCurrentActors();
            selected.Name = this.textBox5.Text.ToString();
            actors[actors.FindIndex(actor => actor == selected)] = selected;
            this.ReloadActorsListBox(actors);
        }
    }
}
