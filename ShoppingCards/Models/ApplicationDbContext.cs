using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCard.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext

    {
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
