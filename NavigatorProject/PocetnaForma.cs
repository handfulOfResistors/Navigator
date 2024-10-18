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
            ////ovde odraditi jedan upis u bazu za sliku i za pdf
            //byte[] ss = File.ReadAllBytes("C:\\Users\\Nemanja Pesic\\Downloads\\image.png");

            //using (var context = new ApplicationDbContext())
            //{
            //    // Assume you're updating or adding a specific 'Kandidat'
            //    var kandidat = context.Kandidati.Find(3);  // Find by ID or another criteria

            //    kandidat.Slika = ss;  // Assign the byte array to the PrilogCV property

            //    context.SaveChanges();  // Save changes to the database
            //}

            using (var novaForma = new NoviKandidatForma())
            {
                novaForma.ShowDialog(); // Prikazuje novu formu kao modal
            }
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            

        }

        private void PocetnaForma_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'navigatorDBDataSet.Kandidats' table. You can move, or remove it, as needed.
            

        }
    }
}
