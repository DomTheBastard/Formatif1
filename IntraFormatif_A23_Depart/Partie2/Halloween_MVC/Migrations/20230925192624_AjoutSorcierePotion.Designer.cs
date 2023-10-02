﻿// <auto-generated />
using System;
using Halloween.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Halloween.Migrations
{
    [DbContext(typeof(HalloweenContext))]
    [Migration("20230925192624_AjoutSorcierePotion")]
    partial class AjoutSorcierePotion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Halloween.Models.Potion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sorciere_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Sorciere_Id");

                    b.ToTable("Potions");
                });

            modelBuilder.Entity("Halloween.Models.Sorciere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sorcieres");
                });

            modelBuilder.Entity("Halloween.Models.Potion", b =>
                {
                    b.HasOne("Halloween.Models.Sorciere", "Creatrice")
                        .WithMany("Potions")
                        .HasForeignKey("Sorciere_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creatrice");
                });

            modelBuilder.Entity("Halloween.Models.Sorciere", b =>
                {
                    b.Navigation("Potions");
                });
#pragma warning restore 612, 618
        }
    }
}