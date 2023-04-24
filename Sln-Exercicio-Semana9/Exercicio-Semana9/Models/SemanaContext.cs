using Microsoft.EntityFrameworkCore;

namespace Exercicio_Semana9.Models
{
    public class SemanaContext : DbContext
    {
        /* outra maneira de fazer o conected string 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\.;database=Semana";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        */
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options) 
        {
        }
        public DbSet <SemanaModel> Semana {get; set;}
    }
}
