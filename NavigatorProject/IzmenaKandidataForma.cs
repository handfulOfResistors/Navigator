using NavigatorProject.Model;
using System.Data.Entity.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace NavigatorProject
{
    public partial class IzmenaKandidataForma : Form
    {
        private Kandidat _kandidat;
        public IzmenaKandidataForma(Kandidat kandidat) // Treba dodati logiku za izmenu slike i cv-a
        {

            
            InitializeComponent();
            _kandidat = kandidat;
            textBox1.Text = _kandidat.Ime;
            textBox2.Text = _kandidat.Prezime;
            textBox3.Text = _kandidat.JMBG;
            dateTimePicker1.Value = _kandidat.DatumRodjenja;
            textBox4.Text = _kandidat.Email;
            textBox5.Text = _kandidat.Telefon.ToString();
            textBox6.Text = _kandidat.Napomena;
            //ovde _kandidat vec sadrzi Slika i PrilogCV.
            

            
                
            
        }





















        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ovo sam slucajno dodao obrisati kasnije
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //ovde treba dodati logiku da kad se doda slika, to isto promeni vrednost u _kandidat.PrilogCV.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ovde treba dodati logiku da kad se doda slika, to isto promeni vrednost u _kandidat.Slika.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ovde treba dodati logiku za cuvanje izmenjenog kandidata
            //ovde uzeti polje iz baze: 
            using (var context = new ApplicationDbContext())
            {
                var kandidat = context.Kandidati.FirstOrDefault(k => k.Id == _kandidat.Id);
                kandidat.Ime = textBox1.Text;
                kandidat.Prezime = textBox2.Text;
                kandidat.JMBG = textBox3.Text;
                kandidat.DatumRodjenja = dateTimePicker1.Value;
                kandidat.Email = textBox4.Text;
                int tk;
                int.TryParse(textBox5.Text, out tk);
                kandidat.Telefon = tk;
                kandidat.Napomena = textBox6.Text;
                kandidat.Ocena = (int)comboBox1.SelectedIndex;
                kandidat.Status = (StatusKandidata)comboBox2.SelectedIndex;
                
                kandidat.LastUpdate = DateTime.Now;
                context.SaveChanges();

                //ovde dodati updatovanje datagridview
                
                this.Close();
            }
            
        }
    }
}
