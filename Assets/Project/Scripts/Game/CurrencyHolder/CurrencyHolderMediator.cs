using Core.Contexts;
using Project.Scripts.Game.Currency;

namespace Jam.Game.CurrencyHolder
{
    public interface ICurrencyHolderMediator
    {
        public void ChangeCurrency(CurrencyValue currencyValue);
    }
    
    public class CurrencyHolderMediator : Mediator<ICurrencyHolderView, CurrencyHolderModel>, ICurrencyHolderMediator
    {
        public override void Initialize()
        {
            base.Initialize();
        }
        
        public void ChangeCurrency(CurrencyValue currencyValue)
        {
            if (Model.TryToSpentCurrency(currencyValue))
            {
                // TODO
            }
        }
    }
}