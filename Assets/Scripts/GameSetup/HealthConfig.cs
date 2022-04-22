using UnityEngine;

namespace GameSetup
{
    [CreateAssetMenu(fileName = "HealthConfig", menuName = "Health Config", order = 51)]
    public class HealthConfig : ScriptableObject
    {
        public int InitialHealth => _initialHealth;

        [Min(1)]
        [SerializeField] private int _initialHealth;
        
        
    }
}