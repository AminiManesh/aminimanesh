﻿// <auto-generated />
using System;
using Aminimanesh.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aminimanesh.DataLayer.Migrations
{
    [DbContext(typeof(AminimaneshContext))]
    [Migration("20230806204225_initDbSec")]
    partial class initDbSec
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Amin", b =>
                {
                    b.Property<int>("AminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AminId"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eitaa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AminId");

                    b.ToTable("Amins");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"));

                    b.Property<int>("AminId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("LanguageId");

                    b.HasIndex("AminId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.MiniSkill", b =>
                {
                    b.Property<int>("MiniSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MiniSkillId"));

                    b.Property<int>("AminId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MiniSkillId");

                    b.HasIndex("AminId");

                    b.ToTable("MiniSkills");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PictureId"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("PictureId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<int>("AminId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<string>("MiniDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.HasIndex("AminId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<int>("AminId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.HasIndex("AminId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<int>("AminId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("SkillId");

                    b.HasIndex("AminId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Language", b =>
                {
                    b.HasOne("Aminimanesh.DataLayer.Entities.Amin.Amin", "Amin")
                        .WithMany("Languages")
                        .HasForeignKey("AminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amin");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.MiniSkill", b =>
                {
                    b.HasOne("Aminimanesh.DataLayer.Entities.Amin.Amin", "Amin")
                        .WithMany("MiniSkills")
                        .HasForeignKey("AminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amin");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Picture", b =>
                {
                    b.HasOne("Aminimanesh.DataLayer.Entities.Amin.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Project", b =>
                {
                    b.HasOne("Aminimanesh.DataLayer.Entities.Amin.Amin", "Amin")
                        .WithMany("Projects")
                        .HasForeignKey("AminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amin");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Service", b =>
                {
                    b.HasOne("Aminimanesh.DataLayer.Entities.Amin.Amin", "Amin")
                        .WithMany("Services")
                        .HasForeignKey("AminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amin");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Skill", b =>
                {
                    b.HasOne("Aminimanesh.DataLayer.Entities.Amin.Amin", "Amin")
                        .WithMany("Skills")
                        .HasForeignKey("AminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amin");
                });

            modelBuilder.Entity("Aminimanesh.DataLayer.Entities.Amin.Amin", b =>
                {
                    b.Navigation("Languages");

                    b.Navigation("MiniSkills");

                    b.Navigation("Projects");

                    b.Navigation("Services");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}