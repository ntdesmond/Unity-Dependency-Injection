using System;

namespace Presentation
{
    public interface IView
    {
        public event Action Collided;

        public void DisplayHealth(int health);
    }
}