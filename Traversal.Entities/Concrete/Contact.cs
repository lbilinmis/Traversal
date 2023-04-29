using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Abstract;

namespace Traversal.Entities.Concrete
{
    public class Contact:IEntity    
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string GoogleMap { get; set; }
        public bool Status { get; set; }
    }
}
