using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorProject.Model
{
    public class IstorijaStatusa
    {
        [Key]
        public int Id { get; set; } 
        public StatusKandidata Status { get; set; }
        public DateTime LastUpdate { get; set; } = DateTime.Now;
    }
}
