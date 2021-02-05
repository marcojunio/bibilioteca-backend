using Bibilioteca.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibilioteca.API.Data
{
    public class DevLibraryDbContext : DbContext
    {
        public DevLibraryDbContext(DbContextOptions<DevLibraryDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Obra> Obras { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Editora>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Obra>()
                .HasKey(e => e.Id);
        }
    }
}
