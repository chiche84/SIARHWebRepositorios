using AutoMapper;
using Me.Siarh.Pof.Application;
using Me.Siarh.Pof.Persistence;
using Me.Siarh.Pof.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Siarh.Pof.Quality
{
    public class GenericQuality
    {

        protected UnitOfWork BuildUnitofWork(string dbName) 
        {
            var opciones = new DbContextOptionsBuilder<PofDbContext>().UseInMemoryDatabase(dbName).Options;
            var dbContext = new PofDbContext(opciones);

            ILoggerFactory loggerFactory = new LoggerFactory(); 

            return new UnitOfWork(dbContext, loggerFactory);

        }

        protected IMapper BuildAutoMapper()
        {
            var config = new MapperConfiguration(options => options.AddProfile(new RefFuncionProfile()));

            return config.CreateMapper();
        }


    }
}
