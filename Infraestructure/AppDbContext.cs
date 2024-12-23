using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infraestructure
{
    public class AppDbContext:DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = SRVMIO;" +
                    "initial catalog=VentaDB; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true");
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UEI11; " +
                "Database=VentaDB; User Id=sa; Pwd=Hrm260381;" +
                "Trust Server Certificate=True ");
        }

    }
}
