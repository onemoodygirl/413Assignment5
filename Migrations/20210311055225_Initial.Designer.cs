﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoodyAssignment5.Models;

namespace MoodyAssignment5.Migrations
{
    [DbContext(typeof(BookDBContext))]
    [Migration("20210311055225_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("MoodyAssignment5.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorFirst")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorLast")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorMiddle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookID");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}