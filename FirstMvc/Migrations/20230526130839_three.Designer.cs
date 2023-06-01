﻿// <auto-generated />
using FirstMvc.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstMvc.Migrations
{
    [DbContext(typeof(AppDbContexts))]
    [Migration("20230526130839_three")]
    partial class three
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstMvc.Models.Talaba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ismi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manzili")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnversitetId")
                        .HasColumnType("int");

                    b.Property<int>("Yoshi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnversitetId");

                    b.ToTable("Talabas");
                });

            modelBuilder.Entity("FirstMvc.Models.Unversitet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unversitetlar");
                });

            modelBuilder.Entity("FirstMvc.Models.Talaba", b =>
                {
                    b.HasOne("FirstMvc.Models.Unversitet", "Unversitets")
                        .WithMany("Talabas")
                        .HasForeignKey("UnversitetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unversitets");
                });

            modelBuilder.Entity("FirstMvc.Models.Unversitet", b =>
                {
                    b.Navigation("Talabas");
                });
#pragma warning restore 612, 618
        }
    }
}
