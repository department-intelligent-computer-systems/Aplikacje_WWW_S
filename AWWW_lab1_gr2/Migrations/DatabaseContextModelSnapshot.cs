﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AWWW_lab1_gr2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ArticleId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MatchId");

                    b.ToTable("Articles", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EventTypeId");

                    b.ToTable("EventTypes", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stadium")
                        .HasColumnType("TEXT");

                    b.HasKey("MatchId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Matches", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.MatchEvent", b =>
                {
                    b.Property<int>("MatchEventId")
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

                    b.HasKey("MatchEventId");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchPlayerId");

                    b.ToTable("MatchEvents", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.MatchPlayer", b =>
                {
                    b.Property<int>("MatchPlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PositionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("MatchPlayerId");

                    b.HasIndex("PositionId");

                    b.ToTable("MatchPlayers", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
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

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PositionId");

                    b.ToTable("Positions", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FieldOfStudy")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("IndexNr")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.ToTable("Tags", (string)null);
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Teams", (string)null);
                });

            modelBuilder.Entity("ArticleTag", b =>
                {
                    b.Property<int>("ArticlesArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticlesArticleId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.Property<int>("PlayersPlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PositionsPositionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayersPlayerId", "PositionsPositionId");

                    b.HasIndex("PositionsPositionId");

                    b.ToTable("PlayerPosition");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Article", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.Match", "Match")
                        .WithMany("Articles")
                        .HasForeignKey("MatchId");

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Comment", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Match", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Team", "AwayTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.MatchEvent", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.EventType", "EventType")
                        .WithMany("MatchEvents")
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.MatchPlayer", "MatchPlayer")
                        .WithMany("MatchEvents")
                        .HasForeignKey("MatchPlayerId");

                    b.Navigation("EventType");

                    b.Navigation("Match");

                    b.Navigation("MatchPlayer");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.MatchPlayer", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Position", null)
                        .WithMany("MatchPlayers")
                        .HasForeignKey("PositionId");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Player", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ArticleTag", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.HasOne("AWWW_lab1_gr2.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AWWW_lab1_gr2.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionsPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Author", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.EventType", b =>
                {
                    b.Navigation("MatchEvents");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Match", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.MatchPlayer", b =>
                {
                    b.Navigation("MatchEvents");
                });

            modelBuilder.Entity("AWWW_lab1_gr2.Models.Position", b =>
                {
                    b.Navigation("MatchPlayers");
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
