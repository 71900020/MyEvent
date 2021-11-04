using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Mappings
{
    public class ConvidadoMap : IEntityTypeConfiguration<Convidado>
    {
        public void Configure(EntityTypeBuilder<Convidado> builder)
        {
            builder.HasKey(prop => prop.PKConvidado);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.Idade)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.FKEvento)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();

        }
    }
}
