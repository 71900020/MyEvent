using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Mappings
{
    public class LocalMap : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.HasKey(prop => prop.PKLocal);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.Endereco)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.Capacidade)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();
        }
    }
}
