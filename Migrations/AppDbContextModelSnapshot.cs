﻿// <auto-generated />
using System;
using CQRSDemoApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CQRSDemoApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("CQRSDemoApp.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Team1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Team1Goals")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Team2")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Team2Goals")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Team1");

                    b.HasIndex("Team2");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("CQRSDemoApp.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Appearances")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Goals")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShirtNo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CQRSDemoApp.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("CQRSDemoApp.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("CQRSDemoApp.Models.Match", b =>
                {
                    b.HasOne("CQRSDemoApp.Models.Team", "Team1Navigation")
                        .WithMany("MatchTeam1Navigations")
                        .HasForeignKey("Team1")
                        .HasConstraintName("FK_Matches_Team1_Teams_Id");

                    b.HasOne("CQRSDemoApp.Models.Team", "Team2Navigation")
                        .WithMany("MatchTeam2Navigations")
                        .HasForeignKey("Team2")
                        .HasConstraintName("FK_Matches_Team2_Teams_Id");

                    b.Navigation("Team1Navigation");

                    b.Navigation("Team2Navigation");
                });

            modelBuilder.Entity("CQRSDemoApp.Models.Team", b =>
                {
                    b.Navigation("MatchTeam1Navigations");

                    b.Navigation("MatchTeam2Navigations");
                });
#pragma warning restore 612, 618
        }
    }
}
