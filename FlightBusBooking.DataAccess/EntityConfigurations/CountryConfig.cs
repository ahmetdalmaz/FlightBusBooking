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
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.HasKey(c => c.CountryId);
            builder.Property(c => c.CountryId).UseIdentityColumn();
            builder.Property(c=>c.CountryName).HasColumnType("varchar").HasMaxLength(50);

            builder.HasMany(c=>c.Cities).WithOne(ct=>ct.Country).HasForeignKey(ct => ct.CountryId).HasPrincipalKey(c=>c.CountryId);

        }
    }
}
