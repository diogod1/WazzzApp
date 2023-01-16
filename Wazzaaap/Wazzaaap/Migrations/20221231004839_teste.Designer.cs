﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wazzaaap.Model;

namespace Wazzaaap.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221231004839_teste")]
    partial class teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Wazzaaap.Model.chat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("chatid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("chatid");

                    b.ToTable("chats");
                });

            modelBuilder.Entity("Wazzaaap.Model.messages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("chatid")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("sentAt")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("chatid");

                    b.HasIndex("userid");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("Wazzaaap.Model.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bio")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("photo_path")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<int?>("userid")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Wazzaaap.Model.chat", b =>
                {
                    b.HasOne("Wazzaaap.Model.chat", null)
                        .WithMany("Chats")
                        .HasForeignKey("chatid");
                });

            modelBuilder.Entity("Wazzaaap.Model.messages", b =>
                {
                    b.HasOne("Wazzaaap.Model.chat", "Chat")
                        .WithMany()
                        .HasForeignKey("chatid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wazzaaap.Model.user", "User")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Wazzaaap.Model.user", b =>
                {
                    b.HasOne("Wazzaaap.Model.user", null)
                        .WithMany("users")
                        .HasForeignKey("userid");
                });

            modelBuilder.Entity("Wazzaaap.Model.chat", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("Wazzaaap.Model.user", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}