using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using NuGet.Protocol.Core.Types;
using PetShelter.Data;
using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PetShelter.Data.Entities;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;

namespace PetShelter.Tests.Repos
{
    public class PetRepositoryTests: BaseRepositoryTests<PetRepository,Pet, PetDto>
    {
        public IPetsService _petsService { get; set; }

        public PetRepositoryTests(IPetsService petsService)
        {
            _petsService = petsService;
        }

        [Test]
        public async Task GivePetAsync_ShouldAssignUserIdAndShelterIdAndSavePet()
        {
            // Arrange
            var userId = 1;
            var shelterId = 1;
            var petDto = new PetDto { Id = 1 };

            // Act
            await _petsService.GivePetAsync(userId, shelterId, petDto);

            // Assert
            var savedPet = await mockContext.Pets.FindAsync(1);
            Assert.DoesNotThrow(savedPet);
            Assert.That(userId, savedPet.UserId, Is.EqualTo(petDto));
            //Assert.AreEqual(userId, savedPet.UserId);
            Assert.That(shelterId, savedPet.UserId, Is.EqualTo(petDto));
            //Assert.AreEqual(shelterId, savedPet.ShelterId);
        }
    }
}
