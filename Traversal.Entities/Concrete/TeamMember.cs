using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Abstract;

namespace Traversal.Entities.Concrete
{
    public class TeamMember : IEntity
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
