using Zenject;

public class MainInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MainCanvas>().FromComponentInHierarchy().AsSingle();
    }
}