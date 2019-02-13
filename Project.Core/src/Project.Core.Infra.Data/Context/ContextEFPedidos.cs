using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.Core.Domain.Pedidos.Entidades;
using System.IO;

namespace Project.Core.Infra.Data.Context
{
    public class ContextEFPedidos : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<ItensPedidos> ItensPedidos { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            dbContextOptionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
