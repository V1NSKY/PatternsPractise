using PatternsPractise.Entities.GameEnt.GameMementoData.MementoObserver;
using System.Collections.Generic;

namespace PatternsPractise.Entities.GameEnt
{
    public class GameCaretaker : IGameCaretaker
    {
        private Stack<GameMemento> stackMemento = new Stack<GameMemento>();
        private List<IObserverGameCaretaker> observers = new List<IObserverGameCaretaker>();
        public bool IsLastStateDeleted()
        {
            if(stackMemento.Count != 0)
            {
                if (Session.daoGame.GetGameById(stackMemento.Peek().GetGameState().GameId) == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void RemoveLastState()
        {
            if (stackMemento.Count != 0)
            {
                stackMemento.Pop();
                Notify();
            }
        }
        public GameMemento ReturnToLastGameState()
        {
            if (stackMemento.Count == 0)
            {
                Notify();
                return null;
            }
            else
            {
                GameMemento tempMemento = stackMemento.Pop();
                Notify();
                return tempMemento;
            }
        }
        public void AddGameState (GameMemento gameMemento)
        {
            stackMemento.Push(gameMemento);
            Notify();
        }
        public int ReturnCountOfMemento()
        {
            return stackMemento.Count;
        }

        public void AddObserver(IObserverGameCaretaker observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserverGameCaretaker observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserverGameCaretaker observer in observers)
            {
                observer.Update();
            }
        }
    }
}
