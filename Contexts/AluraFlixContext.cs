using Microsoft.EntityFrameworkCore;
using Model;

namespace Contexts
{
    public class AluraFlixContext : DbContext 
    {
        public DbSet<Videos> Videos { get; set; } //Nome da propriedade é o nome da tabela que o core entende.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = ANTHONYWINDOWS; Database = AluraFlix; Trusted_Connection = True;");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
