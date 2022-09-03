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
            return currencyValues.Find(x => x.currencyType == currencyType);
        }
    }
}