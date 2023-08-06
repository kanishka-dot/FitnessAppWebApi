﻿// <auto-generated />
using FitnessAppWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessAppWebApi.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230726160202_remove primary keys")]
    partial class removeprimarykeys
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessAppWebApi.Models.Meal", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Totcalories")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Totcarbs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Totfat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Totprotien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID", "Date");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("FitnessAppWebApi.Models.Workout", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Calburn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercise")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID", "Date");

                    b.ToTable("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
