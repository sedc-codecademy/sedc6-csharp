using System.Collections.Generic;

namespace Advanced06
{
    public class Artist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ArtistType ArtistType { get; set; }
        public Artist() { }
        public Artist(int id, string fullName, ArtistType artistType)
        {
            Id = id;FullName = fullName;ArtistType = artistType;
        }















    }
}