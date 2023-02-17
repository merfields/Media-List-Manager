using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.MVVM
{
    public class ManagerContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Movie> Movies { get; set; } = null!;

        public ManagerContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = CnnVal("ExampleDB");
            optionsBuilder.UseNpgsql(connectionString);
        }

        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
