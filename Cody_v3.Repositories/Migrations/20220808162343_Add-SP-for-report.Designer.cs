﻿// <auto-generated />
using System;
using Cody_v3.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cody_v3.Repositories.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220808162343_Add-SP-for-report")]
    partial class AddSPforreport
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Cody_v3.Repositories.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("CreatedIPAddress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("CreatedPCName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("DepartmentAddress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DepartmentCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdatedIPAddress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("UpdatedPCName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValueSql("''");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentCode")
                        .IsUnique();

                    b.HasIndex("DepartmentName")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Cody_v3.Repositories.Entities.Recloser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("CreatedIPAddress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("CreatedPCName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValueSql("''");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("I_Norms")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.Property<string>("LineType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RecloserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RecloserQualify")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdatedIPAddress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("UpdatedPCName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValueSql("''");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RecloserQualify")
                        .IsUnique();

                    b.ToTable("Reclosers");
                });

            modelBuilder.Entity("Cody_v3.Repositories.Entities.RecloserData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<decimal?>("COS_φ")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("CreatedIPAddress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("CreatedPCName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValueSql("''");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("ExcelFileName")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<decimal?>("I_A")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.Property<decimal?>("P_MW")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Q_MVar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("RecloserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SheetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal?>("U_kV")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdatedIPAddress")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasDefaultValueSql("''");

                    b.Property<string>("UpdatedPCName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValueSql("''");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    SqlServerIndexBuilderExtensions.IsClustered(b.HasIndex("Date"), false);

                    b.HasIndex("RecloserId");

                    b.HasIndex("SheetName", "RecloserId", "Date", "Time")
                        .IsUnique()
                        .HasFilter("[Date] IS NOT NULL");

                    b.ToTable("RecloserDatas");
                });

            modelBuilder.Entity("Cody_v3.Repositories.Entities.Recloser", b =>
                {
                    b.HasOne("Cody_v3.Repositories.Entities.Department", "Department")
                        .WithMany("Reclosers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Cody_v3.Repositories.Entities.RecloserData", b =>
                {
                    b.HasOne("Cody_v3.Repositories.Entities.Recloser", "Recloser")
                        .WithMany("RecloserDatas")
                        .HasForeignKey("RecloserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recloser");
                });

            modelBuilder.Entity("Cody_v3.Repositories.Entities.Department", b =>
                {
                    b.Navigation("Reclosers");
                });

            modelBuilder.Entity("Cody_v3.Repositories.Entities.Recloser", b =>
                {
                    b.Navigation("RecloserDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
