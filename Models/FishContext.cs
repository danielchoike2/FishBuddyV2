using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FishBuddy.Models
{
    public class FishContext : DbContext
    {
        public FishContext(DbContextOptions<FishContext> options) : base(options)
        { }
        public DbSet<FishSpecies> FishList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FishSpecies>().HasData(
                new FishSpecies
                {
                    ID = 1,
                    FishName = "Largemouth Bass",
                    Location = "Lakes, Rivers, & Ponds",
                    MaxLength = "27 Inches",
                    MaxWeight = "11.94 Pounds"

                },
                new FishSpecies
                {
                    ID = 2,
                    FishName = "Northern Pike",
                    Location = "Lakes, Rivers, & Ponds",
                    MaxLength = "51.5 Inches",
                    MaxWeight = "39 Pounds"
                },
                new FishSpecies
                {
                    ID = 3,
                    FishName = "Walleye",
                    Location = "Lakes, Rivers, & Ponds",
                    MaxLength = "35 Inches",
                    MaxWeight = "17.19 Pounds"
                }
            );

        }
    }
}
