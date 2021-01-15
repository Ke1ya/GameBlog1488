using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameBlog1488.Models
{
    public class DateContecst: DbContext
    {
        public DateContecst() : base("DefaultConnection") {}
        public DbSet<User> Users { get; set;}
        public DbSet<Post> Posts { get; set;}
        public DbSet<Genre> Genres { get; set;}
    }
}