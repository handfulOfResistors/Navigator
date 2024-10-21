using NavigatorProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorProject
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

       

        private void DodajKandidata_Click(object sender, EventArgs e)
        {
            

            using (var novaForma = new NoviKandidatForma())
            {
                novaForma.ShowDialog(); // Prikazuje novu formu kao modal
            }
        }

        

        private void PocetnaForma_Load_1(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            using (var context = new ApplicationDbContext())
            {

                var kandidati = context.Kandidati.ToList();
                

                
                PocetnaStranicadataGridView.DataSource = kandidati;
            }

        }
    }
}
