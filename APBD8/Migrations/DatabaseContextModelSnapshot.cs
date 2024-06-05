﻿// <auto-generated />
using APBD8.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APBD8.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APBD8.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_account");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("phone");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("FK_role");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "123456789",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.doe@example.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            Phone = "987654321",
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("APBD8.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_category");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        });
                });

            modelBuilder.Entity("APBD8.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_product");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Depth")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("depth");

                    b.Property<decimal>("Height")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("height");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<decimal>("Weight")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("weight");

                    b.Property<decimal>("Width")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("width");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Depth = 24.0m,
                            Height = 2.0m,
                            Name = "Laptop",
                            Weight = 2.5m,
                            Width = 35.5m
                        },
                        new
                        {
                            Id = 2,
                            Depth = 14.0m,
                            Height = 0.8m,
                            Name = "Smartphone",
                            Weight = 0.2m,
                            Width = 7.0m
                        });
                });

            modelBuilder.Entity("APBD8.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("FK_account");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("FK_Category");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products_Categories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("APBD8.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_role");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("APBD8.Models.ShopingCart", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("FK_account");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("FK_product");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.HasKey("AccountId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Shopping_Carts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            ProductId = 1,
                            Amount = 1
                        },
                        new
                        {
                            AccountId = 1,
                            ProductId = 2,
                            Amount = 2
                        },
                        new
                        {
                            AccountId = 2,
                            ProductId = 2,
                            Amount = 1
                        });
                });

            modelBuilder.Entity("APBD8.Models.Account", b =>
                {
                    b.HasOne("APBD8.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("APBD8.Models.ProductCategory", b =>
                {
                    b.HasOne("APBD8.Models.Category", "Category")
                        .WithMany("ProductsCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD8.Models.Product", "Product")
                        .WithMany("ProductsCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("APBD8.Models.ShopingCart", b =>
                {
                    b.HasOne("APBD8.Models.Account", "Account")
                        .WithMany("ShopingCarts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD8.Models.Product", "Product")
                        .WithMany("ShopingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("APBD8.Models.Account", b =>
                {
                    b.Navigation("ShopingCarts");
                });

            modelBuilder.Entity("APBD8.Models.Category", b =>
                {
                    b.Navigation("ProductsCategories");
                });

            modelBuilder.Entity("APBD8.Models.Product", b =>
                {
                    b.Navigation("ProductsCategories");

                    b.Navigation("ShopingCarts");
                });

            modelBuilder.Entity("APBD8.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
