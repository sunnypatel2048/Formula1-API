﻿// <auto-generated />
using System;
using Formula1.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Formula1.Infrastructure.Migrations
{
    [DbContext(typeof(F1DataContext))]
    [Migration("20230706204455_sunnypatel2048-patch-3-update2")]
    partial class sunnypatel2048patch3update2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Formula1.Infrastructure.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<double>("CareerPoints")
                        .HasColumnType("double precision");

                    b.Property<int>("ChampionshipWins")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("CurrentTeamId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int>("FastestLaps")
                        .HasColumnType("integer");

                    b.Property<string>("FirstRace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastRace")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PodiumFinishes")
                        .HasColumnType("integer");

                    b.Property<int>("PolePositions")
                        .HasColumnType("integer");

                    b.Property<int>("RaceStarts")
                        .HasColumnType("integer");

                    b.Property<int>("RaceWins")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CurrentTeamId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Formula1.Infrastructure.Models.EngineProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EngineProviders");
                });

            modelBuilder.Entity("Formula1.Infrastructure.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BaseCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ConstructorChampionships")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CurrentChassis")
                        .HasColumnType("text");

                    b.Property<int?>("CurrentEngineProviderId")
                        .HasColumnType("integer");

                    b.Property<int?>("CurrentTeamPrincipalId")
                        .HasColumnType("integer");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Podiums")
                        .HasColumnType("integer");

                    b.Property<int>("PolePositions")
                        .HasColumnType("integer");

                    b.Property<int>("RaceEntered")
                        .HasColumnType("integer");

                    b.Property<int>("RaceWins")
                        .HasColumnType("integer");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrentEngineProviderId");

                    b.HasIndex("CurrentTeamPrincipalId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Formula1.Infrastructure.Models.TeamPrincipal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TeamPrincipals");
                });

            modelBuilder.Entity("Formula1.Infrastructure.Models.Driver", b =>
                {
                    b.HasOne("Formula1.Infrastructure.Models.Team", "CurrentTeam")
                        .WithMany()
                        .HasForeignKey("CurrentTeamId");

                    b.Navigation("CurrentTeam");
                });

            modelBuilder.Entity("Formula1.Infrastructure.Models.Team", b =>
                {
                    b.HasOne("Formula1.Infrastructure.Models.EngineProvider", "CurrentEngineProvider")
                        .WithMany()
                        .HasForeignKey("CurrentEngineProviderId");

                    b.HasOne("Formula1.Infrastructure.Models.TeamPrincipal", "CurrentTeamPrincipal")
                        .WithMany()
                        .HasForeignKey("CurrentTeamPrincipalId");

                    b.Navigation("CurrentEngineProvider");

                    b.Navigation("CurrentTeamPrincipal");
                });
#pragma warning restore 612, 618
        }
    }
}
