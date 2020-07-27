﻿// <auto-generated />
using System;
using LizokasNail.Core.Dao.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LizokasNail.Core.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20200727150124_addCommentToCheck2Design")]
    partial class addCommentToCheck2Design
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Base", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Base");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Check", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BaseId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RecordId")
                        .HasColumnType("int");

                    b.Property<int?>("TopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BaseId");

                    b.HasIndex("ColorId");

                    b.HasIndex("RecordId")
                        .IsUnique();

                    b.HasIndex("TopId");

                    b.ToTable("Check");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Check2Design", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCheck")
                        .HasColumnType("int");

                    b.Property<int>("IdDesign")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCheck");

                    b.HasIndex("IdDesign");

                    b.ToTable("Check2Design");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Design", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Design");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Top", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Top");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommunicationType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Check", b =>
                {
                    b.HasOne("LizokasNail.Core.Dao.Model.Base", "Base")
                        .WithMany()
                        .HasForeignKey("BaseId");

                    b.HasOne("LizokasNail.Core.Dao.Model.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("LizokasNail.Core.Dao.Model.Record", "Record")
                        .WithOne("Check")
                        .HasForeignKey("LizokasNail.Core.Dao.Model.Check", "RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LizokasNail.Core.Dao.Model.Top", "Top")
                        .WithMany()
                        .HasForeignKey("TopId");
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Check2Design", b =>
                {
                    b.HasOne("LizokasNail.Core.Dao.Model.Check", "Check")
                        .WithMany("Check2Design")
                        .HasForeignKey("IdCheck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LizokasNail.Core.Dao.Model.Design", "Design")
                        .WithMany()
                        .HasForeignKey("IdDesign")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LizokasNail.Core.Dao.Model.Record", b =>
                {
                    b.HasOne("LizokasNail.Core.Dao.Model.User", "User")
                        .WithMany("Records")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
