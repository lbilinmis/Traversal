using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Abstract;

namespace Traversal.Entities.Concrete
{
    public class Newsletter:IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
