﻿// <auto-generated />
using EED.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EED.DAL.Migrations
{
    [DbContext(typeof(EEDSqlContext))]
    [Migration("20171118142356_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EED.DAL.Models.Article", b =>
                {
                    b.Property<string>("IDArticles")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeAriclesID");

                    b.Property<string>("content");

                    b.Property<string>("title")
                        .HasMaxLength(20);

                    b.HasKey("IDArticles");

                    b.HasIndex("TypeAriclesID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("EED.DAL.Models.TypeAricles", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameType");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("TypeArticles");
                });

            modelBuilder.Entity("EED.DAL.Models.Article", b =>
                {
                    b.HasOne("EED.DAL.Models.TypeAricles", "TypeAricles")
                        .WithMany("articles")
                        .HasForeignKey("TypeAriclesID");
                });
#pragma warning restore 612, 618
        }
    }
}
