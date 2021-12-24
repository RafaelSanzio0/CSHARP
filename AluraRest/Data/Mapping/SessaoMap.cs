using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class SessaoMap : IEntityTypeConfiguration<SessaoEntity>
    {
        public void Configure(EntityTypeBuilder<SessaoEntity> builder)
        {
            builder.ToTable("Sessao");

            builder.HasKey(sessao => sessao.Id);

            builder.HasOne(sessao => sessao.Cinema)
                .WithMany(cinema => cinema.Sessoes)
                .HasForeignKey(sessao => sessao.CinemaId);

            builder.HasOne(sessao => sessao.Filme)
               .WithMany(filme => filme.Sessoes)
               .HasForeignKey(sessao => sessao.FilmeId);
        }
    }
}
