﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TreeApiDbContext))]
    [Migration("20230510191612_changeroot")]
    partial class changeroot
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Diagnostics.Model.MJournal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("eventId")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Journals");
                });

            modelBuilder.Entity("DataAccess.Tree.Model.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("isRoot")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parentNodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("parentNodeId");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("DataAccess.Tree.Model.Node", b =>
                {
                    b.HasOne("DataAccess.Tree.Model.Node", "parentNode")
                        .WithMany("children")
                        .HasForeignKey("parentNodeId");

                    b.Navigation("parentNode");
                });

            modelBuilder.Entity("DataAccess.Tree.Model.Node", b =>
                {
                    b.Navigation("children");
                });
#pragma warning restore 612, 618
        }
    }
}