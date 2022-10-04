using Core.Commands;
using Core.Installers;
using Zenject;

namespace Core.SceneLoader
{
    public class SceneContextInstaller : Installer<SceneContextInstaller>
    {
        public override void InstallBindings()
        {
            Container.DeclareSignal<LoadSceneSignal>();
            Container.BindSignal<LoadSceneSignal>()
                .ToMethod<LoadSceneCommand>(x => x.Execute)
                .FromNew();

            Container.DeclareSignal<LoadUnloadScenesSignal>();
            Container.BindSignal<LoadUnloadScenesSignal>()
                .ToMethod<LoadUnloadScenesCommand>(x => x.Execute)
                .FromNew();

            Container.DeclareSignal<UnloadSceneSignal>();
            Container.BindSignal<UnloadSceneSignal>()
                .ToMethod<UnloadSceneCommand>(x => x.Execute)
                .FromNew();

            Container.DeclareSignal<UnloadAllScenesExceptSignal>();
            Container.BindSignal<UnloadAllScenesExceptSignal>()
                .ToMethod<UnloadAllScenesExceptCommand>(x => x.Execute)
                .FromNew();

            Container.BindInterfacesTo<AsyncSceneLoader>().AsTransient();
        }
    }
}