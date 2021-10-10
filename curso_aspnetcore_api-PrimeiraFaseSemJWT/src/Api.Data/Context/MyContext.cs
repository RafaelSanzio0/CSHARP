using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context {
    public class MyContext : DbContext {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext (DbContextOptions<MyContext> options) : base (options) { // eu quero que vc herde do pai o construtor tal
            Database.Migrate();
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);
            modelBuilder.Entity<UserEntity> (new UserMap ().Configure); //cria um novo usermap configurado com o configure da UserMap
        }

    }
}

/*
 * contexto é o cara que recebe as tabelas relacionadas a entidade que esta na dominio
 * 
 * 
 */