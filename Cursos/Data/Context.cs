using Cursos.Models;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
    }
}
