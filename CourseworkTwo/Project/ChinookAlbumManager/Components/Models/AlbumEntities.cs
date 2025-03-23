namespace AlbumDetails
{
    // Represents an album in the music collection
    public class Album
    {
        public int AlbumId { get; set; } // Unique identifier for the album
        public string? Title { get; set; } // Title of the album
        public int ArtistId { get; set; } // Foreign key to the artist
        public Artist? Artist { get; set; } // Navigation property to the artist
        public List<Track>? Tracks { get; set; } // Navigation property to the tracks in the album
    }

    // Represents an artist in the music collection
    public class Artist
    {
        public int ArtistId { get; set; } // Unique identifier for the artist
        public string? Name { get; set; } // Name of the artist
        public List<Album>? Albums { get; set; } // Navigation property to the albums by the artist
    }

    // Represents a track in the music collection
    public class Track
    {
        public int TrackId { get; set; } // Unique identifier for the track
        public string? Name { get; set; } // Name of the track
        public int AlbumId { get; set; } // Foreign key to the album
        public Album? Album { get; set; } // Navigation property to the album
        public int MediaTypeId { get; set; } // Foreign key to the media type
        public int GenreId { get; set; } // Foreign key to the genre
        public string? Composer { get; set; } // Composer of the track
        public int Milliseconds { get; set; } // Duration of the track in milliseconds
        public int Bytes { get; set; } // Size of the track in bytes
        public decimal UnitPrice { get; set; } // Price of the track
        public List<Playlist_track>? Playlist_tracks { get; set; } // Navigation property to the playlist tracks
    }

    // Represents a genre in the music collection
    public class Genres
    {
        public int GenreId { get; set; } // Unique identifier for the genre
        public string? Name { get; set; } // Name of the genre
    }

    // Represents a media type in the music collection
    public class Media_types
    {
        public int MediaTypeId { get; set; } // Unique identifier for the media type
        public string? Name { get; set; } // Name of the media type
    }

    // Represents a playlist track in the music collection
    public class Playlist_track
    {
        public int PlaylistId { get; set; } // Foreign key to the playlist
        public int TrackId { get; set; } // Foreign key to the track
        public Track? Track { get; set; } // Navigation property to the track
    }

    // Represents a playlist in the music collection
    public class Playlists
    {
        public int PlaylistId { get; set; } // Unique identifier for the playlist
        public string? Name { get; set; } // Name of the playlist
        public List<Playlist_track>? Playlist_tracks { get; set; } // Navigation property to the playlist tracks
    }
}
