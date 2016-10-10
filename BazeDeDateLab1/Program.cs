using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazeDeDateLab1.Repository;
using BazeDeDateLab1.Controller;

namespace BazeDeDateLab1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FilmRepository repo = new FilmRepository("C:\\Users\\marius\\Source\\Repos\\db-course-lab1\\BazeDeDateLab1\\filme.txt");
            FilmController ctrl = new FilmController(repo);

            Application.Run(new Form1(ctrl));
        }
    }
}
