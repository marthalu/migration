using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaDeRopa.Domain;

namespace TiendaDeRopa.Infraestructure.EntityConfugurations
{
  public class TiendaEntityConfiguration : IEntityTypeConfiguration<Tienda>
  {
    public void Configure(EntityTypeBuilder<Tienda>tiendaConfiguration)

    {
      tiendaConfiguration.HasKey(t => t.Id);

      tiendaConfiguration.Property(t => t.Talla)
        .IsRequired(true);

      tiendaConfiguration.Property(t => t.Precio)
       .IsRequired(true);

      tiendaConfiguration.Property<Guid>("_idPrenda")
        .UsePropertyAccessMode(PropertyAccessMode.Field)
        .HasColumnName("PrendaId")
        .IsRequired(true);
      tiendaConfiguration.HasOne(t => t.Prenda)
        .WithMany()
        .HasForeignKey("_idPrenda");
    }
  }

}
