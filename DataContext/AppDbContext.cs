using ApiTreino.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTreino.DataContext
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
     public DbSet<Processo> Processos { get; set; }
     public DbSet<Intervencao> Intervencoes { get; set; }
    }
}
