using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    [SerializeField] private Mover _mover;

    public override void InstallBindings()
    {
        if (Application.isMobilePlatform)
            Container.Bind<IInput>().To<MobileInput>().AsSingle();
        else
            Container.Bind<IInput>().To<DekstopInput>().AsSingle();

        Container.Bind<Mover>().FromComponentOnRoot().AsSingle();
    }
}
