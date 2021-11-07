using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class UfMap : IEntityTypeConfiguration<UfEntity>
    {
        public void Configure(EntityTypeBuilder<UfEntity> builder)
        {
            builder.ToTable("Uf");

            builder.HasKey(u => u.Id); // chave primaria

            builder.HasIndex(u => u.Sigla) // index é utilizado para fazer uma busca(podemos fazer um metodo por sigla) mais performatica atraves de um atributo que nesse caso é a sigla
                .IsUnique(); // n posso ter a mesma sigla no banco ou seja 2 SP
                
            //builder.Property(u => u.Nome)
                //.IsRequired()
                //.HasMaxLength(45);

           // builder.Property(u => u.Sigla) o professor do curso nao criou e eu quero entender o pq
               // .HasMaxLength(2)
               // .IsRequired();
        }
    }
}
