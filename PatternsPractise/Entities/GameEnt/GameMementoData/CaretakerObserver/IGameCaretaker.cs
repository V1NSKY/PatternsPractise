namespace PatternsPractise.Entities.GameEnt.GameMementoData.MementoObserver
{
    public interface IGameCaretaker
    {
        public void AddObserver(IObserverGameCaretaker observer);
        public void DeleteObserver(IObserverGameCaretaker observer);
        public void Notify();
    }
}
