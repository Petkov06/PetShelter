﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShelter.Data;

#nullable disable

namespace PetShelter.Data.Migrations
{
    [DbContext(typeof(PetShelterDbContext))]
    partial class PetShelterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShelter.Data.Entities.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShelterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId")
                        .IsUnique()
                        .HasFilter("[ShelterId] IS NOT NULL");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdopterId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GiverId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdopted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEuthanized")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PetTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ShelterId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdopterId");

                    b.HasIndex("BreedId");

                    b.HasIndex("GiverId");

                    b.HasIndex("PetTypeId");

                    b.HasIndex("ShelterId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.PetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.PetVaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PetId")
                        .HasColumnType("int");

                    b.Property<int?>("VaccineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("VaccineId");

                    b.ToTable("PetVaccines");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Employee"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Shelter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("PetCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Shelters");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("ShelterId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("ShelterId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Admin",
                            LastName = "User",
                            Password = "Lck9WmzbpVmzrLjALW8lod3k2E86fhvNYjuVQQBcjGbss1mVyzud8DPsAK+kSMW6",
                            RoleId = 3,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Location", b =>
                {
                    b.HasOne("PetShelter.Data.Entities.Shelter", "Shelter")
                        .WithOne("Location")
                        .HasForeignKey("PetShelter.Data.Entities.Location", "ShelterId");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Pet", b =>
                {
                    b.HasOne("PetShelter.Data.Entities.User", "Adopter")
                        .WithMany("AdoptedPets")
                        .HasForeignKey("AdopterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PetShelter.Data.Entities.Breed", "Breed")
                        .WithMany("Pets")
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShelter.Data.Entities.User", "Giver")
                        .WithMany("GivenPets")
                        .HasForeignKey("GiverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PetShelter.Data.Entities.PetType", "PetType")
                        .WithMany("Pets")
                        .HasForeignKey("PetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShelter.Data.Entities.Shelter", "Shelter")
                        .WithMany("Pets")
                        .HasForeignKey("ShelterId");

                    b.Navigation("Adopter");

                    b.Navigation("Breed");

                    b.Navigation("Giver");

                    b.Navigation("PetType");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.PetVaccine", b =>
                {
                    b.HasOne("PetShelter.Data.Entities.Pet", "Pet")
                        .WithMany("PetVaccines")
                        .HasForeignKey("PetId");

                    b.HasOne("PetShelter.Data.Entities.Vaccine", "Vaccine")
                        .WithMany("PetVaccines")
                        .HasForeignKey("VaccineId");

                    b.Navigation("Pet");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.User", b =>
                {
                    b.HasOne("PetShelter.Data.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("PetShelter.Data.Entities.Shelter", "Shelter")
                        .WithMany("Employees")
                        .HasForeignKey("ShelterId");

                    b.Navigation("Role");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Breed", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Pet", b =>
                {
                    b.Navigation("PetVaccines");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.PetType", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Shelter", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Location");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.User", b =>
                {
                    b.Navigation("AdoptedPets");

                    b.Navigation("GivenPets");
                });

            modelBuilder.Entity("PetShelter.Data.Entities.Vaccine", b =>
                {
                    b.Navigation("PetVaccines");
                });
#pragma warning restore 612, 618
        }
    }
}
