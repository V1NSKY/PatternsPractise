using System;

namespace PatternsPractise.Entities
{
    public class GameGenre
    {
        public String genreName { get; set; }
        public GameGenre(String genreName) { this.genreName = genreName;}

        public override string ToString()
        {
            return " Жанр: " + genreName;
        }
    }
}
