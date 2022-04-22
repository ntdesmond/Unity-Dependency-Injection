using System;
using GameSetup;
using Presentation;

public class HealthModel : IModel
{
    public event Action HealthChanged;
    public int Health { get; private set; }
        
    public HealthModel(HealthConfig healthConfig)
    {
        Health = healthConfig.InitialHealth;
    }

    public void OnCollided()
    {
        Health--;
        HealthChanged?.Invoke();
    }
}