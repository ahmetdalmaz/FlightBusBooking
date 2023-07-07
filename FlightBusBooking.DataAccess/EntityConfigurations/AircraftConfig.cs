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
    public class AircraftConfig : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.ToTable("Aircraft");
            builder.HasKey(x => x.AircraftId);
            builder.Property(x => x.AircraftId).UseIdentityColumn();
            builder.Property(x => x.AircraftModel).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
