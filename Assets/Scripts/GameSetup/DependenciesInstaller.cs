using DELTation.DIFramework;
using DELTation.DIFramework.Containers;
using Presentation;
using UnityEngine;

namespace GameSetup
{
    public sealed class DependenciesInstaller : DependencyContainerBase
    {
        [SerializeField] private HealthConfig healthConfig; 
        [SerializeField] private BallView _ballView; 
        [SerializeField] private BarView _barView; 
        [SerializeField] private bool _useBarAndButton; 
        
        protected override void ComposeDependencies(ICanRegisterContainerBuilder builder)
        {
            // Register the view depending on the toggle
            if (_useBarAndButton)
            {
                builder.Register(_barView);
            }
            else
            {
                builder.Register(_ballView);
            }
            
            // Register all common dependencies
            builder
                .Register(healthConfig)
                .Register<GameInit>()
                .Register<HealthModel>()
                .Register<Presenter>();
        }
    }
}
