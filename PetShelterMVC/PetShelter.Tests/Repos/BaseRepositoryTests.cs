using AutoMapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Moq;
using PetShelter.Data.Data;
using PetShelter.Data.Data.Repos;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShelter.Data;

namespace PetShelter.Tests.Repos
{
    public class BaseRepositoryTests<TRepository, T, TModel>
        where TRepository : BaseRepository<T,TModel>
        where T : class,IBaseEntity 
        where TModel : BaseModel
    {
        protected Mock<PetShelterDbContext> mockContext;
        protected Mock<DbSet<T>> mockDbSet;
        protected Mock<IMapper> mockMapper;
        protected TRepository repository;

        [SetUp]
        public void Setup()
        {
            mockContext = new Mock<PetShelterDbContext>();
            mockDbSet = new Mock<DbSet<T>>();
            mockMapper = new Mock<IMapper>();
            repository = new Mock<TRepository>(mockContext.Object, mockMapper.Object)
            {
                CallBase = true
            }.Object;
        }
        [Test]
        public void MapToModel_ValidEntity_ReturnsMappedModel()
        {
            //Arrange
            var entity = new Mock<T>();
            var model = new Mock<TModel>();
            mockMapper.Setup(m => m.Map<TModel>(entity.Object)).Returns(model.Object);

            //Act
            var result = repository.MapToModel(entity.Object);

            //Assert
            Assert.That(result, Is.EqualTo(model.Object));
        }
        [Test]
        public void MapToEntity_Shouuld_ReturnsMappedEntity()
        {
            // Arrange
            var entity = new Mock<T>();
            var model = new Mock<TModel>();
            mockMapper.Setup(m => m.Map<T>(model.Object)).Returns(entity.Object);

            // Act
            var result = repository.MapToEntity(model.Object);

            // Assert
            Assert.That(result, Is.EqualTo(entity.Object));
        }
    }
}
