using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PocetnaForma());
        }
    }
}



//Dodatni Linkovi popraviti. Ne postoji u bazi a u modelu ga ima
//da se pokrene LoadData() nakon izvrsetka izmeni kandidata
//cv i slika kod izmeni kandidata proveriti i doraditi da radi