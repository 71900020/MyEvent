using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvent.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(prop => prop.PKTarefa);

            builder.Property(prop => prop.Descricao)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.FoiRealizado)
                .HasConversion(prop => Convert.ToBoolean(prop), prop => prop)
                .IsRequired();

            builder.Property(prop => prop.FKEvento)
                .HasConversion(prop => Convert.ToInt32(prop), prop => prop)
                .IsRequired();
        }
    }
}
