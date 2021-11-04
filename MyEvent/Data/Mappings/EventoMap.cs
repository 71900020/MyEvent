using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Mappings
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(prop => prop.PKEvento);

            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.DataEvento)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.Horario)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.IdadeMinima)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.FkLocal)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.FkUsuario)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();

        }
    }
}
