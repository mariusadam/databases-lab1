using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.*
namespace BazeDeDateLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Film> readFromFuckingFile(string filename)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(filename);
            List<Film> moviesList = new List<Film>();



            return moviesList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
