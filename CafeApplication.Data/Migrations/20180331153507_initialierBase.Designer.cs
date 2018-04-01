﻿// <auto-generated />
using System;
using CafeApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace CafeApplication.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180331153507_initialierBase")]
    partial class initialierBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CafeApplication.Data.Models.Consommateur", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("DerniereSelection");

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Consommateur");

                    b.SeedData(new[]
                    {
                        new { Id = 1L, AddedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DerniereSelection = false, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Nom = "Cousineau", Prenom = "Carl" },
                        new { Id = 2L, AddedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DerniereSelection = false, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Nom = "BelleVille", Prenom = " Suzanne" }
                    });
                });

            modelBuilder.Entity("CafeApplication.Data.Models.Consommation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<long>("ConsommateurID");

                    b.Property<string>("IPAddress");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("NombreCuilliere");

                    b.Property<bool>("PropreMug");

                    b.Property<int>("TypeBoisson");

                    b.HasKey("Id");

                    b.HasIndex("ConsommateurID");

                    b.ToTable("Consommation");
                });

            modelBuilder.Entity("CafeApplication.Data.Models.Consommation", b =>
                {
                    b.HasOne("CafeApplication.Data.Models.Consommateur", "Consomateur")
                        .WithMany("Consommations")
                        .HasForeignKey("ConsommateurID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}