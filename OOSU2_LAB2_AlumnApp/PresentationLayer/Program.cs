using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.Contexts;

namespace PresentationLayer
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
            Application.Run(new LoginForm());

            AlumniKontaktContext alumnikontaktcontext = new AlumniKontaktContext();

            alumnikontaktcontext.Database.EnsureDeleted();
            alumnikontaktcontext.Database.EnsureCreated();

            Console.ReadLine();

        }
    }
}
