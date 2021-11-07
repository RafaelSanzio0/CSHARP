using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class CepMap : IEntityTypeConfiguration<CepEntity>
    {
        public void Configure(EntityTypeBuilder<CepEntity> builder)
        {
            builder.ToTable("Cep");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Cep);

            builder.HasOne(m => m.MunicipioEntity)
                .WithMany(c => c.CepEntities);

            //builder.Property(u => u.Cep)
            //.IsRequired()
            //.HasMaxLength(10);

            // builder.Property(u => u.Logradouro)
            //.HasMaxLength(60)
            //.IsRequired();

            // builder.Property(u => u.Numero)
            //.IsRequired()
            //.HasMaxLength(10);

            // builder.Property(u => u.MunicipioID)
            //.IsRequired();

            // builder.Property(u => u.MunicipioEntity)
            //.IsRequired();
        }
    }
}
