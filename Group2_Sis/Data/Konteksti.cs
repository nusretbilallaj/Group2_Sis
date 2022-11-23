using Group2_Sis.Models;
using Microsoft.EntityFrameworkCore;


namespace Group2_Sis.Data
{
    public class Konteksti:DbContext
    {
        public Konteksti(DbContextOptions<Konteksti> options):base(options)
        {
            
        }

        public DbSet<Studenti> Studentet { get; set; }
        public DbSet<Komuna> Komunat { get; set; }

    }
}
