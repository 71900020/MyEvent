using Microsoft.EntityFrameworkCore;
using MyEvent.Data.Mappings;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Usuario> TBUsuario { get; set; }
        public DbSet<Local> TBLocal { get; set; }
        public DbSet<Evento> TBEvento { get; set; }
        public DbSet<Convidado> TBConvidado { get; set; }
        public DbSet<Tarefa> TBTarefa { get; set; }
        public DbSet<Gasto> TBGasto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Local>(new LocalMap().Configure);
            modelBuilder.Entity<Evento>(new EventoMap().Configure);
            modelBuilder.Entity<Convidado>(new ConvidadoMap().Configure);
            modelBuilder.Entity<Tarefa>(new TarefaMap().Configure);
            modelBuilder.Entity<Gasto>(new GastoMap().Configure);
        }
    }
}
