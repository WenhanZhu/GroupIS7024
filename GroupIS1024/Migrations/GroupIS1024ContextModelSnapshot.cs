﻿// <auto-generated />
using System;
using GroupIS1024.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroupIS1024.Migrations
{
    [DbContext(typeof(GroupIS1024Context))]
    partial class GroupIS1024ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GroupIS1024.Models.Coach", b =>
            {
                b.Property<int>("CoachId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachId"), 1L, 1);

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("Memberstatus")
                    .HasColumnType("bit");

                b.Property<string>("State")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("TeamId")
                    .HasColumnType("int");

                b.Property<string>("Username")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("CoachId");

                b.HasIndex("TeamId");

                b.ToTable("Coach");
            });

            modelBuilder.Entity("GroupIS1024.Models.Player", b =>
            {
                b.Property<int>("PlayerId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                b.Property<string>("City")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("DateOfBirth")
                    .HasColumnType("datetime2");

                b.Property<int>("Experience")
                    .HasColumnType("int");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Position")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("State")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("TeamId")
                    .HasColumnType("int");

                b.Property<string>("University")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("PlayerId");

                b.HasIndex("TeamId");

                b.ToTable("Player");
            });

            modelBuilder.Entity("GroupIS1024.Models.Team", b =>
            {
                b.Property<int>("TeamId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"), 1L, 1);

                b.Property<string>("TeamName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("TeamId");

                b.ToTable("Team");
            });

            modelBuilder.Entity("GroupIS1024.Models.Coach", b =>
            {
                b.HasOne("GroupIS1024.Models.Team", "Team")
                    .WithMany("Coaches")
                    .HasForeignKey("TeamId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Team");
            });

            modelBuilder.Entity("GroupIS1024.Models.Player", b =>
            {
                b.HasOne("GroupIS1024.Models.Team", "Team")
                    .WithMany("Players")
                    .HasForeignKey("TeamId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Team");
            });

            modelBuilder.Entity("GroupIS1024.Models.Team", b =>
            {
                b.Navigation("Coaches");

                b.Navigation("Players");
            });
#pragma warning restore 612, 618
        }
    }
}

