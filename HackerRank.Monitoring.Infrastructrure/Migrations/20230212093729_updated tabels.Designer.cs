﻿// <auto-generated />
using System;
using HackerRank.Monitoring.Infrastructrure.Dbcontexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HackerRank.Monitoring.Infrastructrure.Migrations
{
    [DbContext(typeof(HRMonitaringDbContext))]
    [Migration("20230212093729_updated tabels")]
    partial class updatedtabels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.Algorithm_Questions", b =>
                {
                    b.Property<int>("Qus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Qus_Id"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qus_Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Topic_Id")
                        .HasColumnType("int");

                    b.HasKey("Qus_Id");

                    b.HasIndex("Topic_Id");

                    b.ToTable("algorithm_Questions");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.DataStructure_Questions", b =>
                {
                    b.Property<int>("Qus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Qus_Id"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qus_Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Topic_Id")
                        .HasColumnType("int");

                    b.HasKey("Qus_Id");

                    b.HasIndex("Topic_Id");

                    b.ToTable("dataStructure_Questions");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.HackerRank_Profile", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<int>("HR_Badges")
                        .HasColumnType("int");

                    b.Property<string>("HR_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HR_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Id");

                    b.ToTable("hackerRank_Profiles");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.Ratings", b =>
                {
                    b.Property<int>("Rating_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Rating_Id"));

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Submitted_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Time_Took")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Topic_Id")
                        .HasColumnType("int");

                    b.HasKey("Rating_Id");

                    b.HasIndex("Topic_Id");

                    b.ToTable("ratings");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.Topics", b =>
                {
                    b.Property<int>("Topic_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Topic_Id"));

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Topic_Id");

                    b.ToTable("topics");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.Algorithm_Questions", b =>
                {
                    b.HasOne("HackerRank.Monitoring.Domain.Models.Topics", "Topics")
                        .WithMany()
                        .HasForeignKey("Topic_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.DataStructure_Questions", b =>
                {
                    b.HasOne("HackerRank.Monitoring.Domain.Models.Topics", "Topics")
                        .WithMany()
                        .HasForeignKey("Topic_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("HackerRank.Monitoring.Domain.Models.Ratings", b =>
                {
                    b.HasOne("HackerRank.Monitoring.Domain.Models.Topics", "Topics")
                        .WithMany()
                        .HasForeignKey("Topic_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topics");
                });
#pragma warning restore 612, 618
        }
    }
}
