﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp1;

namespace WpfApp1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("WpfApp1.Models.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ByteRepresent")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("WpfApp1.Models.Image_db", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassName")
                        .HasColumnType("TEXT");

                    b.Property<float>("Confidence")
                        .HasColumnType("REAL");

                    b.Property<int>("Counter")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DetId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("WpfApp1.Models.Image_db", b =>
                {
                    b.HasOne("WpfApp1.Models.Detail", "Det")
                        .WithMany()
                        .HasForeignKey("DetId");
                });
#pragma warning restore 612, 618
        }
    }
}
