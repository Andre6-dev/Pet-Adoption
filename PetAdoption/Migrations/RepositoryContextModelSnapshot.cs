﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace PetAdoption.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PetId");

                    b.Property<string>("BaseColor")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            BaseColor = "White with Orange",
                            Breed = "Domestic Shorthair",
                            DateOfBirth = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Calicha is a very playful cat. She loves to play with her toys and with other cats. She is very friendly and loves to be petted.",
                            Name = "Calicha",
                            ProfilePicture = "https://ih1.redbubble.net/image.5216930147.0695/raf,360x360,075,t,fafafa:ca443f4786.jpg",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            BaseColor = "Black",
                            Breed = "Domestic Shorthair",
                            DateOfBirth = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Milo is a very playful cat. He loves to play with his toys and with other cats. He is very friendly and loves to be petted.",
                            Name = "Milo",
                            ProfilePicture = "https://i.pinimg.com/222x/3a/03/66/3a036686ccb51b93ebcea512672a3fe9.jpg",
                            Sex = "Male",
                            Species = "Cat"
                        });
                });

            modelBuilder.Entity("Entities.Models.Vaccine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("VaccineId");

                    b.Property<double?>("Cost")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfVaccination")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("NextVaccination")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Vaccines");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Cost = 100.0,
                            CreatedAt = new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9171),
                            DateOfVaccination = new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rabies",
                            NextVaccination = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PetId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UpdatedAt = new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9180)
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Cost = 40.0,
                            CreatedAt = new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9183),
                            DateOfVaccination = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Canine Distemper Vaccine",
                            NextVaccination = new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PetId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            UpdatedAt = new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9184)
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Cost = 30.0,
                            CreatedAt = new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9187),
                            DateOfVaccination = new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Feline Leukemia Vaccine",
                            NextVaccination = new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PetId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            UpdatedAt = new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9188)
                        });
                });

            modelBuilder.Entity("Entities.Models.Vaccine", b =>
                {
                    b.HasOne("Entities.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}