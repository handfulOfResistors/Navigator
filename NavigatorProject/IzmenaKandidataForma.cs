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
using System.IO;

namespace NavigatorProject
{
    public partial class IzmenaKandidataForma : Form
    {
        private Kandidat _kandidat;
        public IzmenaKandidataForma(Kandidat kandidat) 
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
        private byte[] pictureBytes;
        private byte[] cvBytes;
        private void button1_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text and PDF Files (*.txt;*.pdf)|*.txt;*.pdf|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog.FileName;
                cvBytes = File.ReadAllBytes(filePath);
                MessageBox.Show("CV dodat: " + filePath);
                //_kandidat.PrilogCV = cvBytes;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBytes = File.ReadAllBytes(filePath);
                MessageBox.Show("Slika dodata: " + filePath);
                
            }
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
                kandidat.Ocena = (int)comboBox1.SelectedIndex + 1 ;
                kandidat.Status = (StatusKandidata)comboBox2.SelectedIndex;
                kandidat.PrilogCV = cvBytes;
                kandidat.Slika = pictureBytes;
                kandidat.LastUpdate = DateTime.Now;
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //ovde dodati updatovanje datagridview

                this.Close();
            }
            
        }
    }
}
