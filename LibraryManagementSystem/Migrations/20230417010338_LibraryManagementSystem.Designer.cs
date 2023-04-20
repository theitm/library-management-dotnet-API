﻿// <auto-generated />
using System;
using LibraryManagementSystem.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    [DbContext(typeof(LibraryManagementSystemDbContext))]
    [Migration("20230417010338_LibraryManagementSystem")]
    partial class LibraryManagementSystem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Book", b =>
                {
                    b.Property<int>("Book_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_ID"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publication_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type_ID")
                        .HasColumnType("int");

                    b.HasKey("Book_ID");

                    b.HasIndex("Type_ID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Borrowing", b =>
                {
                    b.Property<int>("Borrowing_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Borrowing_ID"));

                    b.Property<string>("Borrowing_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Due_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Returning_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Borrowing_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Borrowing");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.BorrowingDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int>("Borrowing_ID")
                        .HasColumnType("int");

                    b.Property<string>("Return_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Book_ID");

                    b.HasIndex("Borrowing_ID");

                    b.ToTable("BorrowingDetail");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Document", b =>
                {
                    b.Property<int>("Document_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Document_ID"));

                    b.Property<int>("Parent_ID")
                        .HasColumnType("int");

                    b.Property<int>("Parent_type")
                        .HasColumnType("int");

                    b.Property<int>("Type_URL")
                        .HasColumnType("int");

                    b.Property<int>("URL")
                        .HasColumnType("int");

                    b.HasKey("Document_ID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Evaluation", b =>
                {
                    b.Property<int>("Evaluation_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Evaluation_ID"));

                    b.Property<int>("Book_ID")
                        .HasColumnType("int");

                    b.Property<int>("Borrowing_ID")
                        .HasColumnType("int");

                    b.Property<string>("Comment_rate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time_rate")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Evaluation_ID");

                    b.HasIndex("Book_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.TypeBook", b =>
                {
                    b.Property<int>("Type_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Type_ID"));

                    b.Property<DateTime>("Date_created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type_ID");

                    b.ToTable("TypeBook");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"));

                    b.Property<string>("Access_level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Date_of_birth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Book", b =>
                {
                    b.HasOne("LibraryManagementSystem.models.Entity.TypeBook", "TypeBook")
                        .WithMany("Books")
                        .HasForeignKey("Type_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeBook");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Borrowing", b =>
                {
                    b.HasOne("LibraryManagementSystem.models.Entity.User", "User")
                        .WithMany("Borrowings")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.BorrowingDetail", b =>
                {
                    b.HasOne("LibraryManagementSystem.models.Entity.Book", "Book")
                        .WithMany("BorrowingDetail")
                        .HasForeignKey("Book_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.models.Entity.Borrowing", "Borrowing")
                        .WithMany("BorrowingDetails")
                        .HasForeignKey("Borrowing_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Borrowing");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Evaluation", b =>
                {
                    b.HasOne("LibraryManagementSystem.models.Entity.Book", "Book")
                        .WithMany("Evaluations")
                        .HasForeignKey("Book_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.models.Entity.User", "User")
                        .WithMany("Evaluations")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Book", b =>
                {
                    b.Navigation("BorrowingDetail");

                    b.Navigation("Evaluations");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.Borrowing", b =>
                {
                    b.Navigation("BorrowingDetails");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.TypeBook", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManagementSystem.models.Entity.User", b =>
                {
                    b.Navigation("Borrowings");

                    b.Navigation("Evaluations");
                });
#pragma warning restore 612, 618
        }
    }
}
