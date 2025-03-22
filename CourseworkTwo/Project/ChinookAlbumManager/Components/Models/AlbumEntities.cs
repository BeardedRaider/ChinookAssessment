namespace AlbumDetails
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string? Title { get; set; }
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; } // Navigation property
        public List<Track>? Tracks { get; set; } // Navigation property
    }

    public class Artist
    {
        public int ArtistId { get; set; }
        public string? Name { get; set; }
        public List<Album>? Albums { get; set; } // Navigation property
    }

    public class Track
    {
        public int TrackId { get; set; }
        public string? Name { get; set; }
        public int AlbumId { get; set; }
        public Album? Album { get; set; } // Navigation property
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }
        public string? Composer { get; set; }
        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public decimal UnitPrice { get; set; }
        public List<Playlist_track>? Playlist_tracks { get; set; } // Navigation property
    }

    public class Genres
    {
        public int GenreId { get; set; }
        public string? Name { get; set; }
    }

    public class Media_types
    {
        public int MediaTypeId { get; set; }
        public string? Name { get; set; }
    }

    public class Playlist_track
    {
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
        public Track? Track { get; set; } // Navigation property

    }

    public class Playlists
    {
        public int PlaylistId { get; set; }
        public string? Name { get; set; }
        public List<Playlist_track>? Playlist_tracks { get; set; } // Navigation property
    }
}
