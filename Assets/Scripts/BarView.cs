using System;
using GameSetup;
using Presentation;
using UnityEngine;
using UnityEngine.UI;

public class BarView : MonoBehaviour, IView
{
    public event Action Collided;
        
    [SerializeField] private Button _hitButton;
    [SerializeField] private Image _healthBar;

    private float _barWidthFraction;

    public void Construct(HealthConfig healthConfig)
    {
        // Calculate the width needed for 1 HP and save it
        _barWidthFraction = _healthBar.rectTransform.sizeDelta.x / healthConfig.InitialHealth;
    }
    
    private void Awake()
    {
        _hitButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Collided?.Invoke();
    }

    public void DisplayHealth(int health)
    {
        // Avoid displaying negative values
        if (_barWidthFraction <= 0 || health < 0)
        {
            return;
        }
        
        // Set the bar width using the health value
        _healthBar.rectTransform.SetSizeWithCurrentAnchors(
            RectTransform.Axis.Horizontal, _barWidthFraction * health
        );
    }
}