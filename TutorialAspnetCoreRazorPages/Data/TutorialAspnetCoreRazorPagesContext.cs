using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorialAspnetCoreRazorPages.Models;

namespace TutorialAspnetCoreRazorPages.Data
{
    public class TutorialAspnetCoreRazorPagesContext : DbContext
    {
        public TutorialAspnetCoreRazorPagesContext (DbContextOptions<TutorialAspnetCoreRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<TutorialAspnetCoreRazorPages.Models.Movie> Movie { get; set; } = default!;
    }
}
