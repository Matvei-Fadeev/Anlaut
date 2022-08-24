using Core.Contexts.FSM;
using UniRx;
using Zenject;

namespace AnlautJam.Game.StartUp
{
    public partial class StartUpMediator : StateMachineMediator
    {
        [Inject] private readonly StartUpView _startUpView;
        [Inject] private readonly StartUpModel _startUpModel;
        
        public override void Initialize()
        {
            base.Initialize();
            
            StateBehaviours.Add((int)StartUpModel.ELoadingProgress.LoadGamePlay, new StartUpStateLoadGamePlay(this));
            StateBehaviours.Add((int)StartUpModel.ELoadingProgress.GamePlay, new StartUpStateGamePlay(this));

            _startUpModel.LoadingProgress.Subscribe(OnLoadingProgressChanged).AddTo(Disposables);
        }

        public void OnLoadingProgressChanged(StartUpModel.ELoadingProgress loadingProgress)
        {
            _startUpView.Progress = (float)loadingProgress / 100;
            GoToState((int)loadingProgress);
        }
    }
}