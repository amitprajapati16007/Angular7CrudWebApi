﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebBl.Models;

namespace WebBl.Migrations
{
    [DbContext(typeof(PaymentDetailContext))]
    [Migration("20200104053527_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBl.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PMID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("CardOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("expirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("PMID");

                    b.ToTable("PaymentDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
