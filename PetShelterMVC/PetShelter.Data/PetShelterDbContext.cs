using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShelter.Data.Entities;
using PetShelter.Shared.Enums;
using PetShelter.Shared.Security;
namespace PetShelter.Data
{
    public class PetShelterDbContext
        : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Breed> Breed { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<PetType> PetType { get; set; }
        public DbSet<PetVaccine> PetVaccine { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Shelter> Shelter { get; set; }
        public DbSet<Vaccine> Vaccine { get; set; }
        public PetShelterDbContext(DbContextOptions<PetShelterDbContext> options) : base(options)
        {

        }

        //public PetShelterDbContext(DbSet<User> users, DbSet<Breed> breed, DbSet<Location> location, DbSet<Pet> pet, DbSet<PetType> petType, DbSet<PetVaccine> petVaccine, DbSet<Role> role, DbSet<Shelter> shelter, DbSet<Vaccine> vaccine, DbContextOptions<PetShelterDbContext> options) : base(options)
        //{
        //    this.Users = users;
        //    this.Breed = breed;
        //    this.Location = location;
        //    this.Pet = pet;
        //    this.PetType = petType;
        //    this.PetVaccine = petVaccine;
        //    this.Role = role;
        //    this.Shelter = shelter;
        //    this.Vaccine = vaccine;
        //}

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
            modelBuilder.Entity<User>()
                .HasData(new User
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