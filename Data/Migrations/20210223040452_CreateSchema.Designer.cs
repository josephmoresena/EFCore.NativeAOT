﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using EFCore.NativeAOT;

namespace EFCore.NativeAOT.Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210223040452_CreateSchema")]
    partial class CreateSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-preview.2.21122.5");

            modelBuilder.Entity("EFCore.NativeAOT.Table1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Table1");
                });
#pragma warning restore 612, 618
        }
    }
}