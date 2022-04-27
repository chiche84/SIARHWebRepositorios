using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;

using Me.Siarh.Pof.Domain.Entities;
using Me.Siarh.Pof.Persistence.Filters;
using Me.Siarh.Common.Persistence;

namespace Me.Siarh.Pof.Persistence
{
    public class RefFuncionRepository : GenericRepository<RefFuncion, RefFuncionFilter>, IRefFuncionRepository
    {

        public RefFuncionRepository(PofDbContext context, ILogger logger) : base(context, logger)
        {
        }


        public override IQueryable<RefFuncion> Filter(RefFuncionFilter filter)
        {
            var query = dbSet.AsQueryable();

            if (filter.Id != 0)
                query = query.Where(x => x.Id == filter.Id);

            if (filter.FuncionDesc != null)
                query = query.Where(x => x.FuncionDesc == filter.FuncionDesc);

            if (filter.FuncionDescContains != null)
                query = query.Where(x => x.FuncionDesc.Contains(filter.FuncionDescContains));

            if (filter.EstaActivo != null)
                query = query.Where(x => x.EstaActivo == filter.EstaActivo);

            if (filter.ExcludeIds.Any())
                query = query.Where(x => !filter.ExcludeIds.Contains(x.Id));

            if (filter.IncludeIds.Any())
                query = query.Where(x => filter.IncludeIds.Contains(x.Id));

            return query;

        }

        public int OtherMethod()
        {
            return 1;
        }

    }
}

