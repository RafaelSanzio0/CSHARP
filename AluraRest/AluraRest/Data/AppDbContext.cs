using AluraRest.Models;
using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) // metodo da classe DbContext que é responsavel por explicitar quais definicoes queremos fazer ao criar um modelo
        {
            builder.Entity<Endereco>() // nossa entidade do tipo endereco tem um
                .HasOne(endereco => endereco.Cinema) // cinema
                .WithOne(cinema => cinema.Endereco) // logo esse cinema possui um endereco
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId); // nossa chave estrangeira ou seja nossa referencia entre as tabelas esta alojado no cinema e é o nosso enderecoID

            builder.Entity<Cinema>()
                .HasOne(cinema => cinema.Gerente) // nosso cinema possui um gerente
                .WithMany(gerente => gerente.Cinemas) // gerente vai ter um, nenhum ou muitos cinemas
                .HasForeignKey(cinema => cinema.GerenteId); //.IsRequired(false) com isso conseguimos criar um cinema sem um gerente
                                                            //.OnDelete(DeleteBehavior.Restrict); // com isso mudamos de cascade(onde uma delecao de um elemento automaticamente deleta tbm objetos que dependem dele) para restrict (onde nao conseguimos efetuar a delecao)
            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Filme)
                .WithMany(filme => filme.Sessoes)
                .HasForeignKey(sessao => sessao.FilmeId);

            builder.Entity<Sessao>()
               .HasOne(sessao => sessao.Cinema)
               .WithMany(cinema => cinema.Sessoes)
               .HasForeignKey(sessao => sessao.CinemaId);
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }

    }
}