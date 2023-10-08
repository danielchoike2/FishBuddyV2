﻿// <auto-generated />
using FishBuddy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FishBuddy.Migrations
{
    [DbContext(typeof(FishContext))]
    partial class FishContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FishBuddy.Models.FishSpecies", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BestSeason")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceLevel")
                        .HasColumnType("int");

                    b.Property<string>("FishName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxLength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxWeight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FishList");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FishName = "Largemouth Bass",
                            Location = "Lakes, Rivers, & Ponds",
                            MaxLength = "27 Inches",
                            MaxWeight = "11.94 Pounds"
                        },
                        new
                        {
                            ID = 2,
                            FishName = "Northern Pike",
                            Location = "Lakes, Rivers, & Ponds",
                            MaxLength = "51.5 Inches",
                            MaxWeight = "39 Pounds"
                        },
                        new
                        {
                            ID = 3,
                            FishName = "Walleye",
                            Location = "Lakes, Rivers, & Ponds",
                            MaxLength = "35 Inches",
                            MaxWeight = "17.19 Pounds"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}