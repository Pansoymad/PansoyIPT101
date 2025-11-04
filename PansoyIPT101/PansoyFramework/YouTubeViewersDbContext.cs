using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PansoyIPT101Solution.PansoyFramework.DTOs;

namespace PansoyIPT101Solution.PansoyFramework
{
    public class YouTubeViewersDbContext : DbContext
    {
        public YouTubeViewersDbContext(DbContextOptions options) : base(options) { }

        public DbSet<YouTubeViewerDto> YouTubeViewers { get; set; }
    }
}
