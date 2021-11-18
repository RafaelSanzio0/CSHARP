using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class MunicipioMap : IEntityTypeConfiguration<MunicipioEntity>
    {
        public void Configure(EntityTypeBuilder<MunicipioEntity> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.CodIBGE);

            builder.HasOne(u => u.UfEntity)
                .WithMany(m => m.MunicipioEntities);

            //builder.Property(u => u.Nome)
            //.IsRequired()
            //.HasMaxLength(45);

            // builder.Property(u => u.CodIBGE)
            //.HasMaxLength(100)
            //.IsRequired();

            //builder.Property(u => u.UfID)
            // .IsRequired();

            // builder.Property(u => u.UfEntity)
            //.IsRequired();

            //builder.Property(u => u.CepEntities) professor n criou esses mapeamento para o bd
        }
    }
}
