using System.Collections.Generic;

namespace Advanced05
{
    public class Artist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ArtistType ArtistType { get; set; }
        public List<Album> Albums { get; set; }
        public Artist() { }
        public Artist(int id, string fullName, ArtistType artistType)
        {
            Id = id;FullName = fullName;ArtistType = artistType;
        }
    }
}