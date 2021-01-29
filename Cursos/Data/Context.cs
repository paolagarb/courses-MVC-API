using Cursos.Models;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
    }
}
