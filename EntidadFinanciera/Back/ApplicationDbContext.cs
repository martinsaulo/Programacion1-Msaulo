using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Back
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<TarjetaCredito> TarjetasDeCredito { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-FU6CNU8\\SQLEXPRESS;database=MiLibroDeRecetasBDD;trusted_connection=true;Encrypt=False");
        }
    }
}
