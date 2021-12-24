using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<EnderecoEntity>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntity> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(endereco => endereco.Id);

            builder.HasOne(endereco => endereco.Cinema) // nossa entidade do tipo endereco tem um cinema
                .WithOne(cinema => cinema.Endereco) // logo esse cinema possui um endereco
                .HasForeignKey<CinemaEntity>(cinema => cinema.EnderecoId);  // nossa chave estrangeira ou seja nossa referencia entre as tabelas esta alojado no cinema e é o nosso enderecoID
        }
    }
}
