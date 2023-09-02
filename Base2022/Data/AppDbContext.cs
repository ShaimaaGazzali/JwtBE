using Base2022.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Base2022.Data
{
    public class AppDbContext: IdentityDbContext<AppUser, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<TaskK> Tasks { get; set; }
    }
}
