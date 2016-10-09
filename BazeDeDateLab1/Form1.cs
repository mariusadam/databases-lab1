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

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach(Film movie in this.controller.getAllMovies())
            {
                this.listBox1.Items.Add(movie.Title);
                foreach(Actor actor in movie.Actors)
                {
                    this.listBox2.Items.Add(actor.Name);
                }
            }
        }
    }
}
