using editaisAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace editaisAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Concurso>? Concursos { get; set; }
        public DbSet<Disciplina>? Disciplinas { get; set; }
        public DbSet<Prova>? Provas { get; set; }
        public DbSet<TopicoPai>? TopicoPais { get; set; }
        public DbSet<TopicoFilho>? TopicoFilhos { get; set; }
        public DbSet<TopicoNeto>? TopicoNetos { get; set; }

    }
}
