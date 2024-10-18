using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigatorProject.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbContext") // dodajemo connectionString
        {

        }
        public DbSet<Kandidat> Kandidati { get; set; }
        public DbSet<IstorijaStatusa> IstorijeStatusa { get; set; }


    }
}
