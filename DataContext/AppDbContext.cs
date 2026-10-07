using ApiTreino.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApiTreino.DataContext
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Processo>().HasData(
                new Processo {Id = -1, Titulo = "Avaria de computador", Descricao = "A tela está avariada." },
                new Processo {Id = -2, Titulo = "Power BI de compras", Descricao = "Preciso de uma dashboard para visualizar as compras." }
            );

            modelBuilder.Entity<Intervencao>().HasData(
                new Intervencao { Id = -1, ProcessoId = -1, Descricao = "Abriu-se o pc e verificou-se que o cabo de ligação ao ecrã estava danificado. Substitui-se o cabo." },
                new Intervencao { Id = -2, ProcessoId = -1, Descricao = "Foram efetuados testes de diagnóstico. Ficou tudo operacional." },

                new Intervencao { Id = -3, ProcessoId = -2, Descricao = "Levantamento de requisitos." },
                new Intervencao { Id = -4, ProcessoId = -2, Descricao = "Foi desenvolvido um protótipo funcional com alguns gráficos básicos." }
            );

           //odelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }*/
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Intervencao> Intervencoes { get; set; }
        public DbSet<AnexoIntervencao> AnexosIntervencoes { get; set; }
        public DbSet<AnexoProcesso> AnexosProcessos { get; set; }
        public DbSet<CategoriaProcesso> CategoriasProcessos { get; set; }
        public DbSet<Estado> Estados { get; set; }

    }
}
