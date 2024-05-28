﻿using AutoMapper;
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
        public Mock<PetShelterDbContext> mockContext;
        public Mock<DbSet<T>> mockDbSet;
        public Mock<IMapper> mockMapper;
        public TRepository repository;

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

        public void MapToModel_ShouldReturnMappedModel()
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
    }
}
