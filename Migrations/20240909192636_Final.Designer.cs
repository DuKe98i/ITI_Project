﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_2;

#nullable disable

namespace Test_2.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240909192636_Final")]
    partial class Final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test_2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is Descriotion",
                            Name = "Storage"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is Descriotion",
                            Name = "Desktop"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is Descriotion",
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is Descriotion",
                            Name = "monitors"
                        });
                });

            modelBuilder.Entity("Test_2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 1234m,
                            Quantity = 22,
                            Title = " Mouse"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 2234m,
                            Quantity = 11,
                            Title = " Gaming Monitor  "
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 3234m,
                            Quantity = 23,
                            Title = " Keyboard  "
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 4234m,
                            Quantity = 18,
                            Title = " Gaming Headset"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 5234m,
                            Quantity = 8,
                            Title = " Motherboard "
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 6234m,
                            Quantity = 3,
                            Title = " Mouse pad"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 7234m,
                            Quantity = 2,
                            Title = " RAM "
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 8234m,
                            Quantity = 5,
                            Title = " Usb driver"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 9234m,
                            Quantity = 6,
                            Title = " Hard disk "
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 10234m,
                            Quantity = 4,
                            Title = " SSD "
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 10234m,
                            Quantity = 16,
                            Title = " Proccessor "
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Description = "This is Description",
                            ImagePath = "Image_Path",
                            Price = 10234m,
                            Quantity = 26,
                            Title = " Graphics card "
                        });
                });

            modelBuilder.Entity("Test_2.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Ahmed123@mail.com",
                            FirstName = "Ahmed",
                            LastName = "Sabri",
                            Password = "123 "
                        },
                        new
                        {
                            Id = 2,
                            Email = "Rami123@mail.com",
                            FirstName = "Rami",
                            LastName = "Sabri",
                            Password = "123 "
                        },
                        new
                        {
                            Id = 3,
                            Email = "Hadi123@mail.com",
                            FirstName = "Hadi",
                            LastName = "Mohammed",
                            Password = "123 "
                        },
                        new
                        {
                            Id = 4,
                            Email = "Karim123@mail.com",
                            FirstName = "Karim",
                            LastName = "Ibrahim",
                            Password = "123 "
                        });
                });

            modelBuilder.Entity("Test_2.Models.Product", b =>
                {
                    b.HasOne("Test_2.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Test_2.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
