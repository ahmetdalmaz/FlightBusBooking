using FlightBusBooking.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBusBooking.DataAccess.EntityConfigurations
{
    public class CabinClassesConfig : IEntityTypeConfiguration<CabinClasses>
    {
        public void Configure(EntityTypeBuilder<CabinClasses> builder)
        {
            builder.ToTable("CabinClasses");
            builder.HasKey(x => x.CabinClassId);
            builder.Property(x => x.CabinClassId).UseIdentityColumn();
            builder.Property(x => x.CabinClassName).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
