﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantAPI.Models;

namespace RestaurantAPI.Migrations
{
    [DbContext(typeof(RestaurantAppContext))]
    partial class RestaurantAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantAPI.Models.Foods", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Image = "image/canhca.jpg",
                            Name = "Canh cá",
                            Price = 7000m
                        },
                        new
                        {
                            Id = 2L,
                            Image = "image/comtrang.jpg",
                            Name = "Cơm trắng",
                            Price = 5000m
                        },
                        new
                        {
                            Id = 3L,
                            Image = "image/comchien.jpg",
                            Name = "Cơm chiên",
                            Price = 10000m
                        },
                        new
                        {
                            Id = 4L,
                            Image = "image/canhthitbo.jpg",
                            Name = "Canh thịt bò",
                            Price = 15000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
