using Core.Installers;
using UnityEngine;

namespace AnlautJam.Game.Movement
{
    public class MovementInstaller : ContextInstaller<MovementMediator, IMovementView, MovementModel>
    {
        [SerializeField] private MovementView movementView;

        protected override IMovementView View => movementView;
    }
}