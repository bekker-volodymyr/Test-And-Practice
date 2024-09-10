using UnityEngine;
using Zenject;

public class LoggerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ILogger>()
            .To<TMPLogger>()
            .FromNew()
            .AsSingle();

        Container
            .Bind<ILogger>()
            .WithId("Debug")
            .To<DebugLogger>()
            .FromNew()
            .AsSingle();
    }
}