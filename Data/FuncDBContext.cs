using Microsoft.EntityFrameworkCore;
using UniversidadAsync.Models;

namespace UniversidadAsync.Data
{
    public class FuncDBContext : DbContext
    {
        public FuncDBContext(DbContextOptions<FuncDBContext> options) :
            base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

    }
}
