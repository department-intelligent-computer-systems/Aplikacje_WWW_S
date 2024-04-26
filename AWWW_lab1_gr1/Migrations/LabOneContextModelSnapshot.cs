﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AWWW_lab1_gr1.Migrations
{
    [DbContext(typeof(LabOneContext))]
    partial class LabOneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lead")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MatchId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ArticleTag", b =>
                {
                    b.Property<int>("ArticlesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticlesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stadium")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MatchEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MatchPlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Minute")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchPlayerId");

                    b.ToTable("MatchEvents");
                });

            modelBuilder.Entity("MatchPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PositionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PositionId");

                    b.ToTable("MatchPlayers");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PositionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId", "PositionId");

                    b.HasIndex("PositionId");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FoundingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("LeagueId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Article", b =>
                {
                    b.HasOne("Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Match", "Match")
                        .WithMany("Articles")
                        .HasForeignKey("MatchId");

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("ArticleTag", b =>
                {
                    b.HasOne("Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.HasOne("Article", null)
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId");
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.HasOne("Team", "AwayTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("MatchEvent", b =>
                {
                    b.HasOne("EventType", "EventType")
                        .WithMany("MatchEvents")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Match", "Match")
                        .WithMany("MatchEvents")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MatchPlayer", "MatchPlayer")
                        .WithMany()
                        .HasForeignKey("MatchPlayerId");

                    b.Navigation("EventType");

                    b.Navigation("Match");

                    b.Navigation("MatchPlayer");
                });

            modelBuilder.Entity("MatchPlayer", b =>
                {
                    b.HasOne("Match", "Match")
                        .WithMany("MatchPlayers")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Player", "Player")
                        .WithMany("MatchPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Position", "Position")
                        .WithMany("MatchPlayers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.HasOne("Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.HasOne("Player", "Player")
                        .WithMany("PlayerPositions")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Position", "Position")
                        .WithMany("PlayerPositions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.HasOne("League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("EventType", b =>
                {
                    b.Navigation("MatchEvents");
                });

            modelBuilder.Entity("League", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("MatchEvents");

                    b.Navigation("MatchPlayers");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Navigation("MatchPlayers");

                    b.Navigation("PlayerPositions");
                });

            modelBuilder.Entity("Position", b =>
                {
                    b.Navigation("MatchPlayers");

                    b.Navigation("PlayerPositions");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("HomeMatches");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
