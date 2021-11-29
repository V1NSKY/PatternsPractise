using PatternsPractise.Entities.GameEnt.GameMementoData.MementoObserver;
using System.Windows.Forms;

namespace PatternsPractise.Entities.GameEnt.GameMementoData.CaretakerObserver
{
    class GameCaretakerObserver : IObserverGameCaretaker
    {
        Label _label;
        public GameCaretakerObserver(Label label)
        {
            _label = label;
        }
        public void Update()
        {
            _label.Text = Session.gameCaretaker.ReturnCountOfMemento().ToString();
        }
    }
}
