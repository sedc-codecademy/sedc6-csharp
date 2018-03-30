using System.Collections.Generic;

namespace Advanced06
{
    public class Album
    {
        #region Properties
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        #endregion

        #region Constructors
        public Album() { }
        public Album(int id, int artistId, string name, Genre genre, int year)
        {
            Id = id; ArtistId = artistId; Name = name; Genre = genre; Year = year;
        }
        #endregion

        #region @Overrides
        public override string ToString()
        {
            return $"ID:{Id}, Name:{Name}, Genre{Genre}({Year})";
        }
        #endregion
    }
}