using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Mappings
{
    public class GastoMap : IEntityTypeConfiguration<Gasto>
    {
        public void Configure(EntityTypeBuilder<Gasto> builder)
        {
            builder.HasKey(prop => prop.PKGasto);

            builder.Property(prop => prop.Descricao)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.Valor)
                .HasConversion(prop => Convert.ToDecimal(prop), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.FKEvento)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();
        }
    }
}
