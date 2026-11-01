using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartMenu.Models;

namespace SmartMenu.Data;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<SmartMenu.Models.Client> Client { get; set; } = default!;

        public DbSet<SmartMenu.Models.Order> Order { get; set; } = default!;

        public DbSet<SmartMenu.Models.Product> Products { get; set; } = default!;
    
    }
