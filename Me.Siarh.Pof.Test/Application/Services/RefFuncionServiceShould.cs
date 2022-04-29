using Me.Siarh.Pof.Application.RefFuncionEntity.Dtos;
using Me.Siarh.Pof.Application.RefFuncionEntity.Services;
using Me.Siarh.Pof.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Me.Siarh.Pof.Quality.Application.Services
{
    public class RefFuncionServiceShould : GenericQuality
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        public async Task GetById_ExistEntity(int Id, bool expected)
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = false });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.GetById(Id);

            //Assert
            Assert.Equal(expected, response.Succeeded );
            //Assert.Equal(expected, (response.Entities.Count == 1));
        }

        [Fact]
        public async Task GetById_CountEntities()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.GetByFilter(new RefFuncionGetByFilterDTO() { });

            //Assert
            Assert.Equal(2, response.Entities.Count);
        }

        [Theory]
        [InlineData("B", 2)]
        [InlineData("X", 0)]
        public async Task GetByFilter_ContainsName(string name, int expected )
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion AB", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.GetByFilter(new RefFuncionGetByFilterDTO() { FuncionDescContains = name });

            //Assert
            Assert.Equal(expected, response.Entities.Count);
        }

        [Fact]
        public async Task Create_SuccessName()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Create(new RefFuncionCreateDTO() { FuncionDesc = "Ref Funcion C" });

            //Assert
            Assert.True(response.Succeeded);
        }

        [Fact]
        public async Task Create_SuccessCheckGetById()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();
            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            await service.Create(new RefFuncionCreateDTO() { FuncionDesc = "Ref Funcion C"});
            await unitofworkbis.CompleteAsync();

            var response = await service.GetById(3);

            //Assert
            Assert.True(response.Succeeded);
        }


        [Fact]
        public async Task Create_FailureAvoidName()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Create(new RefFuncionCreateDTO() { FuncionDesc = "" });

            //Assert
            Assert.False(response.Succeeded);
        }

        [Theory]
        [InlineData("RefFuncion C", true)]
        [InlineData("RefFuncion A", false)]
        public async Task Create_FailureExistName(string name, bool expected)
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Create(new RefFuncionCreateDTO() { FuncionDesc = name });

            //Assert
            Assert.Equal(expected, response.Succeeded);
        }

        [Fact]
        public async Task Update_SuccessName()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Update(new RefFuncionUpdateDTO() { Id = 1, FuncionDesc = "RefFuncion C", EstaActivo = true });

            //Assert
            Assert.True(response.Succeeded);
        }

        [Fact]
        public async Task Update_FailureAvoidName()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Update(new RefFuncionUpdateDTO() { Id = 1, FuncionDesc = "" });

            //Assert
            Assert.False(response.Succeeded);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(10, false)]
        public async Task Update_CheckExistId(int id , bool expected)
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Update(new RefFuncionUpdateDTO() { Id = id, FuncionDesc = "Ref Funcion C", EstaActivo = true });

            //Assert
            Assert.Equal(expected, response.Succeeded);
        }

        [Theory]
        [InlineData("RefFuncion A", true)]
        [InlineData("RefFuncion B", false)]
        public async Task Update_CheckExistName(string name, bool expected)
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);

            var response = await service.Update(new RefFuncionUpdateDTO() { Id = 1, FuncionDesc = name, EstaActivo = true });

            //Assert
            Assert.Equal(expected, response.Succeeded);
        }


        [Theory]
        [InlineData(1, true)]
        [InlineData(10, false)]
        public async Task Delete_CheckExistId(int id, bool expected)
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);
            var response = await service.Delete(new RefFuncionDeleteDTO() { Id = id});
            await unitofworkbis.CompleteAsync();

            //Assert
            Assert.Equal(expected, response.Succeeded);
        }

        [Fact]
        public async Task Delete_SuccessCheckEntitiesCount()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion C", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);
            await service.Delete(new RefFuncionDeleteDTO() { Id = 1 });
            await unitofworkbis.CompleteAsync();

            var response = await service.GetByFilter(new RefFuncionGetByFilterDTO() { EstaActivo = true });

            //Assert
            Assert.Equal(2, response.Entities.Count);
        }

        [Fact]
        public async Task Delete_SuccessCheckGetById()
        {
            //Arrange
            var dbName = Guid.NewGuid().ToString();
            var unitofwork = BuildUnitofWork(dbName);

            //Act
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion A", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion B", EstaActivo = true });
            await unitofwork.RefFuncionRepository.Create(new RefFuncion() { FuncionDesc = "RefFuncion C", EstaActivo = true });

            await unitofwork.CompleteAsync();

            var unitofworkbis = BuildUnitofWork(dbName);
            var mapper = BuildAutoMapper();

            RefFuncionService service = new RefFuncionService(unitofworkbis, mapper);
            await service.Delete(new RefFuncionDeleteDTO() { Id = 1 });
            await unitofworkbis.CompleteAsync();

            var response = await service.GetById(1);

            //Assert
            Assert.False(response.Succeeded);
        }
    }
}
