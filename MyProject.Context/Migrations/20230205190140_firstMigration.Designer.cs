﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProject.Context;

#nullable disable

namespace MyProject.Context.Migrations
{
    [DbContext(typeof(MyContext.MyDbContex))]
    [Migration("20230205190140_firstMigration")]
    partial class firstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyProject.Repositories.Entities.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parent1Id")
                        .HasColumnType("int");

                    b.Property<int>("Parent2Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Parent1Id");

                    b.HasIndex("Parent2Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("MyProject.Repositories.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.Property<int>("Kupach")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyProject.Repositories.Entities.Child", b =>
                {
                    b.HasOne("MyProject.Repositories.Entities.User", "Parent1")
                        .WithMany()
                        .HasForeignKey("Parent1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyProject.Repositories.Entities.User", "Parent2")
                        .WithMany()
                        .HasForeignKey("Parent2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent1");

                    b.Navigation("Parent2");
                });
#pragma warning restore 612, 618
        }
    }
}
