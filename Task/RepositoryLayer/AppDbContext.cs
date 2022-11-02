﻿using DomainLayer.Configurations;
using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
       
        
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new StudentConfiguration());
                modelBuilder.ApplyConfiguration(new StudentDetailConfiguration());
                base.OnModelCreating(modelBuilder);
            }
        
    }
}
