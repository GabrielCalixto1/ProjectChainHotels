using Microsoft.EntityFrameworkCore;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
using ProjectChainHotels.Lib.Models;

namespace ProjectChainHotels.Lib.Data
{
    public class ChainHotelsContext : DbContext
    {
        public ChainHotelsContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bedroom>().ToTable("hc_bedroom");
            modelBuilder.Entity<Bedroom>().HasKey(key => key.GetId());

            modelBuilder.Entity<BedroomDescription>().ToTable("hc_bedroom_descriptions");
            modelBuilder.Entity<BedroomDescription>().HasKey(key => key.GetId());

            modelBuilder.Entity<Hotel>().ToTable("hc_hotel");
            modelBuilder.Entity<Hotel>().HasKey(key => key.GetId());

            modelBuilder.Entity<HotelGuest>().ToTable("hc_hotel_guest");
            modelBuilder.Entity<HotelGuest>().HasKey(key => key.GetId());

            modelBuilder.Entity<Reserve>().ToTable("hc_reserve");
            modelBuilder.Entity<Reserve>().HasKey(key => key.GetId());

            modelBuilder.Entity<ReserveXHotelGuest>().ToTable("hc_reserve_x_hotel_guest");
            modelBuilder.Entity<ReserveXHotelGuest>().HasKey(key => key.GetId());

            modelBuilder.Entity<Service>().ToTable("hc_service");
            modelBuilder.Entity<Service>().HasKey(key => key.GetId());

            modelBuilder.Entity<ServiceXHotel>().ToTable("hc_service_x_hotel");
            modelBuilder.Entity<ServiceXHotel>().HasKey(key => key.GetId);

        }
        public DbSet<Bedroom> BedroomsDb { get; set; }
        public DbSet<BedroomDescription> BedroomDescriptionsDb { get; set; }
        public DbSet<Hotel> HotelsDb { get; set; }
        public DbSet<HotelGuest> HotelGuestsDb { get; set; }
        public DbSet<Service> ServicesDb { get; set; }
        public DbSet<Reserve> ReservesDb { get; set; }
        public DbSet<ReserveXHotelGuest> ReserveXHotelGuestsDb { get; set; }
        public DbSet<ServiceXHotel> ServiceXHotelsDb { get; set; }
    }
}