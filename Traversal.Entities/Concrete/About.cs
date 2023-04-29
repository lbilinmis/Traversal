using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Abstract;

namespace Traversal.Entities.Concrete
{
    public class About : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
