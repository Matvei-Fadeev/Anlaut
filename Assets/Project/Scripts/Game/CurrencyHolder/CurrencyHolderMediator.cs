using System.Collections.Generic;
using System.Linq;
using Core.Contexts;
using Project.Scripts.Game.Currency;

namespace Jam.Game.CurrencyHolder
{
    public interface ICurrencyHolderMediator
    {
        public void ChangeCurrency(CurrencyValue currencyValue);
        public void AddCurrency(CurrencyValue currencyValue);
        public void RemoveCurrency(CurrencyValue currencyValue);
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
                AddCurrency(currencyValue);
            else
                RemoveCurrency(currencyValue);
        }

        public void AddCurrency(CurrencyValue currencyValue)
        {
            if (Model.TryToAddCurrency(currencyValue))
            {
                View.UpdateCurrency(Model.GetCurrencyValue(currencyValue.currencyType));
            }
        }

        public void RemoveCurrency(CurrencyValue currencyValue)
        {
            if (Model.TryToSpentCurrency(currencyValue))
            {
                View.UpdateCurrency(Model.GetCurrencyValue(currencyValue.currencyType));
            }
        }

        public bool HasAny()
        {
            return Model.currencyValues.Any(x => x.amount > 0);
        }

        public List<CurrencyValue> GetCurrency()
        {
            return Model.currencyValues.Select(currencyValue => currencyValue.Clone()).ToList();
        }
    }
}