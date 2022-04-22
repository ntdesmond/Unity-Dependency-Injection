using System;

namespace Presentation
{
    public class Presenter : IDisposable
    {
        private readonly IView _view;
        private readonly IModel _model;

        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.Collided += OnCollided;
            _model.HealthChanged += OnHealthChanged;
            
            OnHealthChanged();
        }

        public void Dispose()
        {
            _view.Collided -= OnCollided;
            _model.HealthChanged -= OnHealthChanged;
        }

        private void OnCollided()
        {
            _model.OnCollided();
        }

        private void OnHealthChanged()
        {
            _view.DisplayHealth(_model.Health);
        }
    }
}