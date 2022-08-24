﻿using Core.Commands;
using Zenject;

namespace Core.Installers
{
    public class CoreContextInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);
            
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


            Container.Bind<PromiseLoader>().AsTransient();

            Container.BindInterfacesTo<AsyncSceneLoader>().AsTransient();
        }
    }
}