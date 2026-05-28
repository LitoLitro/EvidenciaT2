using Microsoft.EntityFrameworkCore;
using T2_Quispe_Gustavo.Models;

namespace T2_Quispe_Gustavo.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Distribuidor> Distribuidor { get; set; }

    }
}
