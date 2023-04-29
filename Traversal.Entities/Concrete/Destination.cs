using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Abstract;

namespace Traversal.Entities.Concrete
{
    public class Destination : IEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
