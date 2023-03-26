using AppReact._2_Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AppReact._2_Domain
{
    public class App_DbContext : DbContext
    {

        public App_DbContext(DbContextOptions<App_DbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
    }
}
