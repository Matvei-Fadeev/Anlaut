using Core.Contexts.FSM;
using UniRx;
using Zenject;

namespace Jam.Game.StartUp
{
    public partial class StartUpMediator : StateMachineMediator<StartUpMediator, StartUpView, StartUpModel>
    {
        public override void Initialize()
        {
            base.Initialize();
            
            StateBehaviours.Add((int)StartUpModel.ELoadingProgress.LoadGamePlay, new StartUpStateLoadGamePlay(this));
            StateBehaviours.Add((int)StartUpModel.ELoadingProgress.GamePlay, new StartUpStateGamePlay(this));

            Model.LoadingProgress.Subscribe(OnLoadingProgressChanged).AddTo(Disposables);
        }

        public void OnLoadingProgressChanged(StartUpModel.ELoadingProgress loadingProgress)
        {
            View.Progress = (float)loadingProgress / 100;
            GoToState((int)loadingProgress);
        }
    }
}