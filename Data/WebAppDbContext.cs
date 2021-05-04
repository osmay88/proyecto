using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Data
{
    public class WebAppDbContext : IdentityDbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ImageFile> ImageFiles { get; set; }
    }
}
