﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AWWW_lab1_gr2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240405091741_Migracja")]
    partial class Migracja
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FoundingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Match", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId");

                    b.HasOne("AWWW_lab1_gr2.Models.Team", "Opponents")
                        .WithMany("AwayMatches")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("HomeTeam");

                    b.Navigation("Opponents");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Player", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Position", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Player", null)
                        .WithMany("Positions")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Team", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");

                    b.Navigation("League");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Player", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Team", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("HomeMatches");
                });
#pragma warning restore 612, 618
        }
    }
}
