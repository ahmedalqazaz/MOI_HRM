using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOI_HRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOI_HRM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<HRM> HRMTable { get; set; }
    }
}
