﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PositionStore.Models;

#nullable disable

namespace sphinixtech2Backend.Migrations
{
    [DbContext(typeof(PositionDbContext))]
    [Migration("20240414140405_InitialPosition")]
    partial class InitialPosition
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("PositionStore.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("XPos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YPos")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}