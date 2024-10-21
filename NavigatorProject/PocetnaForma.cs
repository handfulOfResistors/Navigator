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

        private void PocetnaStranicadataGridView_CellClick(object sender, DataGridViewCellEventArgs e) // ovu liniju treba izmeniti jer ne upisuje pravu vrednost u tempPDF
        {
            
            if (e.ColumnIndex == 9)
            {
                var kandidat = PocetnaStranicadataGridView.Rows[e.RowIndex].DataBoundItem as Kandidat;
                int kandId = kandidat.Id;
                
                if(kandidat.PrilogCV != null)
                {
                    try
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), "tempCV.pdf");
                        File.WriteAllBytes(tempFilePath, );
                        if (File.Exists(tempFilePath))
                        {
                            MessageBox.Show("PDF fajl je uspešno snimljen na: " + tempFilePath);
                            System.Diagnostics.Process.Start(tempFilePath); 
                        }
                        else
                        {
                            MessageBox.Show("PDF fajl nije uspešno snimljen.");
                        }
                        System.Diagnostics.Process.Start(tempFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske prilikom otvaranja PDF dokumenta " + ex.Message);
                    }
                }

            }

        }
    }
}
//private void PocetnaStranicadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
//{
//    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
//    {
//        var kandidat = PocetnaStranicadataGridView.Rows[e.RowIndex].DataBoundItem as Kandidat;

//        // Ako je kliknuta kolona PrilogCV, otvori PDF
//        if (PocetnaStranicadataGridView.Columns[e.ColumnIndex].Name == "PrilogCV")
//        {
//            if (kandidat.PrilogCV != null)
//            {
//                string tempFilePath = Path.Combine(Path.GetTempPath(), "tempCV.pdf");
//                File.WriteAllBytes(tempFilePath, kandidat.PrilogCV);
//                System.Diagnostics.Process.Start(tempFilePath);
//            }
//        }

//        // Ako je kliknuta kolona Slika, otvori sliku
//        else if (PocetnaStranicadataGridView.Columns[e.ColumnIndex].Name == "Slika")
//        {
//            if (kandidat.Slika != null)
//            {
//                string tempFilePath = Path.Combine(Path.GetTempPath(), "tempImage.jpg");
//                File.WriteAllBytes(tempFilePath, kandidat.Slika);
//                System.Diagnostics.Process.Start(tempFilePath);
//            }
//        }
//    }
//}