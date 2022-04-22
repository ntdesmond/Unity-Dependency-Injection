using System;
using Presentation;

namespace GameSetup
{
    public class GameInit : IDisposable
    {
        private Presenter _presenter;
        
        public GameInit(Presenter presenter)
        {
            _presenter = presenter;
        }
        
        public void Dispose()
        {
            _presenter.Dispose();
        }
    }
}
