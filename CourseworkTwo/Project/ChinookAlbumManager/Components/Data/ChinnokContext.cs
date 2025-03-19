using Microsoft.EntityFrameworkCore;

namespace AlbumDetails
{
    public class ChinookContext : DbContext
    {
        public ChinookContext(DbContextOptions<ChinookContext> options) 
        : base(options) { }

        public DbSet<Album>? Albums { get; set; }
        public DbSet<Artist>? Artists { get; set; }
        

    }
}