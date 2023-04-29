using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Concrete.Contexts
{
    public class TraversalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=HUAWEI;Initial Catalog=TravelsalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");
            }
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<OtherPopular> OtherPopulars { get; set; }
        public DbSet<Popular> Populars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
