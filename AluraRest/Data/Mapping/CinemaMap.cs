using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;


namespace Data.Mapping
{
    public class CinemaMap : IEntityTypeConfiguration<CinemaEntity>
    {
        public void Configure(EntityTypeBuilder<CinemaEntity> builder)
        {
            builder.ToTable("Cinema");

            builder.HasKey(cinema => cinema.Id);

            builder.HasOne(cinema => cinema.Gerente) // nosso cinema possui um gerente
                .WithMany(gerente => gerente.Cinemas) // logo gerente vai ter um, nenhum ou muitos cinemas
                .HasForeignKey(cinema => cinema.GerenteId); //.IsRequired(false) com isso conseguimos criar um cinema sem um gerente
                                                            //.OnDelete(DeleteBehavior.Restrict); // com isso mudamos de cascade(onde uma delecao de um elemento automaticamente deleta tbm objetos que dependem dele) para restrict (onde nao conseguimos efetuar a delecao)
        }
    }
}
