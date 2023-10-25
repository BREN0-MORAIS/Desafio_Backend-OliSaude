using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OliSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliSaude.Infra.Data.Mapping
{
    internal class CostumerMap : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(EntityTypeBuilder<Costumer> builder)
        {

            //builder.HasKey(prop => prop.Id);

            //builder.Property(prop => prop.Name)
            //    .HasConversion(prop => prop.ToString(), prop => prop)
            //    .
            //    .HasColumnName("Name")
            //    .HasColumnType("varchar(100)");

            //builder.Property(prop => prop.Email)
            //   .HasConversion(prop => prop.ToString(), prop => prop)
            //   .IsRequired()
            //   .HasColumnName("Email")
            //   .HasColumnType("varchar(100)");

            //builder.Property(prop => prop.Password)
            //    .HasConversion(prop => prop.ToString(), prop => prop)
            //    .IsRequired()
            //    .HasColumnName("Password")
            //    .HasColumnType("varchar(100)");
        }
    }
}
