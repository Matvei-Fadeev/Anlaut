using System.Collections.Generic;
using System.Linq;
using Core.Contexts;
using Project.Scripts.Game.Currency;

namespace Jam.Game.CurrencyHolder
{
    public interface ICurrencyHolderMediator
    {
        public void ChangeCurrency(CurrencyValue currencyValue);
        public bool TryAddCurrency(CurrencyValue currencyValue);
        public bool TryRemoveCurrency(CurrencyValue currencyValue);
    }

    public class CurrencyHolderMediator : Mediator<ICurrencyHolderView, CurrencyHolderModel>, ICurrencyHolderMediator
    {
        public override void Initialize()
        {
            base.Initialize();

            foreach (var modelCurrencyValue in Model.currencyValues)
            {
                View.UpdateCurrency(modelCurrencyValue);
            }
        }

        public void ChangeCurrency(CurrencyValue currencyValue)
        {
            if (currencyValue.amount > 0)
                TryAddCurrency(currencyValue);
            else
                TryRemoveCurrency(currencyValue);
        }

        public bool TryAddCurrency(CurrencyValue currencyValue)
        {
            if (Model.TryToAddCurrency(currencyValue))
            {
                View.UpdateCurrency(Model.GetCurrencyValue(currencyValue.currencyType));
                return true;
            }

            return false;
        }

        public bool TryRemoveCurrency(CurrencyValue currencyValue)
        {
            if (Model.TryToSpentCurrency(currencyValue))
            {
                View.UpdateCurrency(Model.GetCurrencyValue(currencyValue.currencyType));
                return true;
            }

            return false;
        }

        public bool HasAny()
        {
            return Model.currencyValues.Any(x => x.amount > 0);
        }

        public List<CurrencyValue> GetCurrency()
        {
            return Model.currencyValues.Select(currencyValue => currencyValue.Clone()).ToList();
        }

        public CurrencyValue GetCurrency(CurrencyType currencyType)
        {
            return Model.currencyValues.FirstOrDefault(currencyValue => currencyValue.currencyType == currencyType)
                ?.Clone() ?? Model.GetDefault(currencyType);
        }
    }
}