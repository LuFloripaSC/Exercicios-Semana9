using Microsoft.EntityFrameworkCore;

namespace Exercicio_Semana9.Models
{
    public class SemanaContext : DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options) 
        {
        }
        public DbSet <SemanaModel> Semana {get; set;}
    }
}
