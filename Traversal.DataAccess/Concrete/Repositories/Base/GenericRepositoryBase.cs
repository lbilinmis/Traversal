using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Abstract.Base;
using Traversal.Entities.Abstract;

namespace Traversal.DataAccess.Concrete.Repositories.Base
{
    public class GenericRepositoryBase<T, TContext> : IGenericBaseRepository<T> 
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
    }
}
