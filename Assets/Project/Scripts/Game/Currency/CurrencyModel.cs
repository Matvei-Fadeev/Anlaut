using System;
using System.Collections.Generic;

namespace Project.Scripts.Game.Currency
{
    [Serializable]
    public class CurrencyModel
    {
        public List<CurrencyValue> currencyValues = new List<CurrencyValue>();

        public CurrencyValue GetCurrencyValue(CurrencyType currencyType)
        {
            var currencyValue = currencyValues.Find(x => x.currencyType == currencyType);
            if (currencyValue == null)
            {
                currencyValue = new CurrencyValue
                {
                    amount = 0,
                    currencyType = currencyType
                };
                currencyValues.Add(currencyValue);
            }

            return currencyValue;
        }

        public bool TryToAddCurrency(CurrencyValue currencyToAdd)
        {
            var amountToAdd = currencyToAdd.amount;
            var currencyValue = GetCurrencyValue(currencyToAdd.currencyType);
            currencyValue.amount += amountToAdd;
            return true;
        }

        public bool TryToSpentCurrency(CurrencyValue currencyToSpend)
        {
            var amountToSpend = currencyToSpend.amount;
            var currencyValue = GetCurrencyValue(currencyToSpend.currencyType);
            if (currencyValue.amount < amountToSpend)
                return false;
            currencyValue.amount -= amountToSpend;
            return true;
        }
    }
}