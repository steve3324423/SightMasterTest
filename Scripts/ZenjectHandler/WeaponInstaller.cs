using UnityEngine;
using Zenject;

public class WeaponInstaller : MonoInstaller
{
    [SerializeField] private Aim _aim;

    public override void InstallBindings()
    {
        if (Application.isMobilePlatform)
            Container.Bind<IInputWeapon>().To<DekstopWeapon>().AsSingle();
        else
            Container.Bind<IInputWeapon>().To<DekstopWeapon>().AsSingle();

        Container.Bind<Aim>().FromComponentOnRoot().AsSingle();
    }
}
