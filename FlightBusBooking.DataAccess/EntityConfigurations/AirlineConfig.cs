using FlightBusBooking.Entities.Abstract;
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
    public class AirlineConfig : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.ToTable("Airlines");
            builder.HasKey(x => x.AirlineId);
            builder.Property(x => x.AirlineId).UseIdentityColumn();
            builder.Property(x => x.AirlineName).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
