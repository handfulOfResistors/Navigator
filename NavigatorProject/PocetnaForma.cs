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
                ////////////////////////////////promena postojecih kolona da prikazuju ikone
                foreach(DataGridViewRow row in PocetnaStranicadataGridView.Rows)
                {
                    Size newSize = new Size(25,25);
                    var kandidat = row.DataBoundItem as Kandidat;
                    if(kandidat.PrilogCV != null)
                    {
                        
                        row.Cells["PrilogCV"].Value = ResizeImage(Properties.Resources.pdf, newSize);
                    }
                    if (kandidat.Slika != null)
                    {
                        row.Cells["Slika"].Value = ResizeImage(Properties.Resources.pic, newSize); 
                    }
                }


            }

        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void PocetnaStranicadataGridView_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            Kandidat newKand;
            var kandidat = PocetnaStranicadataGridView.Rows[e.RowIndex].DataBoundItem as Kandidat;
            int kandId = kandidat.Id;
            ////////////////////////////////////////Klik na sliku radi kako sam zamislio
            if (e.ColumnIndex == 10)
            {
                using (var context = new ApplicationDbContext())
                {
                    newKand = context.Kandidati.FirstOrDefault(k=>k.Id == kandId);
                    MessageBox.Show($"Veličina PrilogCV: {newKand.PrilogCV.Length} bajtova");   
                }
                if(newKand.Slika != null) 
                {
                    try
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), "tempPicture.png");
                        File.WriteAllBytes(tempFilePath, newKand.Slika);
                        if (File.Exists(tempFilePath))
                        {
                            MessageBox.Show("Slika je uspešno snimljena na: " + tempFilePath);
                            System.Diagnostics.Process.Start(tempFilePath); 
                        }
                        else
                        {
                            MessageBox.Show("Slika nije uspešno snimljena.");
                        }
                        System.Diagnostics.Process.Start(tempFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske prilikom otvaranja Slike " + ex.Message);
                    }
                }
            }
            if(e.ColumnIndex == 9)
            {

            }
        }
    }
}
