using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaDeRopa.Domain;

namespace TiendaDeRopa.Infraestructure.EntityConfugurations
{
  public class PrendaEntityConfiguration : IEntityTypeConfiguration<Prenda>
  {
    public void Configure(EntityTypeBuilder<Prenda> prendaConfiguration)
    {
      prendaConfiguration.HasKey(p => p.Id);

      prendaConfiguration.Property(p => p.Nombre)
        .HasMaxLength(20)
        .IsRequired();
    }
}

}
