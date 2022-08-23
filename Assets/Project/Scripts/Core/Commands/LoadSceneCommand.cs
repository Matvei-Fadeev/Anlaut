﻿using Project.Scripts.Core.Installers;
using Zenject;

namespace Project.Scripts.Core.Commands
{
    public class LoadSceneCommand : BaseCommand
    {
        [Inject] private readonly ISceneLoader _sceneLoader;

        public void Execute(LoadSceneSignal loadParams)
        {
            _sceneLoader.LoadScene (loadParams.Scene).Done(
                () =>
                {
                    loadParams.OnComplete?.Resolve();
                },
                exception =>
                {
                    loadParams.OnComplete?.Reject(exception);
                }
            );
        }
    }
}
