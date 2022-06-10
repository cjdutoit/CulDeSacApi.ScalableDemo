﻿// <auto-generated />
using System;
using CulDeSacApi.Brokers.Storages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CulDeSacApi.Migrations
{
    [DbContext(typeof(StorageBroker))]
    [Migration("20220610233111_AddLibraryCard")]
    partial class AddLibraryCard
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CulDeSacApi.Models.LibraryAccounts.LibraryAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("LibraryAccounts");
                });

            modelBuilder.Entity("CulDeSacApi.Models.LibraryCards.LibraryCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LibraryAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LibraryAccountId");

                    b.ToTable("LibraryCards");
                });

            modelBuilder.Entity("CulDeSacApi.Models.Students.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CulDeSacApi.Models.LibraryAccounts.LibraryAccount", b =>
                {
                    b.HasOne("CulDeSacApi.Models.Students.Student", "Student")
                        .WithOne("LibraryAccount")
                        .HasForeignKey("CulDeSacApi.Models.LibraryAccounts.LibraryAccount", "StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CulDeSacApi.Models.LibraryCards.LibraryCard", b =>
                {
                    b.HasOne("CulDeSacApi.Models.LibraryAccounts.LibraryAccount", "LibraryAccount")
                        .WithMany("LibraryCards")
                        .HasForeignKey("LibraryAccountId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("LibraryAccount");
                });

            modelBuilder.Entity("CulDeSacApi.Models.LibraryAccounts.LibraryAccount", b =>
                {
                    b.Navigation("LibraryCards");
                });

            modelBuilder.Entity("CulDeSacApi.Models.Students.Student", b =>
                {
                    b.Navigation("LibraryAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
