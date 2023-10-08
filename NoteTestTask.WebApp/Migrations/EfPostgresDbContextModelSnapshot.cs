﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteTestTask.WebApp.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NoteTestTask.WebApp.Migrations
{
    [DbContext(typeof(EfPostgresDbContext))]
    partial class EfPostgresDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NoteTestTask.WebApp.Data.Entities.Note", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("note_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("535b8f81-2bb9-4e1a-bd62-a4df777b9a82"),
                            CreatedDate = new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7227),
                            Description = "Breakfast at 10em",
                            Title = "Breakfast",
                            UpdatedDate = new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(5350)
                        },
                        new
                        {
                            Id = new Guid("37ad9f3c-30e0-4555-9425-c1c6f89cdbb5"),
                            CreatedDate = new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7497),
                            Description = "Lunch at 2pm",
                            Title = "Lunch",
                            UpdatedDate = new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7485)
                        },
                        new
                        {
                            Id = new Guid("3efd4303-ede5-4aa1-82a9-89ae46f3c6d4"),
                            CreatedDate = new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7506),
                            Description = "Dinner at 8pm",
                            Title = "Dinner",
                            UpdatedDate = new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7503)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
