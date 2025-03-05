using HotelManagementSystem.Models;
using HotelManagementSystem.Models.Room;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RoomCategory> RoomCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure RoomCategory
            builder.Entity<RoomCategory>()
                .HasIndex(rc => rc.Name)
                .IsUnique();

            // Configure Room
            builder.Entity<Room>()
                .HasIndex(r => r.RoomNumber)
                .IsUnique();

            builder.Entity<Room>()
                .HasOne(r => r.Category)
                .WithMany(c => c.Rooms)
                .HasForeignKey(r => r.CategoryId);

            builder.Entity<Room>()
                .Property(r => r.Status)
                .HasConversion<string>();

            // Seed data for room categories
            builder.Entity<RoomCategory>().HasData(
                new RoomCategory
                {
                    CategoryId = 1,
                    Name = "standard",
                    Description = "Standard room with basic amenities",
                    BasePrice = 100.00M,
                    Capacity = 2,
                    Amenities = "WiFi, TV, A/C, private bathroom"
                },
                new RoomCategory
                {
                    CategoryId = 2,
                    Name = "deluxe",
                    Description = "Comfortable room with premium amenities",
                    BasePrice = 150.00M,
                    Capacity = 2,
                    Amenities = "WiFi, TV, A/C, private bathroom, minibar, city view"
                },
                new RoomCategory
                {
                    CategoryId = 3,
                    Name = "suite",
                    Description = "Luxury suite with separate living area",
                    BasePrice = 250.00M,
                    Capacity = 4,
                    Amenities = "WiFi, TV, A/C, private bathroom, minibar, living room, dining area, kitchenette, premium view"
                }
            );
        }
    }
}