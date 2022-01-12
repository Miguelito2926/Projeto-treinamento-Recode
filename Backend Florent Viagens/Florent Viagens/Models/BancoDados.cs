using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Florent_Viagens.Models
{
    public class BancoDados : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<DataViagem> DataViagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=FlorentViagens;Integrated Security=true");
        }

    }
}
