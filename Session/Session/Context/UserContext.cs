using Session.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session.Context
{
    public class UserContext : DbContext
    {
        public UserContext()
         : base("name=Default")
        {
        }


        public DbSet<User> Users { get; set; }
    }
}