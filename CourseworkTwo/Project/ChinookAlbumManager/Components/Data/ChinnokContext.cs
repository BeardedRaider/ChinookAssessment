using Microsoft.EntityFrameworkCore;

namespace AlbumDetails
{
    public class ChinookContext : DbContext
    {
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder
        .UseSqlite("Data Source=Chinook.db")
        .LogTo(Console.WriteLine, LogLevel.Information); // Add logging
    optionsBuilder.AddInterceptors(new ForeignKeyInterceptor());
}
        public ChinookContext(DbContextOptions<ChinookContext> options) 
            : base(options) { }

        public DbSet<Album>? Albums { get; set; }
        public DbSet<Artist>? Artists { get; set; }
        public DbSet<Track>? Tracks { get; set; }
        public DbSet<Genres>? Genres { get; set; }
        public DbSet<Media_types>? Media_types { get; set; }
        public DbSet<Playlist_track>? Playlist_track { get; set; }
        public DbSet<Playlists>? Playlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasKey(a => a.AlbumId);
            modelBuilder.Entity<Artist>().HasKey(a => a.ArtistId);
            modelBuilder.Entity<Track>().HasKey(t => t.TrackId);
            modelBuilder.Entity<Genres>().HasKey(g => g.GenreId);
            modelBuilder.Entity<Media_types>().HasKey(m => m.MediaTypeId);
            modelBuilder.Entity<Playlist_track>().HasKey(pt => new { pt.PlaylistId, pt.TrackId });
            modelBuilder.Entity<Playlists>().HasKey(p => p.PlaylistId);

            // Configure relationships and cascading deletes
            modelBuilder.Entity<Album>()
                .HasMany(a => a.Tracks)
                .WithOne(t => t.Album)
                .HasForeignKey(t => t.AlbumId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Track>()
                .HasMany(t => t.Playlist_tracks)
                .WithOne(pt => pt.Track)
                .HasForeignKey(pt => pt.TrackId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}