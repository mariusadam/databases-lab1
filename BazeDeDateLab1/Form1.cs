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
        private FilmController controller;

        public Form1(FilmController ctrl)
        {
            this.controller = ctrl;
            InitializeComponent();
        }

        private void refreshMoviesListBox()
        {
            this.listBox1.Items.Clear();
            foreach(Film movie in this.controller.getAllMovies())
            {
                this.listBox1.Items.Add(movie);
            }
            this.listBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.refreshMoviesListBox();
        }

        public void reloadActorsListBox(List<Actor> list)
        {
            this.listBox2.Items.Clear();
            foreach (Actor actor in list)
            {
                this.listBox2.Items.Add(actor);
            }
            this.listBox2.Refresh();
        }

        public void refreshActorsListBox(Film movie)
        {
            this.reloadActorsListBox(this.controller.findByTitle(movie.Title).Actors);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film movie = (Film) this.listBox1.SelectedItem;
            this.refreshActorsListBox(movie);
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

        private List<Actor> getCurrentActors()
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
            this.controller.update(
                    selected.Title,
                    Convert.ToInt32(this.textBox2.Text.ToString()),
                    this.textBox3.Text.ToString(),
                    Convert.ToDouble(this.textBox4.Text.ToString()),
                    this.getCurrentActors()
                );
            this.refreshMoviesListBox();
            this.listBox1.SetSelected(this.listBox1.FindString(selected.Title), true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Film selected = (Film) this.listBox1.SelectedItem;
            if (selected == null)
            {
                return;
            }
            this.controller.delete(selected.Title);
            this.refreshMoviesListBox();
            this.reloadActorsListBox(new List<Actor>());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string title = this.textBox1.Text.ToString();
            int year = Convert.ToInt32(this.textBox2.Text.ToString());
            string country = this.textBox3.Text.ToString();
            double rating = Convert.ToDouble(this.textBox4.Text.ToString());

            try
            {
                Film movie = this.controller.create(title, year, country, rating, this.getCurrentActors());
                this.refreshMoviesListBox();
                this.refreshActorsListBox(movie);
            } catch (DuplicateTitleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Actor> actors = this.getCurrentActors();
            actors.Add(new Actor(this.textBox5.Text.ToString()));
            this.reloadActorsListBox(actors);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Actor selected = (Actor) this.listBox2.SelectedItem;
            if (selected == null)
            {
                return;
            }
            List<Actor> actors = this.getCurrentActors();
            actors.Remove(selected);
            this.reloadActorsListBox(actors);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actor selected = (Actor) this.listBox2.SelectedItem;
            if (selected == null)
            {
                return;
            }
            List<Actor> actors = this.getCurrentActors();
            selected.Name = this.textBox5.Text.ToString();
            actors[actors.FindIndex(actor => actor == selected)] = selected;
            this.reloadActorsListBox(actors);
        }
    }
}
