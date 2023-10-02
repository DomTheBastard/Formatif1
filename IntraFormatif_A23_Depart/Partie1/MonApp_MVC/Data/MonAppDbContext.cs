using Microsoft.EntityFrameworkCore;
using MonApp_MVC.Entities;

namespace MonApp_MVC.Data
{
    public class MonAppDbContext: DbContext
    {
        public MonAppDbContext(DbContextOptions<MonAppDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

        public DbSet<Tournoi> Tournoi { get; set; }

        public DbSet<Joueur> Joueur { get; set; }

        public DbSet<FicheOfficielle> FicheOfficielle { get; set; }

        public DbSet<Equipe> Equipe { get; set; }
    }
}
