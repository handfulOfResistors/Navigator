using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace NavigatorProject.Model
{
    public class Kandidat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "JMBG mora imati tačno 13 cifara.")]
        public string JMBG { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<string> DodatniLinkovi { get; set; } = new List<string>(); 

        public int Telefon { get; set; }

        public string Napomena { get; set; }

        public DateTime LastUpdate { get; set; } = DateTime.Now;

        public byte[] PrilogCV { get; set; } 

        public byte[] Slika { get; set; } 

        [Range(1, 5)]
        public int Ocena { get; set; } 

        public StatusKandidata Status { get; set; }

        public List<IstorijaStatusa> IstorijaStatusaKandidata { get; set; } = new List<IstorijaStatusa>();

    }
}
