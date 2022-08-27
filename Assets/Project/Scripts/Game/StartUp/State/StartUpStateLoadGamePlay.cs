using Core.Installers;
using Project.Scripts.Game.Constants;

namespace AnlautJam.Game.StartUp
{
    public partial class StartUpMediator
    {
        public class StartUpStateLoadGamePlay : State
        {
            public StartUpStateLoadGamePlay(StartUpMediator mediator) : base(mediator)
            {
            }

            public override void OnStateEnter()
            {
                base.OnStateEnter();

                LoadSceneSignal.Load(Constants.Scenes.GamePlay, SignalBus).Done(
                    () => { Model.LoadingProgress.Value = StartUpModel.ELoadingProgress.GamePlay; });
            }
        }
    }
}