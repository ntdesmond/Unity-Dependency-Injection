using System;
using Presentation;
using UnityEngine;
using UnityEngine.UI;

public class BallView : MonoBehaviour, IView
{
    public event Action Collided;
        
    [SerializeField] private Text _healthTextField;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("BallObstacle"))
        {
            return;
        }
        Collided?.Invoke();
    }

    public void DisplayHealth(int health)
    {
        _healthTextField.text = health.ToString();
    }
}