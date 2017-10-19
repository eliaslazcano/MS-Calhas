using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MS_Calhas.Model
{
    class Banco : DbContext
    {
        //tabelas:
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        //configurações:
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BancoDados.db");
        }
    }
}
