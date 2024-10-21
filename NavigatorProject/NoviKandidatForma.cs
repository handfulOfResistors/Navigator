using NavigatorProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigatorProject
{
    public partial class NoviKandidatForma : Form
    {
        private byte[] cvBytes;
        private byte[] pictureBytes;
        private string ime;
        private string prezime;
        private int jmbg;
        private DateTime DatumRodjenja;
        private string email;
        private int telefon;
        private string napomena;
        private DateTime LastUpdate;
        private int Ocena;
        private StatusKandidata status;
        public NoviKandidatForma()
        {
            InitializeComponent();
            
            CVAddedStatus.Text="";
            PictureAddedStatus.Text="";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text and PDF Files (*.txt;*.pdf)|*.txt;*.pdf|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog.FileName;
                cvBytes = File.ReadAllBytes(filePath);
                MessageBox.Show("CV dodat: " + filePath);
                CVAddedStatus.Text = "CV dodat";
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
                PictureAddedStatus.Text = "Slika dodata";
            }
        }

        private void DodajKandidata_Click(object sender, EventArgs e)
        {
            Kandidat kandidat = new Kandidat();
            kandidat.Ime = ImeBox.Text;
            kandidat.Prezime= PrezimeBox.Text;
            kandidat.JMBG= JMBGBox.Text;
            kandidat.DatumRodjenja = DatumRodjenjaTimePicker.Value;
            kandidat.Email= EmailBox.Text;
            kandidat.Telefon= int.Parse(TelefonBox.Text);
            kandidat.Napomena= NapomenaBox.Text;    
            kandidat.PrilogCV = cvBytes;
            kandidat.Slika = pictureBytes;
            kandidat.Ocena = OcenacomboBox.SelectedIndex + 1; // ovo je index to je valjda ok
            

            string selectedStatus = StatuscomboBox.SelectedItem.ToString();

            // Pokušaj da konvertuješ izabranu vrednost u StatusKandidata enum
            if (Enum.TryParse(selectedStatus, out StatusKandidata status))
            {
                kandidat.Status = status; 
                
            }
            else
            {
                MessageBox.Show("Izabrani status nije validan."); 
            }

            using (var context = new ApplicationDbContext()) 
            {
                context.Kandidati.Add(kandidat);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Kandidat uspešno dodat u bazu.");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} - Error: {validationError.ErrorMessage}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške: " + ex.Message);
                }
            }



        }

        private void NoviKandidatForma_Load(object sender, EventArgs e)
        {
            
            PoslednjaIzmenaTimePicker.Format = DateTimePickerFormat.Custom;
            PoslednjaIzmenaTimePicker.CustomFormat = "dd.MM.yyyy";
        }



    }
}
