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
        private Mock<PetShelterDbContext> mockContext;
        private Mock<DbSet<T>> mockDbSet;
        private Mock<IMapper> mockMapper;
        private TRepository repository;

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
    }
}
