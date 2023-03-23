using Dominio.Model;
using Microsoft.EntityFrameworkCore;

namespace Dominio
{
    public class App_DbContext: DbContext
    {

        public App_DbContext(DbContextOptions<App_DbContext> options) : base(options)
        {

        }
      
        public DbSet<Aluno> Aluno { get; set; }
    }
}
