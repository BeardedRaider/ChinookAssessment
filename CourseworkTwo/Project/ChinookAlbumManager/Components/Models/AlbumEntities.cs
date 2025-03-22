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

    public class Customers
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public int SupportRepId { get; set; }
    }

    public class Employees
    {
        public int EmployeeId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Title { get; set; }
        public int ReportsTo { get; set; }
        public string? BirthDate { get; set; }
        public string? HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
    }

    public class Invoice_items
    {
        public int InvoiceLineId { get; set; }
        public int InvoiceId { get; set; }
        public int TrackId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

    public class Invoices
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public string? InvoiceDate { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingPostalCode { get; set; }
        public decimal Total { get; set; }
    }

