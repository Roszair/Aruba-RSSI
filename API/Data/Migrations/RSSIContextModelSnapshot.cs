﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(RSSIContext))]
    partial class RSSIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("API.Entities.RSSIValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bssid")
                        .HasColumnType("TEXT");

                    b.Property<string>("SSID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Signal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Signal_level")
                        .HasColumnType("TEXT");

                    b.Property<string>("WPA_AUTH")
                        .HasColumnType("TEXT");

                    b.Property<string>("WPA_CIPHER")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RSSIValues");
                });
#pragma warning restore 612, 618
        }
    }
}
