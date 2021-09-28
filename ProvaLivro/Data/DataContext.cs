using Microsoft.EntityFrameworkCore;
using ProvaLivro.Models;

namespace ProvaLivro.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Livro> TabLivro { get; set; }

    }
}