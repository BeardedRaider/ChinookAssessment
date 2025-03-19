namespace AlbumDetails
{

    public class Album
    {
        public int AlbumId { get; set; }
        public string? Title { get; set; }
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; } // Navigation property


    }

    public class Artist
    {
        public int ArtistId { get; set; }
        public string? Name { get; set; }
        public List<Album>? Albums { get; set; } // Navigation property
    }

}