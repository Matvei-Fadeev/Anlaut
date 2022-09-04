using UniRx;

namespace Jam.Game.StartUp
{
    public class StartUpModel
    {
        public enum ELoadingProgress
        {
            NotLoaded = -1,
            StartLoading = 0,
            LoadGamePlay = 50,
            GamePlay = 100
        }

        public ReactiveProperty<ELoadingProgress> LoadingProgress { get; } =
            new ReactiveProperty<ELoadingProgress>(ELoadingProgress.LoadGamePlay);

        public StartUpModel()
        {
        }
    }
}