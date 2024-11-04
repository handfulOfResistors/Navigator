using NavigatorProject.Model;
using OfficeOpenXml;
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
using LicenseContext = OfficeOpenXml.LicenseContext;

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
                novaForma.FormClosed += (s, args) => LoadData();
                novaForma.ShowDialog(); 
            }
            
            
        }

        

        public void PocetnaForma_Load_1(object sender, EventArgs e)
        {

            LoadData();

        }
        private void LoadData()
        {
            using (var context = new ApplicationDbContext())
            {
                var kandidati = context.Kandidati.ToList();
                PocetnaStranicadataGridView.DataSource = kandidati;
                PocetnaStranicadataGridView.Columns["Id"].Visible = false;

                foreach (DataGridViewRow row in PocetnaStranicadataGridView.Rows)
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
                }
                if(newKand.Slika != null) 
                {
                    try
                    {
                        string tempFilePath = Path.Combine(Path.GetTempPath(), "tempPicture.png");
                        File.WriteAllBytes(tempFilePath, newKand.Slika);
                        if (File.Exists(tempFilePath))
                        {
                            
                            System.Diagnostics.Process.Start(tempFilePath); 
                        }
                        else
                        {
                            MessageBox.Show("Slika nije uspešno snimljena.");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske prilikom otvaranja Slike " + ex.Message);
                    }
                }
            }
            if(e.ColumnIndex == 9)
            {
                using (var context = new ApplicationDbContext())
                {
                    newKand = context.Kandidati.FirstOrDefault(k => k.Id == kandId);
                }
                if (newKand.PrilogCV != null)
                {
                    try
                    {
                        string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"Downloads", "Kandidat - CV.pdf");
                        File.WriteAllBytes(downloadPath,newKand.PrilogCV);
                        ///////////////
                        if (File.Exists(downloadPath))
                        {
                            
                            System.Diagnostics.Process.Start(downloadPath);

                        }
                        else
                        {
                            MessageBox.Show("cv nije uspešno preuzet.");
                        }
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske prilikom cuvanja  " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = TekstZaPretragutextBox.Text;
            long brojJMBG;

            if (tekst == "")
            {
                LoadData();
            }
            else if (long.TryParse(tekst,out brojJMBG))
            {
                List<Kandidat> kandidatiSaJMBG;
                using (var context = new ApplicationDbContext())
                {
                    string Jm = brojJMBG.ToString();
                    kandidatiSaJMBG = context.Kandidati
                        .Where(k=>k.JMBG == Jm) .ToList();
                    
                }
                PocetnaStranicadataGridView.DataSource = kandidatiSaJMBG;
                foreach (DataGridViewRow row in PocetnaStranicadataGridView.Rows)
                {
                    Size newSize = new Size(25, 25);
                    var kandidatl = row.DataBoundItem as Kandidat;
                    if (kandidatl.PrilogCV != null)
                    {
                        row.Cells["PrilogCV"].Value = ResizeImage(Properties.Resources.pdf, newSize);
                    }
                    if (kandidatl.Slika != null)
                    {
                        row.Cells["Slika"].Value = ResizeImage(Properties.Resources.pic, newSize);
                    }
                }


            }
            else 
            {
                List<Kandidat> kandidatiSaImenomIliPrezimenom;
                using (var context = new ApplicationDbContext()) 
                {
                    kandidatiSaImenomIliPrezimenom = context.Kandidati
                        .Where(k => k.Ime == tekst || k.Prezime ==tekst ).ToList();
                }

                PocetnaStranicadataGridView.DataSource = kandidatiSaImenomIliPrezimenom;
                foreach (DataGridViewRow row in PocetnaStranicadataGridView.Rows)
                {
                    Size newSize = new Size(25, 25);
                    var kandidatl = row.DataBoundItem as Kandidat;
                    if (kandidatl.PrilogCV != null)
                    {
                        row.Cells["PrilogCV"].Value = ResizeImage(Properties.Resources.pdf, newSize);
                    }
                    if (kandidatl.Slika != null)
                    {
                        row.Cells["Slika"].Value = ResizeImage(Properties.Resources.pic, newSize);
                    }
                }

            }
            
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(PocetnaStranicadataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = PocetnaStranicadataGridView.SelectedRows[0];
                Kandidat KandidatZaIzmenu = new Kandidat();
                var c = selectedRow.Cells[0].Value.ToString();
                int.TryParse(c, out int KandidatZaIzm);
                
                using (var context = new ApplicationDbContext())
                {
                    int kandID = KandidatZaIzm;
                    var kandidat = context.Kandidati.FirstOrDefault(k=>k.Id==kandID);
                    KandidatZaIzmenu = kandidat;
                }

               
                IzmenaKandidataForma izmenaKandidataForma = new IzmenaKandidataForma(KandidatZaIzmenu);
               // izmenaKandidataForma.ShowDialog();

                var selectedRoww = PocetnaStranicadataGridView.SelectedRows[0];
                var selectedCandidate = (Kandidat)selectedRoww.DataBoundItem;
                using (var izmenaForma = new IzmenaKandidataForma(selectedCandidate))
                {
                    izmenaForma.FormClosed += (s, args) => LoadData();
                    izmenaForma.ShowDialog();
                }

            }
            else {
                MessageBox.Show("Klikni na red kandidata kojeg zelis da izmenis");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PocetnaStranicadataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = PocetnaStranicadataGridView.SelectedRows[0];
                int kandidatId = (int)selectedRow.Cells[0].Value;
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovog kandidata?",
                                              "Potvrda brisanja",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var kandidat = context.Kandidati.SingleOrDefault(k => k.Id == kandidatId);
                        if(kandidat != null)
                        {
                            context.Kandidati.Remove(kandidat);
                            context.SaveChanges();
                            LoadData();
                            MessageBox.Show("Kandidat je uspesno obrisan");
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Klikni na red kandidata kojeg zelis da obrises");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Kandidati");
                for (int i = 0; i < PocetnaStranicadataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = PocetnaStranicadataGridView.Columns[i].HeaderText;
                }

                // Add all rows from DataGridView to the worksheet
                for (int rowIndex = 0; rowIndex < PocetnaStranicadataGridView.Rows.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < PocetnaStranicadataGridView.Columns.Count; colIndex++)
                    {
                        worksheet.Cells[rowIndex + 2, colIndex + 1].Value = PocetnaStranicadataGridView.Rows[rowIndex].Cells[colIndex].Value?.ToString() ?? "";
                    }
                }
                using (var saveFileDialog = new SaveFileDialog { Filter = "Excel Files|*.xlsx", DefaultExt = "xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = saveFileDialog.FileName;
                        File.WriteAllBytes(filePath, package.GetAsByteArray());
                        MessageBox.Show("Podaci su uspešno izvezeni u Excel dokument.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
