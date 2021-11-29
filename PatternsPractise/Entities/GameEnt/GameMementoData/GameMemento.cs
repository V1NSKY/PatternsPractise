namespace PatternsPractise.Entities.GameEnt
{
    public class GameMemento
    {
        private Game _game;
        public GameMemento(Game game)
        {
            this._game = game;
        }
        public Game GetGameState()
        {
            return this._game;
        }
    }
}
