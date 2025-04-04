﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderService.Data;

#nullable disable

namespace OrderService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("OrderService.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<DateTime>("CreatedAt"));

                    b.Property<string>("CustomerId")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsPayment")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsWasherAccepted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PaymentId")
                        .HasColumnType("longtext");

                    b.Property<string>("Rating")
                        .HasColumnType("longtext");

                    b.Property<string>("ReviewText")
                        .HasColumnType("longtext");

                    b.Property<string>("SelectedWasherId")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceAmount")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceId")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    MySqlPropertyBuilderExtensions.UseMySqlComputedColumn(b.Property<DateTime>("UpdatedAt"));

                    b.Property<string>("WorkStatus")
                        .HasColumnType("longtext");

                    b.Property<string>("paymentStatus")
                        .HasColumnType("longtext");

                    b.Property<string>("washerName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
