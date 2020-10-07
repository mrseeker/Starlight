﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Starlight.Server.Data;

namespace Starlight.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201004141721_chronos")]
    partial class chronos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Starlight.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Slot")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Starlight.Models.Clock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Day")
                        .HasColumnType("bigint");

                    b.Property<long>("Hour")
                        .HasColumnType("bigint");

                    b.Property<long>("Minute")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Month")
                        .HasColumnType("bigint");

                    b.Property<long>("Year")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Clock");
                });

            modelBuilder.Entity("Starlight.Models.GlobalConstellation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Sattelite")
                        .HasColumnType("integer");

                    b.Property<int>("Series")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("GlobalConstellation");
                });

            modelBuilder.Entity("Starlight.Models.GlobalData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GlobalData");
                });

            modelBuilder.Entity("Starlight.Models.GlobalTimeEvents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Day")
                        .HasColumnType("integer");

                    b.Property<int?>("Hour")
                        .HasColumnType("integer");

                    b.Property<int?>("Interval")
                        .HasColumnType("integer");

                    b.Property<int?>("Minute")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Month")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GlobalTimeEvents");
                });

            modelBuilder.Entity("Starlight.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("Starlight.Models.MapAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("MapId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<int>("X")
                        .HasColumnType("integer");

                    b.Property<int>("Y")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.ToTable("MapAttribute");
                });

            modelBuilder.Entity("Starlight.Models.MapLayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("MapId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.ToTable("MapLayer");
                });

            modelBuilder.Entity("Starlight.Models.MapTile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("MapLayerId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("X")
                        .HasColumnType("integer");

                    b.Property<int>("Y")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MapLayerId");

                    b.ToTable("MapTile");
                });

            modelBuilder.Entity("Starlight.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Starlight.Models.Character", b =>
                {
                    b.HasOne("Starlight.Models.User", null)
                        .WithMany("Characters")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Starlight.Models.MapAttribute", b =>
                {
                    b.HasOne("Starlight.Models.Map", null)
                        .WithMany("Attributes")
                        .HasForeignKey("MapId");
                });

            modelBuilder.Entity("Starlight.Models.MapLayer", b =>
                {
                    b.HasOne("Starlight.Models.Map", null)
                        .WithMany("Layers")
                        .HasForeignKey("MapId");
                });

            modelBuilder.Entity("Starlight.Models.MapTile", b =>
                {
                    b.HasOne("Starlight.Models.MapLayer", null)
                        .WithMany("Tiles")
                        .HasForeignKey("MapLayerId");
                });
#pragma warning restore 612, 618
        }
    }
}