using Core.Installers;
using UnityEngine;

namespace Jam.Game.CurrencyHolder
{
    public class CurrencyHolderInstaller : MonoInstaller<CurrencyHolderMediator, ICurrencyHolderView, CurrencyHolderModel>
    {
        [SerializeField] private CurrencyHolderView CurrencyHolderView;

        protected override ICurrencyHolderView View => CurrencyHolderView;
    }
}