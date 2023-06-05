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
    public class DistrictConfig : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts");
            builder.HasKey(d => d.DistrictId);
            builder.Property(d => d.DistrictId).UseIdentityColumn();
            builder.Property(d=>d.DistrictName).HasColumnType("varchar").HasMaxLength(40);
        }
    }
}
