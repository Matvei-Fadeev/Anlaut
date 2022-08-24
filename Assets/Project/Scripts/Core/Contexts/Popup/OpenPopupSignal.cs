using Core.thirdparty.RSG.Promise.v1._3._0._0;
using Zenject;

namespace Core.Contexts.Popup
{
    public class OpenPopupSignal
    {
        public IPopupConfig PopupConfig;
        public Promise<IPopupResult> OnPopupComplete;
        
        public static Promise<IPopupResult> ShowPopup(IPopupConfig popupConfig, SignalBus signalBus)
        {
            OpenPopupSignal openPopupParams =
                new OpenPopupSignal
                {
                    OnPopupComplete = new Promise<IPopupResult>(),
                    PopupConfig = popupConfig
                };

            signalBus.Fire(openPopupParams);

            return openPopupParams.OnPopupComplete;
        }
    }
}