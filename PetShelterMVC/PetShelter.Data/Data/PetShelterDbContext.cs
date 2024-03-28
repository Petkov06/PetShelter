﻿using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Entities;
using PetShelter.Shared.Enums;

//using PetShelter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Data
{
    public class PetShelterDbContext
        : DbContext
    {
        public PetShelterDbContext(DbContextOptions<PetShelterDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<User> BaseEntity { get; set; }
        public DbSet<User> Breed { get; set; }
        public DbSet<User> Location { get; set; }
        public DbSet<User> Pet { get; set; }
        public DbSet<User> PetType { get; set; }
        public DbSet<User> PetVaccine { get; set; }
        public DbSet<User> Role { get; set; }
        public DbSet<User> Role { get; set; }
        public DbSet<User> Vaccine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Breed>().HasMany(b => b.Pets).WithOne(p => p.Breed).HasForeignKey(p => p.BreedId);

            modelBuilder.Entity<User>().HasMany(u => u.AdoptedPets).WithOne(p => p.Adopter).HasForeignKey(p => p.AdopterId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasMany(u => u.GivenPets).WithOne(u => u.Giver).HasForeignKey(p => p.GiverId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Shelter>().HasOne(a => a.Location).WithOne(a => a.Shelter).HasForeignKey<Location>(c => c.ShelterId);


            foreach (var role in Enum.GetValues(typeof(UserRole)).Cast<UserRole>())
            {
                modelBuilder.Entity<Role>().HasData(new Role { Id = (int)role, Name = role.ToString() });
            }

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "admin",
                RoleId = (int)UserRole.Admin,
                FirstName = "Admin",
                LastName = "User",
                Password = PasswordHasher.HashPassword("string")
            });


        }

    }
}
