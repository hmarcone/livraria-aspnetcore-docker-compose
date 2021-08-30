using Microsoft.EntityFrameworkCore;

namespace Livraria.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}
