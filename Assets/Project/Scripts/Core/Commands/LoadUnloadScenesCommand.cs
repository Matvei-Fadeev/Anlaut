using Core.Installers;
using Core.SceneLoader;
using Core.thirdparty.RSG.Promise.v1._3._0._0;
using UnityEngine;
using Zenject;

namespace Core.Commands
{
    public class LoadUnloadScenesCommand : BaseCommand
    {
        [Inject] private readonly ISceneLoader _sceneLoader;

        //First loads an optional array of scenes, then 
        //unloads a separate optional array of scenes.
        //Each call to load/unload is added into a 
        //promise chain. When complete, the last promise 
        //fires an optional OnComplete delegate.
        public void Execute(LoadUnloadScenesSignal loadUnloadParams)
        {
            IPromise lastPromise = null;

            //Load scenes
            if (loadUnloadParams.LoadScenes != null)
            {
                foreach (var sceneName in loadUnloadParams.LoadScenes)
                {
                    var name = sceneName;
                    lastPromise = lastPromise != null ? lastPromise.Then(() => _sceneLoader.LoadScene(name)) : _sceneLoader.LoadScene(sceneName);
                }
            }

            //Unload scenes
            if (loadUnloadParams.UnloadScenes != null)
            {
                foreach (var sceneName in loadUnloadParams.UnloadScenes)
                {
                    var name = sceneName;
                    lastPromise = lastPromise != null ? lastPromise.Then(() => _sceneLoader.UnloadScene(name)) : _sceneLoader.UnloadScene(sceneName);
                }
            }

            //Add promise to resolve OnComplete
            if (lastPromise != null)
            {
                lastPromise.Done(
                    () =>
                    {
                        Debug.Log($"{this} , scene loading/unloading completed!");

                        loadUnloadParams.OnComplete?.Resolve();
                    },
                    exception =>
                    {
                        loadUnloadParams.OnComplete?.Reject(exception);
                    }
                );
            }
            else
            {
                Debug.Log($"{this} , no scenes loaded/unloaded!");

                loadUnloadParams.OnComplete?.Resolve();
            }
        }
    }
}

