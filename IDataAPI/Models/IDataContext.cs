using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IDataAPI.Models
{
    public partial class IDataContext : DbContext
    {
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<DistrictLevel> DistrictLevel { get; set; }
        public virtual DbSet<Population> Population { get; set; }
        public virtual DbSet<SalePricesCity> SalePricesCity { get; set; }
        public virtual DbSet<SalePricesMsa> SalePricesMsa { get; set; }

        // Unable to generate entity type for table 'dbo.Sale_Prices_City$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sale_Prices_Msa$'. Please see the warning messages.

        public IDataContext(DbContextOptions<IDataContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.Property(e => e.CityId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CityFullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.ToTable("CONTINENT");

                entity.Property(e => e.ContinentId).ValueGeneratedNever();

                entity.Property(e => e.ContinentName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("COUNTRY");

                entity.Property(e => e.CountryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CountryFullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.DistrictAreaId);

                entity.ToTable("DISTRICT");

                entity.Property(e => e.DistrictAreaId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenceSource).HasMaxLength(500);

                entity.Property(e => e.Year).HasColumnType("date");
            });

            modelBuilder.Entity<DistrictLevel>(entity =>
            {
                entity.ToTable("DISTRICT_LEVEL");

                entity.Property(e => e.DistrictLevelId).ValueGeneratedNever();

                entity.Property(e => e.DistrictLevelName).HasMaxLength(100);
            });

            modelBuilder.Entity<Population>(entity =>
            {
                entity.HasKey(e => e.DistrictPopulationId);

                entity.ToTable("POPULATION");

                entity.Property(e => e.DistrictPopulationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenceSource).HasMaxLength(500);

                entity.Property(e => e.Year).HasColumnType("date");
            });

            modelBuilder.Entity<SalePricesCity>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("Sale_Prices_City$");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Apr08).HasColumnName("Apr-08");

                entity.Property(e => e.Apr09).HasColumnName("Apr-09");

                entity.Property(e => e.Apr10).HasColumnName("Apr-10");

                entity.Property(e => e.Apr11).HasColumnName("Apr-11");

                entity.Property(e => e.Apr12).HasColumnName("Apr-12");

                entity.Property(e => e.Apr13).HasColumnName("Apr-13");

                entity.Property(e => e.Apr14).HasColumnName("Apr-14");

                entity.Property(e => e.Apr15).HasColumnName("Apr-15");

                entity.Property(e => e.Apr16).HasColumnName("Apr-16");

                entity.Property(e => e.Apr17).HasColumnName("Apr-17");

                entity.Property(e => e.Aug08).HasColumnName("Aug-08");

                entity.Property(e => e.Aug09).HasColumnName("Aug-09");

                entity.Property(e => e.Aug10).HasColumnName("Aug-10");

                entity.Property(e => e.Aug11).HasColumnName("Aug-11");

                entity.Property(e => e.Aug12).HasColumnName("Aug-12");

                entity.Property(e => e.Aug13).HasColumnName("Aug-13");

                entity.Property(e => e.Aug14).HasColumnName("Aug-14");

                entity.Property(e => e.Aug15).HasColumnName("Aug-15");

                entity.Property(e => e.Aug16).HasColumnName("Aug-16");

                entity.Property(e => e.Aug17).HasColumnName("Aug-17");

                entity.Property(e => e.Dec08).HasColumnName("Dec-08");

                entity.Property(e => e.Dec09).HasColumnName("Dec-09");

                entity.Property(e => e.Dec10).HasColumnName("Dec-10");

                entity.Property(e => e.Dec11).HasColumnName("Dec-11");

                entity.Property(e => e.Dec12).HasColumnName("Dec-12");

                entity.Property(e => e.Dec13).HasColumnName("Dec-13");

                entity.Property(e => e.Dec14).HasColumnName("Dec-14");

                entity.Property(e => e.Dec15).HasColumnName("Dec-15");

                entity.Property(e => e.Dec16).HasColumnName("Dec-16");

                entity.Property(e => e.Dec17).HasColumnName("Dec-17");

                entity.Property(e => e.Feb09).HasColumnName("Feb-09");

                entity.Property(e => e.Feb10).HasColumnName("Feb-10");

                entity.Property(e => e.Feb11).HasColumnName("Feb-11");

                entity.Property(e => e.Feb12).HasColumnName("Feb-12");

                entity.Property(e => e.Feb13).HasColumnName("Feb-13");

                entity.Property(e => e.Feb14).HasColumnName("Feb-14");

                entity.Property(e => e.Feb15).HasColumnName("Feb-15");

                entity.Property(e => e.Feb16).HasColumnName("Feb-16");

                entity.Property(e => e.Feb17).HasColumnName("Feb-17");

                entity.Property(e => e.Feb18).HasColumnName("Feb-18");

                entity.Property(e => e.Jan09).HasColumnName("Jan-09");

                entity.Property(e => e.Jan10).HasColumnName("Jan-10");

                entity.Property(e => e.Jan11).HasColumnName("Jan-11");

                entity.Property(e => e.Jan12).HasColumnName("Jan-12");

                entity.Property(e => e.Jan13).HasColumnName("Jan-13");

                entity.Property(e => e.Jan14).HasColumnName("Jan-14");

                entity.Property(e => e.Jan15).HasColumnName("Jan-15");

                entity.Property(e => e.Jan16).HasColumnName("Jan-16");

                entity.Property(e => e.Jan17).HasColumnName("Jan-17");

                entity.Property(e => e.Jan18).HasColumnName("Jan-18");

                entity.Property(e => e.Jul08).HasColumnName("Jul-08");

                entity.Property(e => e.Jul09).HasColumnName("Jul-09");

                entity.Property(e => e.Jul10).HasColumnName("Jul-10");

                entity.Property(e => e.Jul11).HasColumnName("Jul-11");

                entity.Property(e => e.Jul12).HasColumnName("Jul-12");

                entity.Property(e => e.Jul13).HasColumnName("Jul-13");

                entity.Property(e => e.Jul14).HasColumnName("Jul-14");

                entity.Property(e => e.Jul15).HasColumnName("Jul-15");

                entity.Property(e => e.Jul16).HasColumnName("Jul-16");

                entity.Property(e => e.Jul17).HasColumnName("Jul-17");

                entity.Property(e => e.Jun08).HasColumnName("Jun-08");

                entity.Property(e => e.Jun09).HasColumnName("Jun-09");

                entity.Property(e => e.Jun10).HasColumnName("Jun-10");

                entity.Property(e => e.Jun11).HasColumnName("Jun-11");

                entity.Property(e => e.Jun12).HasColumnName("Jun-12");

                entity.Property(e => e.Jun13).HasColumnName("Jun-13");

                entity.Property(e => e.Jun14).HasColumnName("Jun-14");

                entity.Property(e => e.Jun15).HasColumnName("Jun-15");

                entity.Property(e => e.Jun16).HasColumnName("Jun-16");

                entity.Property(e => e.Jun17).HasColumnName("Jun-17");

                entity.Property(e => e.Mar08).HasColumnName("Mar-08");

                entity.Property(e => e.Mar09).HasColumnName("Mar-09");

                entity.Property(e => e.Mar10).HasColumnName("Mar-10");

                entity.Property(e => e.Mar11).HasColumnName("Mar-11");

                entity.Property(e => e.Mar12).HasColumnName("Mar-12");

                entity.Property(e => e.Mar13).HasColumnName("Mar-13");

                entity.Property(e => e.Mar14).HasColumnName("Mar-14");

                entity.Property(e => e.Mar15).HasColumnName("Mar-15");

                entity.Property(e => e.Mar16).HasColumnName("Mar-16");

                entity.Property(e => e.Mar17).HasColumnName("Mar-17");

                entity.Property(e => e.Mar18).HasColumnName("Mar-18");

                entity.Property(e => e.May08).HasColumnName("May-08");

                entity.Property(e => e.May09).HasColumnName("May-09");

                entity.Property(e => e.May10).HasColumnName("May-10");

                entity.Property(e => e.May11).HasColumnName("May-11");

                entity.Property(e => e.May12).HasColumnName("May-12");

                entity.Property(e => e.May13).HasColumnName("May-13");

                entity.Property(e => e.May14).HasColumnName("May-14");

                entity.Property(e => e.May15).HasColumnName("May-15");

                entity.Property(e => e.May16).HasColumnName("May-16");

                entity.Property(e => e.May17).HasColumnName("May-17");

                entity.Property(e => e.Nov08).HasColumnName("Nov-08");

                entity.Property(e => e.Nov09).HasColumnName("Nov-09");

                entity.Property(e => e.Nov10).HasColumnName("Nov-10");

                entity.Property(e => e.Nov11).HasColumnName("Nov-11");

                entity.Property(e => e.Nov12).HasColumnName("Nov-12");

                entity.Property(e => e.Nov13).HasColumnName("Nov-13");

                entity.Property(e => e.Nov14).HasColumnName("Nov-14");

                entity.Property(e => e.Nov15).HasColumnName("Nov-15");

                entity.Property(e => e.Nov16).HasColumnName("Nov-16");

                entity.Property(e => e.Nov17).HasColumnName("Nov-17");

                entity.Property(e => e.Oct08).HasColumnName("Oct-08");

                entity.Property(e => e.Oct09).HasColumnName("Oct-09");

                entity.Property(e => e.Oct10).HasColumnName("Oct-10");

                entity.Property(e => e.Oct11).HasColumnName("Oct-11");

                entity.Property(e => e.Oct12).HasColumnName("Oct-12");

                entity.Property(e => e.Oct13).HasColumnName("Oct-13");

                entity.Property(e => e.Oct14).HasColumnName("Oct-14");

                entity.Property(e => e.Oct15).HasColumnName("Oct-15");

                entity.Property(e => e.Oct16).HasColumnName("Oct-16");

                entity.Property(e => e.Oct17).HasColumnName("Oct-17");

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.Sep08).HasColumnName("Sep-08");

                entity.Property(e => e.Sep09).HasColumnName("Sep-09");

                entity.Property(e => e.Sep10).HasColumnName("Sep-10");

                entity.Property(e => e.Sep11).HasColumnName("Sep-11");

                entity.Property(e => e.Sep12).HasColumnName("Sep-12");

                entity.Property(e => e.Sep13).HasColumnName("Sep-13");

                entity.Property(e => e.Sep14).HasColumnName("Sep-14");

                entity.Property(e => e.Sep15).HasColumnName("Sep-15");

                entity.Property(e => e.Sep16).HasColumnName("Sep-16");

                entity.Property(e => e.Sep17).HasColumnName("Sep-17");

                entity.Property(e => e.StateName).HasMaxLength(255);
            });

            modelBuilder.Entity<SalePricesMsa>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("Sale_Prices_Msa$");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Apr08).HasColumnName("Apr-08");

                entity.Property(e => e.Apr09).HasColumnName("Apr-09");

                entity.Property(e => e.Apr10).HasColumnName("Apr-10");

                entity.Property(e => e.Apr11).HasColumnName("Apr-11");

                entity.Property(e => e.Apr12).HasColumnName("Apr-12");

                entity.Property(e => e.Apr13).HasColumnName("Apr-13");

                entity.Property(e => e.Apr14).HasColumnName("Apr-14");

                entity.Property(e => e.Apr15).HasColumnName("Apr-15");

                entity.Property(e => e.Apr16).HasColumnName("Apr-16");

                entity.Property(e => e.Apr17).HasColumnName("Apr-17");

                entity.Property(e => e.Aug08).HasColumnName("Aug-08");

                entity.Property(e => e.Aug09).HasColumnName("Aug-09");

                entity.Property(e => e.Aug10).HasColumnName("Aug-10");

                entity.Property(e => e.Aug11).HasColumnName("Aug-11");

                entity.Property(e => e.Aug12).HasColumnName("Aug-12");

                entity.Property(e => e.Aug13).HasColumnName("Aug-13");

                entity.Property(e => e.Aug14).HasColumnName("Aug-14");

                entity.Property(e => e.Aug15).HasColumnName("Aug-15");

                entity.Property(e => e.Aug16).HasColumnName("Aug-16");

                entity.Property(e => e.Aug17).HasColumnName("Aug-17");

                entity.Property(e => e.Dec08).HasColumnName("Dec-08");

                entity.Property(e => e.Dec09).HasColumnName("Dec-09");

                entity.Property(e => e.Dec10).HasColumnName("Dec-10");

                entity.Property(e => e.Dec11).HasColumnName("Dec-11");

                entity.Property(e => e.Dec12).HasColumnName("Dec-12");

                entity.Property(e => e.Dec13).HasColumnName("Dec-13");

                entity.Property(e => e.Dec14).HasColumnName("Dec-14");

                entity.Property(e => e.Dec15).HasColumnName("Dec-15");

                entity.Property(e => e.Dec16).HasColumnName("Dec-16");

                entity.Property(e => e.Dec17).HasColumnName("Dec-17");

                entity.Property(e => e.Feb09).HasColumnName("Feb-09");

                entity.Property(e => e.Feb10).HasColumnName("Feb-10");

                entity.Property(e => e.Feb11).HasColumnName("Feb-11");

                entity.Property(e => e.Feb12).HasColumnName("Feb-12");

                entity.Property(e => e.Feb13).HasColumnName("Feb-13");

                entity.Property(e => e.Feb14).HasColumnName("Feb-14");

                entity.Property(e => e.Feb15).HasColumnName("Feb-15");

                entity.Property(e => e.Feb16).HasColumnName("Feb-16");

                entity.Property(e => e.Feb17).HasColumnName("Feb-17");

                entity.Property(e => e.Feb18).HasColumnName("Feb-18");

                entity.Property(e => e.Jan09).HasColumnName("Jan-09");

                entity.Property(e => e.Jan10).HasColumnName("Jan-10");

                entity.Property(e => e.Jan11).HasColumnName("Jan-11");

                entity.Property(e => e.Jan12).HasColumnName("Jan-12");

                entity.Property(e => e.Jan13).HasColumnName("Jan-13");

                entity.Property(e => e.Jan14).HasColumnName("Jan-14");

                entity.Property(e => e.Jan15).HasColumnName("Jan-15");

                entity.Property(e => e.Jan16).HasColumnName("Jan-16");

                entity.Property(e => e.Jan17).HasColumnName("Jan-17");

                entity.Property(e => e.Jan18).HasColumnName("Jan-18");

                entity.Property(e => e.Jul08).HasColumnName("Jul-08");

                entity.Property(e => e.Jul09).HasColumnName("Jul-09");

                entity.Property(e => e.Jul10).HasColumnName("Jul-10");

                entity.Property(e => e.Jul11).HasColumnName("Jul-11");

                entity.Property(e => e.Jul12).HasColumnName("Jul-12");

                entity.Property(e => e.Jul13).HasColumnName("Jul-13");

                entity.Property(e => e.Jul14).HasColumnName("Jul-14");

                entity.Property(e => e.Jul15).HasColumnName("Jul-15");

                entity.Property(e => e.Jul16).HasColumnName("Jul-16");

                entity.Property(e => e.Jul17).HasColumnName("Jul-17");

                entity.Property(e => e.Jun08).HasColumnName("Jun-08");

                entity.Property(e => e.Jun09).HasColumnName("Jun-09");

                entity.Property(e => e.Jun10).HasColumnName("Jun-10");

                entity.Property(e => e.Jun11).HasColumnName("Jun-11");

                entity.Property(e => e.Jun12).HasColumnName("Jun-12");

                entity.Property(e => e.Jun13).HasColumnName("Jun-13");

                entity.Property(e => e.Jun14).HasColumnName("Jun-14");

                entity.Property(e => e.Jun15).HasColumnName("Jun-15");

                entity.Property(e => e.Jun16).HasColumnName("Jun-16");

                entity.Property(e => e.Jun17).HasColumnName("Jun-17");

                entity.Property(e => e.Mar08).HasColumnName("Mar-08");

                entity.Property(e => e.Mar09).HasColumnName("Mar-09");

                entity.Property(e => e.Mar10).HasColumnName("Mar-10");

                entity.Property(e => e.Mar11).HasColumnName("Mar-11");

                entity.Property(e => e.Mar12).HasColumnName("Mar-12");

                entity.Property(e => e.Mar13).HasColumnName("Mar-13");

                entity.Property(e => e.Mar14).HasColumnName("Mar-14");

                entity.Property(e => e.Mar15).HasColumnName("Mar-15");

                entity.Property(e => e.Mar16).HasColumnName("Mar-16");

                entity.Property(e => e.Mar17).HasColumnName("Mar-17");

                entity.Property(e => e.Mar18).HasColumnName("Mar-18");

                entity.Property(e => e.May08).HasColumnName("May-08");

                entity.Property(e => e.May09).HasColumnName("May-09");

                entity.Property(e => e.May10).HasColumnName("May-10");

                entity.Property(e => e.May11).HasColumnName("May-11");

                entity.Property(e => e.May12).HasColumnName("May-12");

                entity.Property(e => e.May13).HasColumnName("May-13");

                entity.Property(e => e.May14).HasColumnName("May-14");

                entity.Property(e => e.May15).HasColumnName("May-15");

                entity.Property(e => e.May16).HasColumnName("May-16");

                entity.Property(e => e.May17).HasColumnName("May-17");

                entity.Property(e => e.Nov08).HasColumnName("Nov-08");

                entity.Property(e => e.Nov09).HasColumnName("Nov-09");

                entity.Property(e => e.Nov10).HasColumnName("Nov-10");

                entity.Property(e => e.Nov11).HasColumnName("Nov-11");

                entity.Property(e => e.Nov12).HasColumnName("Nov-12");

                entity.Property(e => e.Nov13).HasColumnName("Nov-13");

                entity.Property(e => e.Nov14).HasColumnName("Nov-14");

                entity.Property(e => e.Nov15).HasColumnName("Nov-15");

                entity.Property(e => e.Nov16).HasColumnName("Nov-16");

                entity.Property(e => e.Nov17).HasColumnName("Nov-17");

                entity.Property(e => e.Oct08).HasColumnName("Oct-08");

                entity.Property(e => e.Oct09).HasColumnName("Oct-09");

                entity.Property(e => e.Oct10).HasColumnName("Oct-10");

                entity.Property(e => e.Oct11).HasColumnName("Oct-11");

                entity.Property(e => e.Oct12).HasColumnName("Oct-12");

                entity.Property(e => e.Oct13).HasColumnName("Oct-13");

                entity.Property(e => e.Oct14).HasColumnName("Oct-14");

                entity.Property(e => e.Oct15).HasColumnName("Oct-15");

                entity.Property(e => e.Oct16).HasColumnName("Oct-16");

                entity.Property(e => e.Oct17).HasColumnName("Oct-17");

                entity.Property(e => e.RegionName).HasMaxLength(255);

                entity.Property(e => e.Sep08).HasColumnName("Sep-08");

                entity.Property(e => e.Sep09).HasColumnName("Sep-09");

                entity.Property(e => e.Sep10).HasColumnName("Sep-10");

                entity.Property(e => e.Sep11).HasColumnName("Sep-11");

                entity.Property(e => e.Sep12).HasColumnName("Sep-12");

                entity.Property(e => e.Sep13).HasColumnName("Sep-13");

                entity.Property(e => e.Sep14).HasColumnName("Sep-14");

                entity.Property(e => e.Sep15).HasColumnName("Sep-15");

                entity.Property(e => e.Sep16).HasColumnName("Sep-16");

                entity.Property(e => e.Sep17).HasColumnName("Sep-17");
            });
        }
    }
}
