using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Abstract;

namespace Traversal.Entities.Concrete
{
    public class Service : IEntity
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
