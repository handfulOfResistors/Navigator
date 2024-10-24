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

//status nesto ne radi kako treba, izbacuje status nije validan.
//Dodatni Linkovi popraviti. Ne postoji u bazi a u modelu ga ima
//istorija promena statusa kandidata napraviti da radi
//Poslati mail sa pitanjem Datum i vreme izmene podataka(last_update) i Istorija promena statusa kandidata koja je razlika. Ako pre toga sam ne mogu da zakljucim