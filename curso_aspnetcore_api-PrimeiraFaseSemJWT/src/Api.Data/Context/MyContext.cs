using Api.Data.Mapping;
using Api.Domain.Entities;
using Data.Mapping;
using Data.Seeds;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context {
    public class MyContext : DbContext {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext (DbContextOptions<MyContext> options) : base (options) // eu quero que vc herde do pai o construtor tal
        { 
            Database.Migrate();
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<UserEntity> (new UserMap().Configure); //cria um novo usermap configurado com o configure da UserMap
            modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);
            modelBuilder.Entity<CepEntity>(new CepMap().Configure);

            UfSeeds.Ufs(modelBuilder); // esses seeds ja vai fazer parte da migracao

        }

        
    }
}

/*
 * contexto é o cara que recebe as tabelas relacionadas a entidade que esta na dominio
 * 
 * 
 */