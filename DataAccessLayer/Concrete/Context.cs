using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=TraversalDB;integrated security=true;"); 
        }

        //To reflect entities to sql
        public DbSet<AboutTop> AboutTops { get; set; }
        public DbSet<AboutLower> AboutLowers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Highlight> Highlights { get; set; } //feature
        public DbSet<HighlightChild> HighlightChilds { get; set; } //feature2
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }

        
    }
}
