using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) // eu quero que vc herde do pai o construtor tal
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CinemaEntity>(new CinemaMap().Configure); //cria um novo usermap configurado com o configure da UserMap
            modelBuilder.Entity<EnderecoEntity>(new EnderecoMap().Configure);
            modelBuilder.Entity<SessaoEntity>(new SessaoMap().Configure);
        }
    }
}
