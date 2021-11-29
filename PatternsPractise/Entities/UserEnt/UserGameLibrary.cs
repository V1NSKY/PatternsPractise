using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PatternsPractise.Entities
{
    [BsonIgnoreExtraElements]
    public class UserGameLibrary
    {
        private User user;
        private Game game;
        private String dateAdded;
        private int? hoursPlayed = 0;
        private String? dateLastPlayed = null;

        private UserGameLibrary() { }

        public User User
        {
            get
            {
                return user;
            }
            set
            {
                this.user = value;
            }
        }
        public int GameId
        {
            get
            {
                return this.game.GameId;
            }
        }
        public String GameName
        {
            get
            {
                return this.game.GameName;
            }
        }
        public Game Game
        {
            get
            {
                return this.game;
            }
            set
            {
                this.game = value;
            }
        }
        public String DateAdded
        {
            get
            {
                return this.dateAdded;
            }
            set
            {
                this.dateAdded = value;
            }
        }
        public int? HoursPlayed
        {
            get
            {
                return this.hoursPlayed;
            }
            private set
            {
                this.hoursPlayed = value;
            }
        }
        public String? DateLastPlayed
        {
            get
            {
                return this.dateLastPlayed;
            }
            set
            {
                this.dateLastPlayed = value;
            }
        }
        public class LibraryBuilder
        {
            UserGameLibrary gameLibrary;
            public LibraryBuilder()
            {
                this.gameLibrary = new UserGameLibrary();
            }
            public LibraryBuilder user(User user)
            {
                this.gameLibrary.user = user;
                return this;
            }
            public LibraryBuilder game(Game game)
            {
                this.gameLibrary.game = game;
                return this;
            }
            public LibraryBuilder dateAdded(String dateAdded)
            {
                this.gameLibrary.dateAdded = dateAdded;
                return this;
            }
            public LibraryBuilder hoursPlayed(int hoursPlayed)
            {
                this.gameLibrary.hoursPlayed = hoursPlayed;
                return this;
            }
            public LibraryBuilder dateLastPlayed(String dateLastPlayed)
            {
                this.gameLibrary.dateLastPlayed = dateLastPlayed;
                return this;
            }
            public UserGameLibrary Build()
            {
                return gameLibrary;
            }
        }
    }
}
