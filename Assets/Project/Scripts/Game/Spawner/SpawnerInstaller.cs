using Core.Installers;
using UnityEngine;

namespace AnlautJam.Game.Spawner
{
    public class SpawnerInstaller : MonoInstaller<SpawnerMediator, ISpawnerView, SpawnerModel>
    {
        [SerializeField] private SpawnerView spawnerView;

        protected override ISpawnerView View => spawnerView;
    }
}