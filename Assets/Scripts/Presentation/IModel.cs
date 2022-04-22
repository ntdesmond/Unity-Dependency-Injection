using System;

namespace Presentation
{
    public interface IModel
    {
        public event Action HealthChanged;
    
        public int Health { get; }

        public void OnCollided();
    }
}