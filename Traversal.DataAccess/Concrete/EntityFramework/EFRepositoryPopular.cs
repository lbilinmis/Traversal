using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete.Contexts;
using Traversal.DataAccess.Concrete.Repositories.Base;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Concrete.EntityFramework
{
    public class EFRepositoryPopular : GenericRepositoryBase<Popular, TraversalContext>, IPopularRepository
    {
    }
}
