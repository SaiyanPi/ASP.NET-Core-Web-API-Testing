﻿// <auto-generated />
using System;
using EFCoreDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreDemo.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    partial class SampleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreDemo.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("ContactName");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("Description");

                    b.Property<DateTimeOffset>("DueDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("DueDate");

                    b.Property<DateTimeOffset>("InvoiceDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("InvoiceDate");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasColumnName("InvoiceNumber");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Invoices", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
