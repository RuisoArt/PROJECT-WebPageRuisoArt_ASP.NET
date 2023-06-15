﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ruisoArtPage.Data;

#nullable disable

namespace ruisoArtPage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230525222006_MyAppMigration-Shopping")]
    partial class MyAppMigrationShopping
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ruisoArtPage.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ruisoArtPage.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("link")
                        .HasColumnType("longtext");

                    b.Property<string>("size")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ruisoArtPage.Models.CategoryCommi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CommissionId");

                    b.ToTable("CategoryCommi");
                });

            modelBuilder.Entity("ruisoArtPage.Models.CategoryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Commission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AproxPrice")
                        .HasColumnType("double");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageReference")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonLastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Commission");
                });

            modelBuilder.Entity("ruisoArtPage.Models.DocCommi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommissionId")
                        .HasColumnType("int");

                    b.Property<int>("DocId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommissionId");

                    b.HasIndex("DocId");

                    b.ToTable("DocCommi");
                });

            modelBuilder.Entity("ruisoArtPage.Models.DocProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("ProductId");

                    b.ToTable("DocProduct");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ruisoArtPage.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("creationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("externalLink")
                        .HasColumnType("longtext");

                    b.Property<int>("formatImage")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<int>("modelClothes")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("nftLink")
                        .HasColumnType("longtext");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("rolDice")
                        .HasColumnType("int");

                    b.Property<string>("season")
                        .HasColumnType("longtext");

                    b.Property<string>("shoppingWay")
                        .HasColumnType("longtext");

                    b.Property<int>("sizeBookMarker")
                        .HasColumnType("int");

                    b.Property<int>("sizeClothes")
                        .HasColumnType("int");

                    b.Property<int>("sizeCup")
                        .HasColumnType("int");

                    b.Property<string>("sizeDice")
                        .HasColumnType("longtext");

                    b.Property<int>("sizeNotepad")
                        .HasColumnType("int");

                    b.Property<int>("sizePaper")
                        .HasColumnType("int");

                    b.Property<string>("sizePrint")
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<double>("tax")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("link")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("phone")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed0")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed1")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed10")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed11")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed12")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed13")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed14")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed15")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed16")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed17")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed18")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed19")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed2")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed3")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed4")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed5")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed6")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed7")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed8")
                        .HasColumnType("longtext");

                    b.Property<string>("socialRed9")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ruisoArtPage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ruisoArtPage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ruisoArtPage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ruisoArtPage.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ruisoArtPage.Models.Banner", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Provider", "Provider")
                        .WithMany("Banners")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("ruisoArtPage.Models.CategoryCommi", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Category", "Category")
                        .WithMany("CategoryCommis")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ruisoArtPage.Models.Commission", "Commission")
                        .WithMany("CategoryCommis")
                        .HasForeignKey("CommissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Commission");
                });

            modelBuilder.Entity("ruisoArtPage.Models.CategoryProduct", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ruisoArtPage.Models.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ruisoArtPage.Models.DocCommi", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Commission", "Commission")
                        .WithMany("DocCommis")
                        .HasForeignKey("CommissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ruisoArtPage.Models.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commission");

                    b.Navigation("Document");
                });

            modelBuilder.Entity("ruisoArtPage.Models.DocProduct", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Document", "Document")
                        .WithMany("DocProducts")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ruisoArtPage.Models.Product", "Product")
                        .WithMany("DocProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Order", b =>
                {
                    b.HasOne("ruisoArtPage.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ruisoArtPage.Models.OrderItem", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ruisoArtPage.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Product", b =>
                {
                    b.HasOne("ruisoArtPage.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Category", b =>
                {
                    b.Navigation("CategoryCommis");

                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Commission", b =>
                {
                    b.Navigation("CategoryCommis");

                    b.Navigation("DocCommis");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Document", b =>
                {
                    b.Navigation("DocProducts");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Product", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("DocProducts");
                });

            modelBuilder.Entity("ruisoArtPage.Models.Provider", b =>
                {
                    b.Navigation("Banners");
                });
#pragma warning restore 612, 618
        }
    }
}