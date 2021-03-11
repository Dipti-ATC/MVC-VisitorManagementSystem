using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.Data
{
    public class VisitorDbContext : DbContext
    {
        public VisitorDbContext(DbContextOptions<VisitorDbContext> options)
            : base(options)
        {
        }
        public VisitorDbContext()
        {

        }

        //Dataset for models
        public DbSet<StaffNames> Staffnames { get; set; }
        public DbSet<Visitors> Visitors { get; set; }
    }
}
